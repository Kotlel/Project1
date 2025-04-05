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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddEvent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string eventName = EventName_txt.Text;
                DateTime eventDate;
                string participants = Participants_txt.Text;

                if (!DateTime.TryParse(EventDate_txt.Text, out eventDate))
                {
                    MessageBox.Show("Некорректный формат даты.");
                    return;
                }

                using (var context = new Model1())
                {
                    var meeting = new Meeting
                    {
                        EventName = eventName,
                        Date = eventDate,
                        Participants = participants
                    };

                    context.Meetings.Add(meeting);
                    context.SaveChanges();
                }

                MessageBox.Show("Событие успешно добавлено!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении события: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
