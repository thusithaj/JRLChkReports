﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace JRLChkReports
{
    public partial class JRLChkMDIParent : Form
    {
        private int childFormNumber = 0;

        public JRLChkMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void workcodeAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCodeAdd childForm = new FormCodeAdd();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string formName = "FormChkrollSlip";
            string dllPath =  Application.StartupPath + "\\ReportsFormofCHK.dll";
            Assembly asm = Assembly.LoadFile(@dllPath);
            Type[] typeList = asm.GetTypes();
            Type type = typeList.Where(o => o.Name == formName).FirstOrDefault();
            //Type myType = asm.GetType(formName);
            ConstructorInfo[] constructorInfoObj = type.GetConstructors();
            ConstructorInfo cninfo = constructorInfoObj[0];
            Form newForm = (Form) cninfo.Invoke(null);
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string formName = "FormChkrollLedger";
            string dllPath = Application.StartupPath + "\\ReportsFormofCHK.dll";
            Assembly asm = Assembly.LoadFile(@dllPath);
            Type[] typeList = asm.GetTypes();
            Type type = typeList.Where(o => o.Name == formName).FirstOrDefault();
            //Type myType = asm.GetType(formName);
            ConstructorInfo[] constructorInfoObj = type.GetConstructors();
            ConstructorInfo cninfo = constructorInfoObj[0];
            Form newForm = (Form)cninfo.Invoke(null);
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }
    }
}