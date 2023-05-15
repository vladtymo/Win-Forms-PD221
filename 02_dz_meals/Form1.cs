namespace _03_list_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OrderBtnClick(object sender, EventArgs e)
        {
            double price = 0;

            // ------- show total price
            // 1 - check manually
            //if (radioButton1.Checked)
            //    price += 15;
            //else if (radioButton2.Checked)
            //    price += 34;

            // 2 - using group controls array
            var checkedRb = drinksGroup.Controls.OfType<RadioButton>().First(x => x.Checked);

            string drinkName = checkedRb.Text;
            double drinkPrice = double.Parse(checkedRb.Tag.ToString());

            MessageBox.Show($"Result: {drinkName} - {drinkPrice} UAH");
        }
    }
}