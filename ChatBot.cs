using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    public class ChatBot  // Changed from internal to public, removed duplicate
    {
        private string userName;
        private ResponseEngine responseEngine;

        public ChatBot(string userName)
        {
            this.userName = userName;
            this.responseEngine = new ResponseEngine(userName);
        }

        public void Start()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"  {userName}: ");
                Console.ForegroundColor = ConsoleColor.White;

                string userInput = Console.ReadLine();

                // TASK 5: Validate input
                if (!InputValidator.IsValidInput(userInput))
                {
                    PrintBotResponse(InputValidator.DefaultResponse(userName));
                    continue;
                }

                string query = userInput.Trim().ToLower();

                // Exit condition
                if (query == "exit" || query == "quit" || query == "bye")
                {
                    GreetingManager.PlayVoiceGreeting($"Goodbye {userName}! Stay safe online.");
                    PrintBotResponse($"Goodbye, {userName}! Stay cyber-safe! ");
                    break;
                }

                // TASK 4: Get response from ResponseEngine
                string response = responseEngine.GetResponse(query);

                // TASK 5: Fallback if response is null (unsupported query)
                if (response == null)
                    response = InputValidator.DefaultResponse(userName);

                PrintBotResponse(response);
            }
        }

        private void PrintBotResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  CyberBot: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
