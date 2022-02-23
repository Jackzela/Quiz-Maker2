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
        public static void ShowTheQuestionAndAnswers(QuestionAndAnswers questionToShow)
        {
            Console.WriteLine($"{questionToShow.question}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{questionToShow.answer[i]}");
            }

        }
        public bool askTheAnswer (QuestionAndAnswers rightAnswer,int userAnswer)
        {
            
            Console.WriteLine("Choose the answer");
            string theAnswerString = Console.ReadLine();
            userAnswer = int.Parse(theAnswerString);
            if (userAnswer == QuestionAndAnswers.numberRightAnswer)
            {
                Console.WriteLine("You win!");
            }
            return 
        }
        
        /// <summary>
        /// This method take the question and answers from the user and ask to him wich is the right one
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
        public static QuestionAndAnswers InsertQuestionAndAnswers()
        {
            var q =new QuestionAndAnswers();
            Console.WriteLine("Write the question!");
            q.question = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"answer n.{i}");
                string answers = Console.ReadLine();
                q.answer.Add(answers);
            }
            Console.WriteLine("Wich is the right one?");
            string rightonestring = Console.ReadLine();
            int rightone = int.Parse(rightonestring);
            q.numberRightAnswer = rightone;
            return q;
        }
    }

}
