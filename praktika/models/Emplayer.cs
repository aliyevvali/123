using System;
using System.Collections.Generic;
using System.Text;

namespace praktika.models
{
    class Emplayer:Person
    {
        public double SalaryOfHour { get; set; }
        public double WorkingHour { get; set; }
        public Emplayer(double salaryofhour, double workinghour,string name,string surname,int age):base(name,surname,age)
        {
            this.SalaryOfHour = salaryofhour;this.WorkingHour = workinghour;
        }
        public void CalculateSalary()
        {

        }


    }
}
