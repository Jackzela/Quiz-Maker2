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
        public static void insertQuestionAndAnswers (string question, string answer)
        {
            questionAndAnswers[] questionAndAnswerList= new questionAndAnswers[] {};
            XmlSerializer writer = new XmlSerializer(typeof(List<questionAndAnswers>));
            var path = @"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro";
            using (FileStream file = File.Create(path));
            {
                questionAndAnswerList= serializer.deserializer(file, questionAndAnswers);
            }
            var questionAndAnswers =Console.ReadLine();
            Console.WriteLine("Write the question separated by|, the right must be followed by*");
                                }
        /// <summary>
        /// This method should show a random question picked from the questionAndAnswers list
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static  showRandomQuestion (questionAndAnswersList)
        {
            var rand = new Random();
            var bytes = new byte[5];
            rand.NextBytes(bytes);
            

        }
    }
}
