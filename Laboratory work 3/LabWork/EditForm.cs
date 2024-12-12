using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabWork
{
    public partial class EditForm : Form
    {
        MainForm frm;
        public Conference conference;

        public EditForm(MainForm _frm)
        {
            InitializeComponent();
            conference = new Conference();
            frm = _frm;
        }

        private Boolean CheckUniqueConference(string place, string date, int rowIndex)
        {
            try
            {
                foreach (DataGridViewRow row in frm.dataGridView1.Rows)
                {
                    if (row.Index != rowIndex &&
                        place.Equals(row.Cells[1].Value) &&
                        date.Equals(row.Cells[2].Value))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool action = true;
            int rowIndex = frm.dataGridView1.CurrentCell.RowIndex;

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                conference.Title = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Please enter the Title properly!");
                action = false;
            }

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                conference.Place = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Please enter the Place properly!");
                action = false;
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                conference.Date = textBox3.Text;
            }
            else
            {
                MessageBox.Show("Please enter the Date properly!");
                action = false;
            }

            conference.Cost = textBox4.Text;
            conference.ApplicationDeadline = textBox5.Text;
            conference.Organizer = textBox6.Text;

            if (action)
            {
                if (CheckUniqueConference(conference.Place, conference.Date, rowIndex))
                {
                    DataGridViewRow row = frm.dataGridView1.Rows[rowIndex];
                    row.Cells[0].Value = conference.Title;
                    row.Cells[1].Value = conference.Place;
                    row.Cells[2].Value = conference.Date;
                    row.Cells[3].Value = conference.Cost;
                    row.Cells[4].Value = conference.ApplicationDeadline;
                    row.Cells[5].Value = conference.Organizer;

                    frm.list[rowIndex] = new Conference(
                        conference.Title,
                        conference.Place,
                        conference.Date,
                        conference.Cost,
                        conference.ApplicationDeadline,
                        conference.Organizer
                    );

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("This conference already exists. Please enter unique Place, and Date.");
                }
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            int rowIndex = frm.dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = frm.dataGridView1.Rows[rowIndex];
            textBox1.Text = (string)row.Cells[0].Value;
            textBox2.Text = (string)row.Cells[1].Value;
            textBox3.Text = (string)row.Cells[2].Value;
            textBox4.Text = (string)row.Cells[3].Value;
            textBox5.Text = (string)row.Cells[4].Value;
            textBox6.Text = (string)row.Cells[5].Value;
        }
    }
}
