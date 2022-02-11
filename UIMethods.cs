using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz_Maker2
{
    internal class UIMethods
    {
        public class questionAndAnswers
        {
            string question = "";
            string answer = "";
        }
        public static void insertQuestionAndAnswers (string question, string answer)
        {
            var questionAndAnswer = new questionAndAnswers();
            XmlSerializer writer = new XmlSerializer(typeof(List<>));
            question =Console.ReadLine();
            Console.WriteLine("Write the question separated by|, the right must be followed by*");
            answer = Console.ReadLine();  
        }
    }
}
