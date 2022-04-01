using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Classes
{
    public class Employee : Member
    {
        private double? Salary=300;
        public int HoursPerMonth { get; set; }
        public double? Bonus;
        public void SetBonus()
        {
            if(HoursPerMonth>160)
            {
                 Bonus = Salary * 0.3;
            }
            else
            {
                 Bonus = null;
            }
        }
        public void SetSalary()
        {
            Salary = HoursPerMonth * Bonus + Salary;
        }
    }
}
