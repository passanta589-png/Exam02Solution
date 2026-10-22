using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class Exam : ICloneable, IComparable
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, Answer> QuestionsList { get; set; }

        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            this.QuestionsList = new Dictionary<Question, Answer>();
        }
        public abstract void ShowExam();
        public int compareTo(Exam other)
        {
            if (other == null) return 1;
            return this.NumberOfQuestions.CompareTo(other.NumberOfQuestions);
        }
        public abstract object Clone();
        public override string ToString()
        {
            return $"Exam (Time: {TimeOfExam} minutes, Questions: {NumberOfQuestions})";
        }
    }
}