using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;
using DatabaseLibrary.Classes;
using static ExampleWinFormApplication.Classes.Dialogs;

namespace ExampleWinFormApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Shown += MainForm_Shown;
        }
        /// <summary>
        /// Load customers name and primary key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Shown(object sender, EventArgs e)
        {
            var items = await DataOperations.GetCustomers();
            CustomersListBox.DataSource = items;
        }
        /// <summary>
        /// Increment current customer's sequence value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncrementButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;
            
            var currentCustomer = (CustomerItem)CustomersListBox.SelectedItem;
            if (Question($"Create next sequence value for '{currentCustomer.Name}'"))
            {
                SequenceTextBox.Text = DataOperations.GetCustomerNextSequenceValue(currentCustomer.Id);
            }
          

        }
        /// <summary>
        /// Show current customer's sequence value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;

            var currentCustomer = (CustomerItem)CustomersListBox.SelectedItem;

            SequenceTextBox.Text = DataOperations.GetCustomerCurrentSequenceValue(currentCustomer.Id);
        }
    }
}
