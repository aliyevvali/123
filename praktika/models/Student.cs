using System;
using System.Collections.Generic;
using System.Text;

namespace praktika.models
{
    class Student :Person
    {
        public double IqRank { get; set; }
        public double LanguageRank { get; set; }

        public Student(string name,string surname,int age,double iqrank,double laungagerank):base(name,surname,age)
        {
            this.IqRank = iqrank;this.LanguageRank = laungagerank;
        }
        public double ExamResult()
        {
            return IqRank + LanguageRank;
        }
    }
}
