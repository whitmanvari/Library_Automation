using Library.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User: Person
    {
        public override string Password { get; set; }
        public override string Phone { get; set; }
        public override string Address { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string Email { get; set; }

        //Birth date value cannot be in the future.
        public override DateTime BirthDate
        {
            get => BirthDate;
            set 
            {
                if(BirthDate < DateTime.Now)
                {
                    throw new ArgumentException("Birth date cannot be in the future!");
                }
            }
    }
}
