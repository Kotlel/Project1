using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Business_project
{
    public class Model1 : DbContext
    {
        public virtual DbSet<Meeting> Meetings { get; set; }

        public Model1() : base("name=Model1")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Model1>());
        }

    }

    public class Meeting
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Participants { get; set; }
    }
}