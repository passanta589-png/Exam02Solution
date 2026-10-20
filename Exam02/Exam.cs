using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] QuestionsList { get; set; }

        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }
        public abstract void ShowExam();
        public abstract object Clone();
    }
}
