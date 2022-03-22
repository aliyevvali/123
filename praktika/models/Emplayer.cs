using System;
using System.Collections.Generic;
using System.Text;

namespace praktika.models
{
    class Emplayer:Person
    {
        
        
        public double SalaryOfHour { get; set; }           
        public double WorkingHour {get;set;
            //get 
            //{
            //    return _workinghour;
            //} 
            //set 
            //{
            //    if (value<240)
            //    {
            //        _workinghour =value;
            //    }
            //} 
        }
        public Emplayer(string name,string surname,int age,double salaryofhour, double workinghour):base(name,surname,age)
        {
            this.SalaryOfHour = salaryofhour;this.WorkingHour = workinghour;
        }
        public double CalculateSalary()
        {
            return (SalaryOfHour * WorkingHour);
        }


    }
}
