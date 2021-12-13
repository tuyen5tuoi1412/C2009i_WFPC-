using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCalculation.DataSource= new List<String>()
            {
                "Add","Minus","Multiple","Devide"

            };
            comboBoxCalculation.SelectedIndexChanged += ComboBoxCalculation_SelectedIndexChanged;
        }

        private void ComboBoxCalculation_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*comboBoxCalculation.SelectedItem*/
        }
        private  void CalculatedData()
        {
            int x = Convert.ToInt32(TextBoxX.Text);
            int y = Convert.ToInt32(TextboxY.Text);
            String myOperator = (String)comboBoxCalculation.SelectedItem;
            int result = 0;
            if (myOperator.ToLower().Equals("add"))
            {
                result = x + y;
            }
            else if (myOperator.ToLower().Equals("minus"))
            {
                result = x - y;
            }
            else if (myOperator.ToLower().Equals("multiple"))
            {
                result = x * y;
            }
            else if (myOperator.ToLower().Equals("devide"))
            {
                result = x / y;
            }
            txtResult.Text = $"{result}";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculatedData();
        }
    }
}
