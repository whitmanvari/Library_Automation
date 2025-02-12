using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        private int _id;
        private string _name;
        private string _surname;
        private DateTime _birthDate;
        private string _email;
        private string _password;

        //Id is read-only.
        public int Id
        {
            get { return _id; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cannot be a negative value!");
                    _id = value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be an empty value!");
                    _name = value.Trim();
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Surname cannot be an empty value!");
                    _surname = value.Trim();
                }
            }
        }
        //Birth-Date cannot be setted in the future.
        public DateTime BirthDate
        {
            get { return _birthDate; } 
            set
            {
                if (_birthDate < DateTime.Now)
                {
                    throw new ArgumentException("Birth-Date cannot be in the future!");
                    _birthDate = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
