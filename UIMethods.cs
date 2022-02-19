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
       for (int i=0)
        /// <summary>
        /// This method take the question and serialize it
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
        public static void insertQuestionAndAnswers(string question, string answer)
        {
            var path = @"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro\test.xml";
            List<QuestionAndAnswers> questionAndAnswersList = new List<QuestionAndAnswers>();
            Program.Save(path, questionAndAnswersList);

            QuestionAndAnswers questionAndAnswers = new QuestionAndAnswers();
            Console.WriteLine("Write the question separated by|, the right must be followed by*");
            questionAndAnswers.question = Console.ReadLine();
            questionAndAnswersList.Add(questionAndAnswers);//this should add the var questionAndAnswers to the array questionAndAnswersList
        }


    }
}
