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
            string path = @"C:\temp\test.xml";
            List<QuestionAndAnswers> qAList = new List<QuestionAndAnswers>();
            QuestionAndAnswers newQNA;
            for (int i = 0; i < 3; i++)
            {
                newQNA = UIMethods.InsertQuestionAndAnswers();
                qAList.Add(newQNA);
                Save(path, qAList);
            }

            var questions = Read(path);

            for (int i = 0; i < 3; i++)
            {
                UIMethods.ShowTheQuestionAndAnswers(qAList[i]);
                UIMethods.AskTheAnswer(qAList[i]);
            }
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
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                var mySerializer = new XmlSerializer(typeof(List<QuestionAndAnswers>));
                var questionAndAnswers = (List<QuestionAndAnswers>)mySerializer.Deserialize(file);// Calling the Deserialize method and cast to the object type.
                return questionAndAnswers;
            }
        }
    }
}

