using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizo
{
    internal class QuizQuestion
    {
        public string Question { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public QuizQuestion(string question, string[] options, int correctAnswerIndex)
        {
            Question = question;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
