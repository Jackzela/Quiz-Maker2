using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz_Maker2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<QuestionAndAnswers> qAList = new List<QuestionAndAnswers>();
            QuestionAndAnswers newQNA;
            newQNA = UIMethods.InsertQuestionAndAnswers();
            qAList.Add(newQNA);

        }

        public static void Save(string path, List<QuestionAndAnswers> questionAndAnswersList)
        {
            XmlSerializer qnaSerializer = new XmlSerializer(typeof(List<QuestionAndAnswers>));

            FileStream file = File.Create(path);
            qnaSerializer.Serialize(file, questionAndAnswersList);
            file.Close();
        }
        private static List<QuestionAndAnswers> Read(string path)
        {
            var questionsList = new XmlSerializer(typeof(QuestionAndAnswers));//Creating the instance of the XmlSerialize with the object's type that will be Deserialized
            using (var file = new FileStream(@"C:\Users\Giacomo\OneDrive - Quid Servizi\Condivisa\Quid\Db-Pro\test.xml", FileMode.Open))
            {
                var mySerializer = new XmlSerializer(typeof(QuestionAndAnswers));
                var questionAndAnswers = (List<QuestionAndAnswers>)mySerializer.Deserialize(file);// Calling the Deserialize method and cast to the object type.
                return questionAndAnswers;
            }
            // Calling the Deserialize method and cast to the object type.


        }
    }
    }

