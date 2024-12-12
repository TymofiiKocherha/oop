using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LabWork
{
    public partial class AboutForm : Form
    {
        Form _frm;
        public AboutForm(Form frm)
        {
            InitializeComponent();
            _frm = frm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _frm.Enabled = true;
            this.Close();
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frm.Enabled = true;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void groupLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
