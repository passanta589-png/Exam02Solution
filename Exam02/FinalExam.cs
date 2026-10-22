using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
            
        }
        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam (Time: {TimeOfExam} minutes, Questions: {NumberOfQuestions})");
            double totalGrade = 0;
            foreach (var question in QuestionsList)
            {
                Question question01 = question.Key;
                Answer userAnswer = question.Value;
                question01.DisplayQuestion();
                if (userAnswer != null && question01.RightAnswer != null)
                {
                    if (userAnswer.AnswerId == question01.RightAnswer.AnswerId)
                    {
                        totalGrade += question01.Marks;
                    }
                }
            }
            Console.WriteLine($"Total Grade: {totalGrade}");
        }
        public override object Clone()
        {
            return this.MemberwiseClone();

        }
    }
}
