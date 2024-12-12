using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LabWork
{
    public partial class MainForm : Form
    {
        public List<Conference> list = new List<Conference>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm(this))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    addForm.Close();
                }
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            list.RemoveAt(rowIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new();
            opfd.Title = "Open JSON file";
            opfd.Filter = "JSON files|*.json";
            opfd.InitialDirectory = @"C:\Users\USER\Desktop\";
            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    using (StreamReader r = new StreamReader(opfd.FileName))
                    {
                        string json = r.ReadToEnd();

                        var conferences = JsonConvert.DeserializeObject<List<Conference>>(json);
                        list = conferences;
                        foreach (var conference in conferences)
                        {
                            dataGridView1.Rows.Add(conference.Title, conference.Place, conference.Date, conference.Cost, conference.ApplicationDeadline, conference.Organizer);
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk.\nOriginal error: " + ex.Message);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Conference> conferences = new List<Conference>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)  // Ігноруємо останній "новий" рядок, який використовується для додавання нових записів.
                    {
                        Conference conference = new Conference
                        {
                            Title = row.Cells[0].Value?.ToString(),
                            Place = row.Cells[1].Value?.ToString(),
                            Date = row.Cells[2].Value?.ToString(),
                            Cost = row.Cells[3].Value?.ToString(),
                            ApplicationDeadline = row.Cells[4].Value?.ToString(),
                            Organizer = row.Cells[5].Value?.ToString()
                        };
                        conferences.Add(conference);
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save a JSON file";
                sfd.Filter = "JSON files|*.json";
                sfd.InitialDirectory = @"C:\Users\timoh\Desktop\";
                sfd.FileName = "output.json";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    string json = JsonConvert.SerializeObject(conferences, Formatting.Indented);
                    File.WriteAllText(sfd.FileName, json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(this);
            this.Enabled = false;
            aboutForm.Show();
        }

        private void editRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditForm editForm = new EditForm(this))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    editForm.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var conferences = from elem in list select elem;

                if (!string.IsNullOrEmpty(textTitle.Text))
                {
                    conferences = conferences.Where(c => c.Title.Contains(textTitle.Text));
                }

                if (!string.IsNullOrEmpty(textPlace.Text))
                {
                    conferences = conferences.Where(c => c.Place.Contains(textPlace.Text));
                }

                if (!string.IsNullOrEmpty(textDate.Text))
                {
                    conferences = conferences.Where(c => c.Date.Contains(textDate.Text));
                }

                dataGridView1.DataSource = null;

                dataGridView1.Rows.Clear();
                foreach (var conference in conferences)
                {
                    dataGridView1.Rows.Add(conference.Title, conference.Place, conference.Date, conference.Cost, conference.ApplicationDeadline, conference.Organizer);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.Rows.Clear();
            foreach (var conference in list)
            {
                dataGridView1.Rows.Add(conference.Title, conference.Place, conference.Date, conference.Cost, conference.ApplicationDeadline, conference.Organizer);
            }

            textTitle.Text = "";
            textPlace.Text = "";
            textDate.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellNumLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
