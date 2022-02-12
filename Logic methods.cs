using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int i= 0;
            while (i<5)
            {
                string question = "";
                string answer = "";
                UIMethods.insertQuestionAndAnswers(question,answer);
            }
        }
        
    }
    }

