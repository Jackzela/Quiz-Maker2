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
        
        public static void insertQuestionAndAnswers (string question, string answer)
        {
            
            var questionAndAnswerList = new List<questionAndAnswers>();
            XmlSerializer writer = new XmlSerializer(typeof(List<questionAndAnswers>));
            var path = @"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro";
            using (FileStream file = File.Create(path));
            {
                questionAndAnswerList= serializer.deserializer(file, questionAndAnswers);
            }
            question =Console.ReadLine();
            Console.WriteLine("Write the question separated by|, the right must be followed by*");
            answer = Console.ReadLine();  
        }
        public static string showRandomQuestion (questionAndAnswers)
        {
            var rand = new Random();
            var bytes = new byte[5];
            rand.NextBytes(bytes);

        }
    }
}
