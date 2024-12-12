using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public partial class AddForm : Form
    {
        MainForm frm;

        public Conference conference;
        public AddForm(MainForm _frm)
        {
            InitializeComponent();
            conference = new Conference();
            frm = _frm;
        }

        public Conference GetConference()
        {
            return conference;
        }

        private Boolean CheckUniqueConference(string place, string date, int rowIndex)
        {    
            foreach (DataGridViewRow row in frm.dataGridView1.Rows)
            {
                if (row.Index != rowIndex && place.Equals(row.Cells[1].Value) &&
                    date.Equals(row.Cells[2].Value))
                {
                    return false;
                }
            }
            return true;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            bool action = true;

            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                conference.Title = txtTitle.Text;
            }
            else
            {
                if (action)
                {
                    MessageBox.Show("Please enter the Title");
                    action = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtPlace.Text))
            {
                conference.Place = txtPlace.Text;
            }
            else
            {
                if (action)
                {
                    MessageBox.Show("Please enter the Place");
                    action = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtDate.Text))
            {
                conference.Date = txtDate.Text;
            }
            else
            {
                if (action)
                {
                    MessageBox.Show("Please enter the Date");
                    action = false;
                }
            }

            conference.Cost = (string)txtCost.Text;
            conference.ApplicationDeadline = (string)txtApplicationDeadline.Text;
            conference.Organizer = (string)txtOrganizer.Text;

            if (action)
            {
                frm.dataGridView1.Rows.Add(conference.Title, conference.Place, conference.Date, conference.Cost, conference.ApplicationDeadline, conference.Organizer);
                frm.list.Add(conference);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}