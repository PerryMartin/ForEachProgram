/*
 * Created by: Perry Martin
 * Created on: 19-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-12
 * This program changes the text colour when button is pressed 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachProgram
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in this.Controls)
            {
                aControl.ForeColor = Color.Red;
            }
        }
    }
}
