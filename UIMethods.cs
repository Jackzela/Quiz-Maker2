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
        public static void insertQuestionAndAnswers(string question, string answer)
        {
            var path = @"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro\test.xml";
            List<QuestionAndAnswers> questionAndAnswersList = new List<QuestionAndAnswers>();
            Save(path, questionAndAnswersList);

            QuestionAndAnswers questionAndAnswers = new QuestionAndAnswers();
            questionAndAnswers.question = Console.ReadLine();
            Console.WriteLine("Write the question separated by|, the right must be followed by*");
            questionAndAnswersList.Add(questionAndAnswers);//this should add the var questionAndAnswers to the array questionAndAnswersList
        }


        private static void Save(string path, List<QuestionAndAnswers> questionAndAnswersList)
        {
            XmlSerializer qnaSerializer = new XmlSerializer(typeof(List<QuestionAndAnswers>));

            FileStream file = File.Create(path);
            qnaSerializer.Serialize(file, questionAndAnswersList);
            file.Close();
        }
        private static QuestionAndAnswers read(string path)
        {
            path = @"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro\test.xml";
            XmlSerializer qnaDeserializer = new XmlSerializer(typeof(List<QuestionAndAnswers>));
            FileStream file =File.OpenRead(path);
            return QuestionAndAnswers;


        }
    }
}
