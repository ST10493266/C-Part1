using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    internal class VoiceGreeting
    {
        public static void PlayGreetingSound()
        {
            try
            {
                // The name format is "YourProjectName.FileName.wav"
                string soundName = "CybersecurityAwarenessBot.New Recording 4.wav";
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(soundName);

                if (stream != null)
                {
                    SoundPlayer player = new SoundPlayer(stream);
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }
        }
    }
}
