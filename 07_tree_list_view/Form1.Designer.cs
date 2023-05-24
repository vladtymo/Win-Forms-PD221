namespace _07_tree_list_view
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Employee 1");
            TreeNode treeNode2 = new TreeNode("Employee 2");
            TreeNode treeNode3 = new TreeNode("Manager 1", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node6");
            TreeNode treeNode5 = new TreeNode("Node5", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Node4", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Manager 2", new TreeNode[] { treeNode6 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            listView1 = new ListView();
            imageList2 = new ImageList(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(12, 59);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Employee 1";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Employee 2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Manager 1";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Node6";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Node4";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Manager 2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode7 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(656, 866);
            treeView1.TabIndex = 0;
            treeView1.AfterCollapse += treeView1_AfterCollapse;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-folder-30.png");
            imageList1.Images.SetKeyName(1, "icons8-opened-folder-30.png");
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1684, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(133, 36);
            toolStripButton1.Text = "Open Root";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(70, 36);
            toolStripLabel1.Text = "View:";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "Tiles", "Details", "Large Icons", "Small Icons", "List" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(240, 42);
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList2;
            listView1.Location = new Point(705, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(967, 866);
            listView1.SmallImageList = imageList2;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-file-26.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 937);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ListView listView1;
        private ImageList imageList1;
        private ImageList imageList2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox1;
    }
}