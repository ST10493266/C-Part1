using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    internal class Logo
    {
        class Display
        {
            // ── Colours ──────────────────────────────────────────────────────────
            private static void C(ConsoleColor fg) => Console.ForegroundColor = fg;
            private static void R() => Console.ResetColor();

            //  ASCII Logo ────────────────────────────────────────────
            // ── Question 2: ASCII Logo ────────────────────────────────────────────
            public static void ShowLogo()
            {
                Console.Clear();
                C(ConsoleColor.Cyan);
                Console.WriteLine(@"
  ╔══════════════════════════════════════════════════════════════════════════════╗
  ║                                                                              ║
  ║     ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗   ║
  ║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝   ║
  ║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║      ║
  ║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║      ║
  ║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║      ║
  ║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═╝      ║
  ║                                                                              ║
  ║                               ╔══════════════╗                              ║
  ║                               ║  CYBER BOT   ║                              ║
  ║                               ╚══════════════╝                              ║
  ║                                                                              ║
  ║            Cybersecurity Awareness Bot  v1.0                                 ║
  ║                  Keeping You Safe Online                                     ║
  ╚══════════════════════════════════════════════════════════════════════════════╝
");
                R();
                Thread.Sleep(800);
            }
        }
    }
}
