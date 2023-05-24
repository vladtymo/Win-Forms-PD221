namespace _07_tree_list_view
{
    public partial class Form1 : Form
    {
        private const int preloadLevel = 2;
        public Form1()
        {
            InitializeComponent();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            PreloadDirectories(desktopPath);
        }

        private void PreloadDirectories(string root)
        {
            treeView1.Nodes.Clear();
            LoadDirectoriesRecursive(root, treeView1.Nodes, preloadLevel);
        }

        private void LoadDirectoriesRecursive(string root, TreeNodeCollection collection, int level)
        {
            DirectoryInfo rootDir = new(root);

            foreach (var dir in rootDir.GetDirectories()) // subdirectories
            {
                // create new node
                TreeNode node = new(dir.Name);
                // attach directory full path
                node.Tag = dir.FullName;

                collection.Add(node);

                // try catch block to ignore system directories
                try
                {
                    // check if there's any subdirectory
                    if (level > 1 && dir.GetDirectories().Any())
                    {
                        LoadDirectoriesRecursive(dir.FullName, node.Nodes, level - 1);
                    }
                }
                catch { }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
            foreach (TreeNode node in e.Node.Nodes)
            {
                // get directory path
                string path = node.Tag.ToString();
                LoadDirectoriesRecursive(path, node.Nodes, 1);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PreloadDirectories(dialog.SelectedPath);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            DirectoryInfo dir = new(path);

            listView1.Clear();
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new(file.Name, 0);
                item.Tag = file.FullName;

                listView1.Items.Add(item);
            }
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
    }
}