using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_LAB2
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Sales";
            this.Size = new System.Drawing.Size(600, 400);

            var productList = new ListBox() { Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(200, 300) };
            productList.Items.AddRange(new string[] { "Product 1", "Product 2", "Product 3" });

            var cartList = new ListBox() { Location = new System.Drawing.Point(350, 20), Size = new System.Drawing.Size(200, 300) };

            var buttonAddToCart = new Button()
            {
                Text = "Add to Cart",
                Location = new System.Drawing.Point(240, 150),
                Width = 100
            };
            buttonAddToCart.Click += (sender, args) =>
            {
                if (productList.SelectedItem != null)
                {
                    cartList.Items.Add(productList.SelectedItem);
                }
            };

            this.Controls.Add(productList);
            this.Controls.Add(cartList);
            this.Controls.Add(buttonAddToCart);
        }
    }
}
