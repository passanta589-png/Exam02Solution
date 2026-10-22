using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }
        public int V1 { get; }
        public string V2 { get; }

        public Subject(int subjectId, string subjectName, Exam subjectExam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            SubjectExam = subjectExam;
        }

        public Subject(int v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public void CreateExam()
        {
            Console.WriteLine($"\n=== Creating Exam for Subject: {SubjectName} ");

            Console.Write("Enter Type of Exam (1 for Practical, 2 for Final): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Time of Exam in Minutes: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            if (examType == 1)
            {
                SubjectExam = new PracticalExam(time, numberOfQuestions);
            }
            else if (examType == 2)
            {
                SubjectExam = new FinalExam(time, numberOfQuestions);
            }
            if (SubjectExam != null)
            {
                SubjectExam.QuestionsList = new Dictionary<Question, Answer>();
                int i = 0;
            
              do
              {
                Console.WriteLine($"Question [{i + 1} of {numberOfQuestions}] ");

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Marks: ");
                double marks = double.Parse(Console.ReadLine());
                i++;
              }
                while (i < numberOfQuestions);
            }

             Console.WriteLine(" Exam and Questions Created Successfully via do-while!");
        }

}
    }

