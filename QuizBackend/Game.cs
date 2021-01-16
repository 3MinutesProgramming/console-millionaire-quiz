using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBackend
{
    public class Game
    {
        public Question GetQuestion()
        {
            Question question = new Question();
            question.Text = "What was the name of brilliant scientist Einstein?";
            question.Answer1 = "Albert";
            question.Answer2 = "Anthony";
            question.Answer3 = "Aaron";
            question.Answer4 = "Andrew";
            return question;
        }
    }
}
