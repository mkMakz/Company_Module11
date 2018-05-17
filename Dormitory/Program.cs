using Dormitory.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate gen = new Generate();
            gen.GenerateStudents();
            gen.PrintInfo();

            Console.WriteLine("\n");

            gen.GenerateDormitoryQueue(gen.students);


        }
    }
}
