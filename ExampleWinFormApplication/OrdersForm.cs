using System;
using System.Windows.Forms;
using DatabaseLibrary.Classes;

namespace ExampleWinFormApplication
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Shown += OrdersForm_Shown;
        }

        private async void OrdersForm_Shown(object sender, EventArgs e)
        {
            var orders = await DataOperations.GetOrders();
            dataGridView1.DataSource = orders;
        }
    }
}
