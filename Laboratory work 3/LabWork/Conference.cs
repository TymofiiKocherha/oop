using System;

namespace LabWork
{
    public class Conference
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Place { get; set; }
        public string Cost { get; set; }
        public string ApplicationDeadline { get; set; }
        public string Organizer { get; set; }

        public Conference(string title, string date, string place, string cost, string application, string organizer)
        {
            Title = title;
            Date = date;
            Place = place;
            Cost = cost;
            ApplicationDeadline = application;
            Organizer = organizer;
        }

        public Conference()
        {
           
        }
    }
}


