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
    public partial class Form3 : Form
    {
        int eventId;
        private Action refreshCallBack;
        public Form3(int eventId, string eventName, DateTime eventDate, Action refreshCallback, string eventParticipants)
        {
            InitializeComponent();

            this.eventId = eventId;
            eventNameBox.Text = eventName.ToString();
            eventDateBox.Text = eventDate.ToString();
            this.refreshCallBack = refreshCallback;
            eventParticipantsBox.Text = eventParticipants.ToString();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить это событие?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new Model1())
                    {
                        var meeting = context.Meetings.Find(eventId);
                        if (meeting != null)
                        {
                            context.Meetings.Remove(meeting);
                            context.SaveChanges();
                            MessageBox.Show("Событие успешно удалено.");
                            refreshCallBack?.Invoke();
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Событие не найдено в базе данных.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении события: {ex.Message}");
                }
            }
        }
        //private void EditButton_Click(object sender, EventArgs e)
        //{
        //    EditEvent(textBox2.Text, textBox3.Text);
        //}
        private void EditEvent(string eventName, string eventDateString)
        {
            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(eventDateString))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (!DateTime.TryParse(eventDateString, out DateTime eventDate))
            {
                MessageBox.Show("Некорректный формат даты. Используйте формат yyyy-MM-dd.");
                return;
            }

            try
            {
                using (var context = new Model1())
                {
                    var meeting = context.Meetings.Find(eventId);
                    if (meeting != null)
                    {
                        meeting.EventName = eventName;
                        meeting.Date = eventDate;

                        context.SaveChanges();
                        MessageBox.Show("Событие успешно обновлено.");

                        refreshCallBack?.Invoke();
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Событие не найдено в базе данных.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении события: {ex.Message}");
            }
        }
    }
}