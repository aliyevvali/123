using praktika.models;
using System;

namespace praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emplayer emplayer = new Emplayer(5,8,"Kamil","Abdullayev",20);
            //Student student = new Student("a","v",20,70,60);
            Console.WriteLine("1- Emplayer \n2- Student");
            Console.Write("Select your choice :");            
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Name of the employee :");
                    string name = Console.ReadLine();

                    Console.Write("Surname of the employee :");
                    string surname = Console.ReadLine();

                    int age;
                    do
                    {
                        Console.Write("Age of the employee :");
                        age = Convert.ToInt32(Console.ReadLine());
                    } while (age<18 || age<0);
                    
                    
                    Console.Write("Salary of hour :");
                    double salaryofhour = Convert.ToDouble(Console.ReadLine());

                    double workinghour;
                    do
                    {
                        Console.Write("Working hours in month :");
                        workinghour = Convert.ToDouble(Console.ReadLine());

                    } while (workinghour > 240 || workinghour < 0 );
                    
                    Emplayer emplayer = new Emplayer(name,surname,age,salaryofhour,workinghour);
                    
                    double salaryofmonth = emplayer.CalculateSalary();
                    if (salaryofmonth > 250)
                    {
                        Console.WriteLine("Salary of month ---> " + salaryofmonth);
                    }
                    else
                    {
                        Console.WriteLine("Salary of  month can't be under then 250");
                    }
                    Console.ReadLine();



                    break;
                case 2 :
                    Console.Write("Name of the student :");
                    string name1 = Console.ReadLine();

                    Console.Write("Surname of the  student :");
                    string surname1 = Console.ReadLine();

                    int age1;
                    do
                    {
                        Console.Write("Age of the student :");
                        age1 = Convert.ToInt32(Console.ReadLine());
                    } while (age1>=20 || age1 <6 ||age1 <0);

                    double iqrank;
                    do
                    {
                        Console.Write("Student's IQ rank :");
                        iqrank = Convert.ToDouble(Console.ReadLine());
                    } while (iqrank<0 || iqrank>100);

                    double languagerank;
                    do
                    {
                        Console.Write("Student's laungage rank :");
                        languagerank = Convert.ToDouble(Console.ReadLine());
                    } while (languagerank <0 || languagerank>100);
                    

                    Student student = new Student(name1,surname1,age1,iqrank, languagerank);

                    double examresult = student.ExamResult();
                    if (examresult >120 )
                    {
                        Console.Write("U pass the class,Ur point is :"+examresult);
                    }
                    else
                    {
                        Console.Write("U can't pass the class,Ur point is :"+examresult);
                    }
                    Console.ReadLine();

                    break;


                    
            }
        }
    }
}
