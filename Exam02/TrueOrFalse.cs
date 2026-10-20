using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, double marks, Answer[] answersList)
            : base(header, body, marks)
        {
            AnswersList = new Answer[]
                {
                new Answer(1, "True"),
                new Answer(2, "False")
                };
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
