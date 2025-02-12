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
    }
}
