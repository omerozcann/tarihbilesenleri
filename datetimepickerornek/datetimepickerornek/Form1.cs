using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepickerornek
{
    public partial class datetimeFrm : Form
    {
        public datetimeFrm()
        {
            InitializeComponent();
        }

        private void tarihbtn_Click(object sender, EventArgs e)
        {
            tamtxt.Text= dateTimePicker1.Text;
            guntxt.Text = dateTimePicker1.Value.Day.ToString();
            gunisimtxt.Text = dateTimePicker1.Text.Split(' ')[3];
            aytxt.Text= dateTimePicker1.Value.Month.ToString();
            ayisimtxt.Text = dateTimePicker1.Text.Split(' ')[1];
            yiltxt.Text= dateTimePicker1.Value.Year.ToString();
        }

        private void tarihbtn2_Click(object sender, EventArgs e)
        {
            tamtxt.Text = DateTime.Now.ToLongDateString();
            guntxt.Text = DateTime.Now.Day.ToString();
            gunisimtxt.Text = DateTime.Now.ToLongDateString().Split(' ')[3];
            aytxt.Text = DateTime.Now.Month.ToString();
            ayisimtxt.Text = DateTime.Now.ToLongDateString().Split(' ')[1];
            yiltxt.Text = DateTime.Now.Year.ToString();
        }
    }
}
