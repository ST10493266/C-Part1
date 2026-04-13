# C-Part1
ass1
# Cybersecurity Awareness Bot — PROG6221 POE Part 1

A C# console chatbot that educates users on cybersecurity best practices.

## Features
- Voice greeting on startup (WAV playback via System.Media)
-  ASCII art logo displayed as title screen
-  Personalised greeting using user's name
-  Cybersecurity Q&A: passwords, phishing, browsing, malware, privacy, 2FA, VPN
-  Input validation with helpful fallback messages
-  Coloured console UI with typing effect and section dividers
-  Looping conversation until user exits

## How to Run

```bash
cd CybersecurityBot
dotnet run
```

## Voice Greeting Setup
Record a short WAV file (e.g. "Hello! Welcome to the Cybersecurity Awareness Bot."),
save it as `greeting.wav`, and place it in the same folder as the compiled executable.

## Project Structure

```
CybersecurityBot/
├── Program.cs          # Entry point
├── AudioGreeting.cs    # Question 1 – voice greeting
├── Display.cs          # Questions 2, 3, 6 – ASCII logo, UI, typing effect
├── ResponseEngine.cs   # Questions 4, 5 – responses & input validation
├── ChatBot.cs          # Questions 3, 4 – conversation loop
└── .github
```
