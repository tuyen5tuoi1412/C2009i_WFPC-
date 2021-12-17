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
    public partial class TravelListForm : Form
    {
        public TravelListForm()
        {
            InitializeComponent();
            List<String> xx = new List<String>()
            {
                "Nguyen van A","18","ee@gmail.com"
            };
            String[] someData = { "Nguyen van A", "18", "ee@gmail.com" };
            listViewTravels.Columns.Add("Name", 150);
            listViewTravels.Columns.Add("Age", 50);
            listViewTravels.Columns.Add("Email", 150);

            listViewTravels.Items.Add(new ListViewItem(someData));

          
               
        }
    }
}
