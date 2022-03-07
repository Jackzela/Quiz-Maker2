using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker2
{
    public class QuestionAndAnswers
    {
        public string question;
        public List<string> answer = new List<string>();
        public int numberRightAnswer;

        public void Test()
        {
            Console.WriteLine("correct number " + numberRightAnswer);
        }
    }

    internal class Classes
    {
    }
}
