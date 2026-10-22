using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(101, "C# Programming");

            sub.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start The Exam (y | n): ");

            if (char.TryParse(Console.ReadLine(), out char choice) && (choice == 'y' || choice == 'Y'))
            {
                Console.Clear();

                Stopwatch sw = new Stopwatch();
                sw.Start();

                sub.SubjectExam.ShowExam();

                sw.Stop();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Exam cancelled.Goodbye!");
            }
        }
    }
}
