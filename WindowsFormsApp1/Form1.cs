using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UtilityLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            var value = "AB001";
            for (int index = 0; index < 200000; index++)
            {
                value = StringHelpers.IncrementAlphaNumericValue(value);
                list.Add(value);
            }

            listBox1.DataSource = list;

        }
    }
}
