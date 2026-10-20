using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }
        public Answer[] AnswersList { get; set; }

        public Question(string header, string body, double marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }
        public abstract void DisplayQuestion();
   

    }
}
