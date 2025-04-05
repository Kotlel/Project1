using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var context = new Model1())
                {
                    var meetings = context.Meetings.ToList();
                    dataGridView1.DataSource = meetings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEvent_btn_Click(object sender, EventArgs e)
        {
            var formAdd = new Form2();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void AddReport_Click(object sender, EventArgs e)
        {

        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            var formAdd = new Form4();
            formAdd.ShowDialog();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int eventId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EventId"].Value);
                string eventName = dataGridView1.Rows[e.RowIndex].Cells["EventName"].Value?.ToString();
                DateTime eventDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Date"].Value);
                string eventParticipants = dataGridView1.Rows[e.RowIndex].Cells["Participants"].Value?.ToString();

                using (Form3 form3 = new Form3(eventId, eventName, eventDate, RefreshDataGridView, eventParticipants))
                {
                    form3.ShowDialog(this);
                }
            }
        }
        private void RefreshDataGridView()
        {
            using (var context = new Model1())
            {
                dataGridView1.AutoGenerateColumns = true;

                var meetings = context.Meetings.ToList();
                dataGridView1.DataSource = meetings;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["EventId"].HeaderText = "EventId";
                    dataGridView1.Columns["EventName"].HeaderText = "EventName";
                    dataGridView1.Columns["Date"].HeaderText = "Date";
                    dataGridView1.Columns["Participants"].HeaderText = "Participants";
                }
            }
        }
    }
}
