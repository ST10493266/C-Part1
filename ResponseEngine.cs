using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    internal class ResponseEngine
    {
        private string userName;

        public ResponseEngine(string userName)
        {
            this.userName = userName;
        }

        public string GetResponse(string input)
        {
            // Basic conversational responses
            if (input.Contains("how are you"))
                return $"I'm running at full capacity, {userName}! Ready to help you stay safe online. ";

            if (input.Contains("what's your purpose") || input.Contains("what is your purpose") || input.Contains("your purpose"))
                return $"My purpose is to educate you, {userName}, about cybersecurity threats and best practices — " +
                       "so you can browse, communicate, and work online with confidence!";

            if (input.Contains("what can i ask") || input.Contains("what can you do") || input.Contains("help"))
                return "You can ask me about:\n" +
                       "  • Password safety\n" +
                       "  • Phishing attacks\n" +
                       "  • Safe browsing\n" +
                       "  • How I'm doing\n" +
                       "  • My purpose\n" +
                       "  Type any of these topics to learn more!";

            // Cybersecurity topics
            if (input.Contains("password"))
                return " Password Safety Tips:\n" +
                       "  • Use at least 12 characters with letters, numbers & symbols.\n" +
                       "  • Never reuse passwords across different sites.\n" +
                       "  • Use a reputable password manager.\n" +
                       "  • Enable two-factor authentication (2FA) wherever possible.\n" +
                       "  • Never share your password — not even with IT support!";

            if (input.Contains("phishing"))
                return " Phishing Awareness:\n" +
                       "  • Phishing is when attackers impersonate trusted entities via email or messages.\n" +
                       "  • Look out for: urgent language, suspicious links, spelling errors.\n" +
                       "  • Always verify the sender's email address carefully.\n" +
                       "  • Never click unknown links — hover first to preview the URL.\n" +
                       "  • When in doubt, contact the supposed sender directly.";

            if (input.Contains("safe browsing") || input.Contains("browsing") || input.Contains("internet"))
                return " Safe Browsing Tips:\n" +
                       "  • Always look for HTTPS (padlock icon) before entering personal info.\n" +
                       "  • Avoid using public Wi-Fi for banking or sensitive tasks.\n" +
                       "  • Keep your browser and plugins up to date.\n" +
                       "  • Use a reputable antivirus/anti-malware tool.\n" +
                       "  • Don't download files from untrusted sources.";

            // Unrecognised input — handled by InputValidator default response
            return null;
        }
    }
}
