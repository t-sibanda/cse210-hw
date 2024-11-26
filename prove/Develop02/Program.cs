using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Journal journal = new Journal();

            while (true)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = journal.GetPrompt();
                        string response = journal.GetResponse(prompt);
                        journal.SaveEntry(prompt, response);
                        break;
                    case "2":
                        journal.Display();
                        break;
                    case "3":
                        Console.Write("Enter the filename to save the journal: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;
                    case "4":
                        Console.Write("Enter the filename to load the journal: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

    public class Journal
    {
        private List<Entry> entries = new List<Entry>();

        private static readonly string[] Prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What inspired me the most today?",
            "What is one thing I learned today?"
        };

        public void SaveEntry(string prompt, string response)
        {
            entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
        }

        public void Display()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("The journal is empty.");
                return;
            }

            foreach (var entry in entries)
            {
                Console.WriteLine("-----");
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
            }
        }

        public string GetPrompt()
        {
            Random random = new Random();
            return Prompts[random.Next(Prompts.Length)];
        }

        public string GetResponse(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\"");
                    }
                }
                Console.WriteLine("Journal saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal: {ex.Message}");
            }
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                        entries.Add(new Entry
                        {
                            Date = parts[0].Trim('"'),
                            Prompt = parts[1],
                            Response = parts[2].Trim('"')
                        });
                    }
                }
                Console.WriteLine("Journal loaded successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }
        }
    }

    public class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }
    }
}
