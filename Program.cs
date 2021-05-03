using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] magicBallResponses =
            {
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes – definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy, try again.",
                "Ask again later",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."
            };

            bool isRunning = true;
            Random ran = new Random();
            string botName = "MagicBot";
            string UserName = "Anonymous";
            chat(botName, "What is Your Name?\n");
            chat("You", "");
            UserName = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(UserName)) UserName = "Anonymous";


            Console.Clear();
            

            int maxLength = botName.Length > UserName.Length ? botName.Length + 2 : UserName.Length + 2;
            SetMaxLength(maxLength);

            chat("SERVER", "Welcome, " + UserName + "! Ask " + botName + " any question! \n");

            while (isRunning)
            {
                chat(botName, "What do you want to know?\n");
                chat(UserName, "");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string question = Console.ReadLine().Trim();

                bool isEmpty = string.IsNullOrEmpty(question);
                string answer = "";
                if (!isEmpty)
                {

                    chat(botName, "Thinking ...");
                    Thread.Sleep(ran.Next(500));
                    Console.Write("\n");


                    
                    answer = magicBallResponses.ElementAt(ran.Next(magicBallResponses.Length));
                } else

                {
                    answer = "You didn't ask any question!";
                }

                chat(botName, answer + "\n");
                


                // Console.Write("===================\nAsk Again?");
                // Console.Read();
            }

           
            
        }

        static int _maxLength = 10;
        static void SetMaxLength(int length)
        {
            _maxLength = length;
        }
        
        static void chat(string name, string msg)
        {
            Thread.Sleep(5);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(5);
            Console.Write("[");
            Thread.Sleep(5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(5);
            Console.Write(name);
            Thread.Sleep(5);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(5);
            Console.Write("]");
            Thread.Sleep(5);
            Console.Write(" ".PadLeft(_maxLength - name.Length) + ": ");
            Thread.Sleep(5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            for(int i = 0; i < msg.Length; i++)
            {
                Thread.Sleep(30);
                Console.Write(msg[i]);
            }
            Thread.Sleep(5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(5);
        }
    }
}
