using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace Dormitory.Modules
{
    public class Generate
    {
        private Random r = new Random();
        public List<Student> students;
        public List<Student> dormitoryqueue;
        public int MinSalary { get; set; }

        public void GenerateStudents()
        {
            MinSalary = r.Next(5000, 25000) * 2;
            students = new List<Student>();
            Generator generator = new Generator();

            for (int i = 0; i < 20; i++)
            {
            Student st = new Student();
            st.FullName = generator.GenerateDefault((Gender)r.Next(0, 2));
            st.Group = r.Next(100, 120);
            st.AverageMark = r.Next(70, 98);
            st.Income = r.Next(30000, 150000);
            st.Form = (EducationForm)r.Next(0, 2);

            students.Add(st);

            }

        }


        public void PrintInfo()
        {
            foreach (Student item in students)
            {
                Console.WriteLine($"Name {item.FullName}\n Group {item.Group}\n Average mark {item.AverageMark}\n" +
                      $" Income {item.Income}\n Form {item.Form}\n");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

        }

    

        public void GenerateDormitoryQueue(List<Student> stud)
        {

            if(stud != null)
            {
                dormitoryqueue = new List<Student>();
               

                foreach (Student item in students)
                {

                    if (item.Income < MinSalary * 2)
                        dormitoryqueue.Add(item);

                }

                foreach (Student item in students)
                {
                    if (item.Income > MinSalary * 2)
                        dormitoryqueue.Add(item);
                }


                var result = from Student in dormitoryqueue
                             orderby Student.Income, Student.AverageMark
                             select Student;
                foreach (Student item in result)
                    Console.WriteLine($"Name {item.FullName}\n Group {item.Group}\n Average mark {item.AverageMark}\n" +
                     $" Income {item.Income}\n Form {item.Form}\n");


            }





        }



    }
}
