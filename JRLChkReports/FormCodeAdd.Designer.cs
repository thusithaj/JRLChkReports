namespace JRLChkReports
{
    partial class FormCodeAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Earning/Deduction Node");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCodeAdd));
            this.gbCode = new System.Windows.Forms.GroupBox();
            this.tvCode = new System.Windows.Forms.TreeView();
            this.imageListOpen = new System.Windows.Forms.ImageList(this.components);
            this.cbAddDedCode = new System.Windows.Forms.ComboBox();
            this.NormalImageList = new System.Windows.Forms.ImageList(this.components);
            this.gbWorkCode = new System.Windows.Forms.GroupBox();
            this.listWC = new System.Windows.Forms.ListView();
            this.WorkCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dbFilter = new System.Windows.Forms.GroupBox();
            this.chkUnAssigned = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.gbCode.SuspendLayout();
            this.gbWorkCode.SuspendLayout();
            this.dbFilter.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCode
            // 
            this.gbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCode.Controls.Add(this.tvCode);
            this.gbCode.Controls.Add(this.cbAddDedCode);
            this.gbCode.Location = new System.Drawing.Point(-1, 2);
            this.gbCode.Name = "gbCode";
            this.gbCode.Size = new System.Drawing.Size(467, 588);
            this.gbCode.TabIndex = 0;
            this.gbCode.TabStop = false;
            this.gbCode.Text = "Earning/Deduction Code";
            // 
            // tvCode
            // 
            this.tvCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCode.Location = new System.Drawing.Point(3, 48);
            this.tvCode.Name = "tvCode";
            treeNode1.ImageKey = "(default)";
            treeNode1.Name = "Node0";
            treeNode1.StateImageIndex = 0;
            treeNode1.Text = "Earning/Deduction Node";
            this.tvCode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvCode.Size = new System.Drawing.Size(461, 537);
            this.tvCode.StateImageList = this.imageListOpen;
            this.tvCode.TabIndex = 2;
            this.tvCode.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvCode_DragDrop);
            this.tvCode.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvCode_DragEnter);
            // 
            // imageListOpen
            // 
            this.imageListOpen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOpen.ImageStream")));
            this.imageListOpen.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOpen.Images.SetKeyName(0, "folder-blue_open.ico");
            // 
            // cbAddDedCode
            // 
            this.cbAddDedCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAddDedCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAddDedCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAddDedCode.FormattingEnabled = true;
            this.cbAddDedCode.Location = new System.Drawing.Point(3, 22);
            this.cbAddDedCode.Name = "cbAddDedCode";
            this.cbAddDedCode.Size = new System.Drawing.Size(461, 26);
            this.cbAddDedCode.TabIndex = 1;
            // 
            // NormalImageList
            // 
            this.NormalImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NormalImageList.ImageStream")));
            this.NormalImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.NormalImageList.Images.SetKeyName(0, "folder.ico");
            // 
            // gbWorkCode
            // 
            this.gbWorkCode.Controls.Add(this.listWC);
            this.gbWorkCode.Controls.Add(this.dbFilter);
            this.gbWorkCode.Controls.Add(this.gbFilter);
            this.gbWorkCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbWorkCode.Location = new System.Drawing.Point(467, 0);
            this.gbWorkCode.Name = "gbWorkCode";
            this.gbWorkCode.Size = new System.Drawing.Size(587, 588);
            this.gbWorkCode.TabIndex = 1;
            this.gbWorkCode.TabStop = false;
            this.gbWorkCode.Text = "Work Codes";
            // 
            // listWC
            // 
            this.listWC.CheckBoxes = true;
            this.listWC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WorkCode});
            this.listWC.Location = new System.Drawing.Point(0, 110);
            this.listWC.Name = "listWC";
            this.listWC.Size = new System.Drawing.Size(587, 472);
            this.listWC.SmallImageList = this.imageListOpen;
            this.listWC.TabIndex = 3;
            this.listWC.UseCompatibleStateImageBehavior = false;
            this.listWC.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listWC_ItemSelectionChanged);
            this.listWC.DragDrop += new System.Windows.Forms.DragEventHandler(this.listWC_DragDrop);
            this.listWC.DragOver += new System.Windows.Forms.DragEventHandler(this.listWC_DragOver);
            this.listWC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listWC_MouseClick);
            this.listWC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listWC_MouseDown);
            // 
            // dbFilter
            // 
            this.dbFilter.Controls.Add(this.chkUnAssigned);
            this.dbFilter.Controls.Add(this.chkAll);
            this.dbFilter.Location = new System.Drawing.Point(274, 25);
            this.dbFilter.Name = "dbFilter";
            this.dbFilter.Size = new System.Drawing.Size(307, 79);
            this.dbFilter.TabIndex = 2;
            this.dbFilter.TabStop = false;
            // 
            // chkUnAssigned
            // 
            this.chkUnAssigned.AutoSize = true;
            this.chkUnAssigned.Location = new System.Drawing.Point(6, 42);
            this.chkUnAssigned.Name = "chkUnAssigned";
            this.chkUnAssigned.Size = new System.Drawing.Size(139, 22);
            this.chkUnAssigned.TabIndex = 1;
            this.chkUnAssigned.Text = "List Unassigned";
            this.chkUnAssigned.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 13);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(163, 22);
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "List all Work Codes";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.bClose);
            this.gbFilter.Controls.Add(this.bSave);
            this.gbFilter.Location = new System.Drawing.Point(6, 22);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(262, 77);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(123, 16);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(114, 51);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "&Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(3, 16);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(114, 51);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Save Node";
            this.bSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // FormCodeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 588);
            this.Controls.Add(this.gbWorkCode);
            this.Controls.Add(this.gbCode);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCodeAdd";
            this.Text = "Code and Workcode Relation";
            this.Load += new System.EventHandler(this.FormCodeAdd_Load);
            this.Resize += new System.EventHandler(this.FormCodeAdd_Resize);
            this.gbCode.ResumeLayout(false);
            this.gbWorkCode.ResumeLayout(false);
            this.dbFilter.ResumeLayout(false);
            this.dbFilter.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCode;
        private System.Windows.Forms.ImageList NormalImageList;
        private System.Windows.Forms.ImageList imageListOpen;
        private System.Windows.Forms.GroupBox gbWorkCode;
        private System.Windows.Forms.ComboBox cbAddDedCode;
        private System.Windows.Forms.GroupBox dbFilter;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ListView listWC;
        private System.Windows.Forms.ColumnHeader WorkCode;
        private System.Windows.Forms.CheckBox chkUnAssigned;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TreeView tvCode;
    }
}

