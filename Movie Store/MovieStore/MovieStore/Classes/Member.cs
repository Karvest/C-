using MovieStore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Classes
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        protected string Password { get; set; }
        protected int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public EnumRole Role { get; set; }
        public string DisplayInfo()
        {
            return $"{FirstName} {LastName}| Regestered on {DateOfRegistration.ToShortDateString()}";
        }


    }
}
