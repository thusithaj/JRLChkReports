using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
namespace JRLChkReports
{
    public partial class FormCodeAdd : Form
    {
        CodeController cctr;
        Code dbobj;
        List<Code> EarnDeductCodes;
        List<PayCode> WorkCodes;
        public FormCodeAdd()
        {
            InitializeComponent();
        }

        private void FormCodeAdd_Load(object sender, EventArgs e)
        {
            cctr = new CodeController();
            LoadCodes();
            LoadWorkCode();
            if (dbobj == null) { bSave.Enabled = false; }
            
        }

        private void LoadCodes()
        {
            TreeNode root = tvCode.Nodes[0];
            EarnDeductCodes = cctr.GetAdditionDeductionCodes().ToList();
            foreach (Code c in EarnDeductCodes)
            {
                TreeNode tn = new TreeNode();
                tn.Checked = false;
                tn.Name = c.ccode;
                tn.Text = c.cdescrip;
                tn.ImageIndex = 0;
                if (c.RelatedWorkCodes!= null)
                {
                    foreach (PayCode pc in c.RelatedWorkCodes)
                    {
                        TreeNode n = new TreeNode();
                        n.Name = pc.pacode;
                        n.Text = pc.pacdes;
                        tn.Nodes.Add(n);
                    }
                }
                root.Nodes.Add(tn);

            }
            tvCode.Refresh();
            tvCode.AllowDrop = true;
            tvCode.ExpandAll();
        //throw new NotImplementedException();
        }

        private void LoadWorkCode()
        {
            listWC.Columns.Clear();
            listWC.FullRowSelect = true;
            listWC.MultiSelect = true;
            listWC.View = View.Details;
            listWC.GridLines = true;
            listWC.HeaderStyle = ColumnHeaderStyle.Clickable;
            ColumnHeader workcodeCol = new ColumnHeader();
            workcodeCol.Text = "Work Codes ";
            workcodeCol.TextAlign = HorizontalAlignment.Right;
            workcodeCol.Width = 250;
            listWC.Columns.Add(workcodeCol);
            WorkCodes = cctr.GetWorkCodes(false).ToList();
            foreach (PayCode pc in WorkCodes)
            {
                ListViewItem lv = new ListViewItem();
                lv.Checked = false;
                lv.Name = pc.pacode;
                lv.Text = pc.pacdes;
                
                listWC.Items.Add(lv);
            }
            listWC.AllowDrop = true;
        }

        private void FormCodeAdd_Resize(object sender, EventArgs e)
        {
            //tvCode.SuspendLayout();
            //Size newSize = new Size();
            //newSize.Height = gbCode.Size.Height - (cbAddDedCode.Height + 10);
            //tvCode.Size = newSize;
            //tvCode.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //tvCode.Top = cbAddDedCode.Height + 50;
            //tvCode.Left = 10;
            //tvCode.Refresh();
            //tvCode.ResumeLayout();
        }

        private void listWC_MouseDown(object sender, MouseEventArgs e)
        {
            listWC.DoDragDrop(listWC.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void tvCode_DragEnter(object sender, DragEventArgs e)
        {
            /*if (e.Data.GetDataPresent(DataFormats.StringFormat, true))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;*/
            e.Effect = DragDropEffects.Move;
        }

        private void listWC_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listWC_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void tvCode_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode nodeToDropIn = this.tvCode.GetNodeAt(this.tvCode.PointToClient(new Point(e.X, e.Y)));
            //TreeNode n;
            if (nodeToDropIn == null) { return; }

            ListView.SelectedListViewItemCollection lvi = (ListView.SelectedListViewItemCollection)e.Data.GetData("System.Windows.Forms.ListView+SelectedListViewItemCollection");
            foreach (ListViewItem item in lvi)
            {
                TreeNode n = new TreeNode();
                n.Text = item.Text;
                n.Name = item.Name;
                n.Tag = item;

                nodeToDropIn.Nodes.Add(n);
                nodeToDropIn.Expand();
                //n.Remove();
            }
            AddWorkCodeObjects(nodeToDropIn);
            
        }

        private void AddWorkCodeObjects( TreeNode node)
        {
            if (node.Nodes.Count == 0) { return; }
            Code cobj = cctr.GetAdditionDeductionCodes().Where(o => o.ccode == node.Name).FirstOrDefault();
            if (cobj != null)
            {
                foreach (TreeNode n in node.Nodes)
                {
                    PayCode pc = new PayCode();
                    if (cobj.RelatedWorkCodes == null)
                    {
                        cobj.RelatedWorkCodes = new List<PayCode>();
                        pc = cctr.GetWorkCodes(false).Where(o => o.pacode == n.Name).FirstOrDefault();
                        cobj.RelatedWorkCodes.Add(pc);
                    }
                    else
                    {
                        if (cobj.RelatedWorkCodes.Count > 0)
                            pc = cobj.RelatedWorkCodes.Where(o => o.pacode == n.Name).FirstOrDefault();
                        else
                            pc = null;
                        if (pc == null)
                        {
                            pc = cctr.GetWorkCodes(false).Where(o => o.pacode == n.Name).FirstOrDefault();
                            cobj.RelatedWorkCodes.Add(pc);
                        }
                    }
                 }
                
            }
            if (dbobj == null)
            {
                dbobj = new Code();
                bSave.Enabled = true;
            }
            dbobj = cobj;
            dbobj.RelatedWorkCodes = cobj.RelatedWorkCodes;
            //throw new NotImplementedException();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (dbobj == null) { bSave.Enabled = false; }
            try
            {
                cctr.SaveRelation(dbobj);
                MessageBox.Show("Saving returned Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbobj = null;
                bSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured during save \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.tvCode.Nodes.Clear();
            this.listWC.Clear();
            this.Close();
        }

        private void listWC_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) { e.Item.Checked = true; }
            else 
            { 
                e.Item.Checked = false;
                foreach( ListViewItem li in listWC.SelectedItems)
                {
                    if (!li.Checked)
                        li.Selected = li.Checked;
                }
            }
        }

        private void listWC_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
