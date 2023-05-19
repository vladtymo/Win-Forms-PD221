namespace _05_multi_forms
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void OpenChildFormBtnClick(object sender, EventArgs e)
        {
            string login = loginTxtBox.Text;

            // ------------ open additional form
            // create form instance
            //Child form = new Child();

            // ---------- transfering data from parent to child
            // 1 - using Form constructor
            Child form = new Child(login);
            // 2 - using Form properties / methods
            form.Login = "custom_login";
            form.ShowGreeting();

            // --------------- opening the Form
            // Show() - show in nomodal mode
            // ShowDialog() - show in modal mode

            //form.Show();
            form.ShowDialog(); // waiting for close

            // 3 - using overloaded Show() / ShowDialog() methods
            //form.Show(Color.LightCoral);
        }

        private void AddProductBtnClick(object sender, EventArgs e)
        {
            CreateProductForm form = new CreateProductForm();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                // code after form was closed
                // get Form result
                var product = form.Product;

                productListBox.Items.Add(product);
            }



        }
    }
}