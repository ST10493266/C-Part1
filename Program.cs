using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Play embedded WAV sound (Method 1 - uses your embedded file)
            PlayEmbeddedSound();

            // Alternative: Play from file path (Method 2 - uncomment if you have the file)
            // PlaySoundFromFile();

            // Get and validate user name
            string userName = GreetingManager.GetUserName();

            // Play voice greeting and show banner
            GreetingManager.PlayVoiceGreeting($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot.");
            GreetingManager.DisplayWelcomeBanner(userName);

            // Start the chat loop
            ChatBot bot = new ChatBot(userName);
            bot.Start();
        }

        // Method to play embedded WAV sound
        static void PlayEmbeddedSound()
        {
            try
            {
                // Make sure this matches your project name and filename
                string soundName = "CybersecurityAwarenessBot.New Recording 4.wav";
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(soundName);

                if (stream != null)
                {
                    SoundPlayer player = new SoundPlayer(stream);
                    player.Play();  // Plays asynchronously
                    Console.WriteLine("Sound playing...");
                }
                else
                {
                    Console.WriteLine("Sound file not found as embedded resource.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not play sound: {ex.Message}");
            }
        }

        // Alternative method to play from file path
        static void PlaySoundFromFile()
        {
            try
            {
                // Update this path to where your sound file actually is
                string soundPath = @"C:\Users\Student\source\repos\CybersecurityAwarenessBot\sound.wav";

                if (File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.Play();
                }
                else
                {
                    Console.WriteLine("Sound file not found at: " + soundPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not play sound: {ex.Message}");
            }
        }
    }
}
