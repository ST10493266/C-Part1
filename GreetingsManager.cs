using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;  
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace CybersecurityAwarenessBot
{
    public class GreetingManager  // Changed from internal to public, removed nested class
    {
        // Ask for user name and validate it (links to Task 5 - InputValidator)
        public static string GetUserName()
        {
            Console.Title = "CyberSecurity Awareness Bot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            PlayVoiceGreeting("Welcome to the Cybersecurity Awareness Bot. Please enter your name.");

            Console.Write("\n  Enter your name: ");
            Console.ForegroundColor = ConsoleColor.White;

            string input = Console.ReadLine();

            // Validate name using InputValidator
            while (!InputValidator.IsValidInput(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  " + InputValidator.DefaultResponse());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  Enter your name: ");
                input = Console.ReadLine();
            }

            return input.Trim();
        }

        // Play voice greeting using Speech Synthesis
        public static void PlayVoiceGreeting(string message)
        {
            try
            {
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    synth.Volume = 100;
                    synth.Rate = 0;
                    synth.Speak(message);
                }
            }
            catch
            {
                // Voice not available on this system — silently skip
            }
        }

        // Display ASCII art / decorative welcome banner

        // Display ASCII art / decorative welcome banner
        public static void DisplayWelcomeBanner(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("  ╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("  ║         CYBERSECURITY AWARENESS BOT                   ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════════════╣");
            Console.WriteLine($"  ║   Welcome, {userName,-42}║");
            Console.WriteLine("  ║   Your trusted guide to staying safe online.        ║");
            Console.WriteLine("  ╚══════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Type 'help' to see what I can assist you with.");
            Console.WriteLine("  Type 'exit' to quit.");
            Console.WriteLine();
            Console.ResetColor();
        }

        }

    }
    


