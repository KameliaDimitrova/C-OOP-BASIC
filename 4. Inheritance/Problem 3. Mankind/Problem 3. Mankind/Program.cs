using System;
using System.Linq;

namespace Problem_3._Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Worker worker = new Worker();
            var studentData = Console.ReadLine().Split(' ').ToList();
            var workerData = Console.ReadLine().Split(' ').ToList();
            try
            {
                student=new Student(studentData[0],studentData[1],studentData[2]);
                worker=new Worker(workerData[0],workerData[1],decimal.Parse(workerData[2]),decimal.Parse(workerData[3]));
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
                return;
            }
            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
    }
}
