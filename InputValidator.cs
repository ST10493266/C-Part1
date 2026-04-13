using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    public class InputValidator  // Changed from InputInvalidator to InputValidator
    {
        // Check if input is valid (not null, empty, or whitespace)
        public static bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Default fallback response for invalid or unsupported input
        public static string DefaultResponse(string userName = "")
        {
            if (!string.IsNullOrEmpty(userName))
                return $"I didn't quite understand that, {userName}. Could you rephrase?\n" +
                       "  Try asking about: password safety, phishing, safe browsing, or type 'help'.";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}
