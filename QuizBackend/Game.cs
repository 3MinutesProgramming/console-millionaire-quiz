using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuizBackend
{
    public class Game
    {
        public Game()
        {
            CurrentCategory = "$500";
            UserPrize = "$0";
            CreateCategories();
            CreateQuestions();
        }



        public List<Question> AllQuestions { get; set; }

        public List<string> Categories { get; set; }

        public string CurrentCategory { get; set; }
        public string UserPrize { get; set; }


        private void CreateCategories()
        {
            Categories = new List<string>()
            {
                "$500",
                "$1 000",
                "$2 000",
                "$5 000",
                "$10 000",
                "$20 000",
                "$50 000",
                "$75 000",
                "$150 000",
                "$250 000",
                "$500 000",
                "$1 000 000"
            };
        }
         

        private void CreateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var content = File.ReadAllText(path);
            AllQuestions = JsonConvert.DeserializeObject<List<Question>>(content);
        }

        public Question GetQuestion()
        {
            var questionsFromCurrentCategory = AllQuestions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Randomizer.GetRandomNumber(8);
            return questionsFromCurrentCategory[number - 1];
        }
            
    }
}
