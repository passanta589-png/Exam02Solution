using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }
        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam (Time: {TimeOfExam} minutes, Questions: {NumberOfQuestions})");
            foreach (var item in QuestionsList)
            {
                Question question01 = item.Key;
                Answer rightAnswer = item.Value;


                question01.DisplayQuestion();
                Console.WriteLine($"Right Answer ID: {question01.RightAnswer?.AnswerId}");
                Console.WriteLine($"Right Answer Text: {question01.RightAnswer?.AnswerText}");
            }
        }
        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
