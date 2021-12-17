using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelForm
{
    public partial class TravelsOptionsForm : Form
    {
        public TravelsOptionsForm()
        {
            InitializeComponent();
            SetUpUI();
        }
        private TravelListForm TLF = new TravelListForm();
        public void SetUpUI()
        {
            radioButtonByTravelType.Checked = true;
            checkBoxPictures.Checked = true;
            checkBoxText.Checked = true;

            comboBoxTravelType.DataSource = new List<String>()
            {
                "----Select----",
                "Air",
                "Car",
                "MotorBike",    
                "Taxi",
                "Train",
                "Cano"
            };
            
            comboBoxContinent.DataSource = new List<String>() 
            {
                "---Select---",
                "Asia",
                "Africa",
                "North America",
                "South America",
                "Australia",
                "Antarctica"
            };


        }

        private void buttonView_Click(object sender, EventArgs e)
        {

           
            TLF.Show();
        }
    }
}
