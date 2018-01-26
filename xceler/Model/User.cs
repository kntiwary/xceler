using System;
using SQLite;

namespace xceler.Model
{
    public class User
    {
        [PrimaryKey][AutoIncrement]
        public int id { get; set; }
        public string FirstName
        {
            get;
            set;
        }
        public string Lastname
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }
        public string Age
        {
            get;
            set;
        }
        public string MartialStatus
        {
            get;
            set;
        }
        public DateTime Dob
        {
            get;
            set;
        }
        public String Country { get; set; }
    }
}
