using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_LAB2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            this.Text = "Store Management";
            this.Size = new System.Drawing.Size(800, 600);

            var menuPanel = new Panel()
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = System.Drawing.Color.LightGray
            };

            var buttonSales = new Button() { Text = "Sales", Dock = DockStyle.Top };
            var buttonInventory = new Button() { Text = "Inventory", Dock = DockStyle.Top };
            var buttonReports = new Button() { Text = "Reports", Dock = DockStyle.Top };
            var buttonUsers = new Button() { Text = "Users", Dock = DockStyle.Top };

            buttonSales.Click += (sender, args) =>
            {
                var salesForm = new SalesForm();
                salesForm.ShowDialog();
            };

            menuPanel.Controls.Add(buttonUsers);
            menuPanel.Controls.Add(buttonReports);
            menuPanel.Controls.Add(buttonInventory);
            menuPanel.Controls.Add(buttonSales);

            this.Controls.Add(menuPanel);
        }

    }
}
