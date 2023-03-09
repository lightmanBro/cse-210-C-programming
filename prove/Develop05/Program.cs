using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // initializing a list for the goals to be stored and looped;
        List<Goals> goal = new List<Goals>();
        List<string> saved = new List<string>();

        string quest()
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Events");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string ans = Console.ReadLine();
            return ans;
        }

        string answer;
        while (true)
        {

            answer = quest();
            if (int.Parse(answer) == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("    1. Simple Goal");
                Console.WriteLine("    2. Eternal Goal");
                Console.WriteLine("    1. Checklist Goal");
                Console.WriteLine("which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                // Creating a function for the goal entry.
                static string[] goalEntry()
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("What is a short description for your goal? ");
                    string goalDesc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();

                    // Returning lists of string values from the functions
                    return new string[]{
                  goalName,
                  goalDesc,
                  goalPoints
                };
                }
                if (int.Parse(goalType) == 1)
                {
                    // storing the list returned values to be used as parameters inside the new goal instances
                    var goals = goalEntry();
                    string name = goals[0];
                    string desc = goals[1];
                    string points = goals[2];
                    Simple simpleGoal = new Simple(desc, name, int.Parse(points));
                    goal.Add(simpleGoal);
                    saved.Add($"SimpleGoal {name} ({desc}){points}");
                }
                else if (int.Parse(goalType) == 2)
                {
                    var goals = goalEntry();
                    string name = goals[0];
                    string desc = goals[1];
                    string points = goals[2];
                    Eternal eternal = new Eternal(desc, name, int.Parse(points));
                    goal.Add(eternal);
                    saved.Add($"EternalGoal {name} ({desc}){points}");
                }
                else if (int.Parse(goalType) == 3)
                {
                    var goals = goalEntry();
                    string name = goals[0];
                    string desc = goals[1];
                    string points = goals[2];
                    Checklist checklist = new Checklist(desc, name, int.Parse(points));
                    goal.Add(checklist);
                    saved.Add($"{name}:({desc}){points}");
                }
            }
            else if (int.Parse(answer) == 2)
            {
                if (goal.Count > 0)
                {
                    int i = 0;
                    string uncheck = "[ ]";
                    string chkd = "[X]";
                    foreach (Goals g in goal)
                    {
                        string n = g.getName();
                        string d = g.getDesc();
                        string p = g.getPoints();
                        Console.WriteLine($"{i += 1}. {uncheck} {n}:({d})");
                        
                    }
                    foreach (string item in saved)
                    {
                        Console.WriteLine($" from saved {item}");
                    }
                }
                else
                {
                    Console.WriteLine("List is empty");
                }

            }
            else if (int.Parse(answer) == 3)
            {
                Console.WriteLine("Enter file name");
                string _fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter($"{_fileName}.txt"))
                {
                    foreach (var g in saved)
                    {
                        outputFile.WriteLine(g);
                    }
                    // You can add text to the file with the WriteLine method
                }
            }
            else if (int.Parse(answer) == 4)
            {

                string[] lines = System.IO.File.ReadAllLines("fileOne.txt");
                // looping through the contents of the file and printig it to the console.
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0].Split();
                    // string lastName = parts[1];
                    Console.WriteLine(firstName);
                    // Console.WriteLine(lastName);
                }
            }
        }
    }
}