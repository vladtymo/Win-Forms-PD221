using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_multi_forms
{
    public partial class CreateProductForm : Form
    {
        public Product Product { get; set; }
        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void CreateBtnClick(object sender, EventArgs e)
        {
            // TODO: add data validations

            Product = new Product()
            {
                Name = nameBox.Text,
                Price = priceNumeric.Value
            };

            //this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CloseBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
