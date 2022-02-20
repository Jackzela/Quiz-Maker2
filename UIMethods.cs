using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz_Maker2
{
    
    internal class UIMethods
    {
       
        /// <summary>
        /// This method take the question and serialize it
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
        public static void InsertQuestionAndAnswers(string question, string answer)
        {
            List<QuestionAndAnswers> questionAndAnswersList = new List<QuestionAndAnswers>();

           var path = @"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro\test.xml";
           Program.Save(path, questionAndAnswersList);
            var q =new QuestionAndAnswers();
            Console.WriteLine("Write the question!");
            q.question = Console.ReadLine();
            for (int i = 0; i < 3; i++) ;
            {
                Console.WriteLine($"answer n.{i}");
                string answers = Console.ReadLine();
                q.answer.Add(answers);
                questionAndAnswersList .Add(q);
            }
            Program.Save(path, questionAndAnswersList);
        }


    }
}
