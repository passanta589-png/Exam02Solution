using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, double marks, Answer[] answersList) : base(header, body, marks)
        {
            AnswersList = answersList;
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"[Header: {Header}] (marks: {Marks})");
            Console.WriteLine($"Q: {Body}");
            Console.WriteLine("Answers:");
            foreach (var answer in AnswersList)
            {
                Console.WriteLine(answer.ToString());
            }
        }
    }
}
