using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        // initializing a list for the goals to be stored and looped;
        List<Goals> goal = new List<Goals>();
        //
        List<string> saved = new List<string>();
        List<string> read = new List<string>();
        List<int> totalPoint = new List<int>();

        //Initialized the total amount.
        int total = 0;
        //initializing the total points
        int gainedPoints = 0;
        // Console.WriteLine("Hello Develop05 World!")
        



        //The question to be run for every question.
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

        static string[] checkListQues()
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus");
            string bonusTime = Console.ReadLine();
            Console.WriteLine("What is the bonus for accomplishing it that many");
            string accomplishBonus = Console.ReadLine();
            return new string[]{
                bonusTime,
                accomplishBonus
            };
        }


        while (true)
        {
            //This is the question function that will run when app starts.
            string quest()
            {
                Console.WriteLine($"You have {gainedPoints} points.");
                Console.WriteLine();
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
            answer = quest();

            if (int.Parse(answer) == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("    1. Simple Goal");
                Console.WriteLine("    2. Eternal Goal");
                Console.WriteLine("    1. Checklist Goal");
                Console.WriteLine("which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                //calling the goal entry function for the goal question and answer prompt;
                // storing the list returned values to be used as parameters inside the new goal instances


                //if 1 is entered
                if (int.Parse(goalType) == 1)
                {
                    var goals = goalEntry();
                    string name = goals[0];
                    string desc = goals[1];
                    string points = goals[2];
                    //If the goal type is simple
                    //Add the goal to a list for it to be saved outside the program.
                    goal.Add(new Simple(desc, name, int.Parse(points)));
                    //Save it locally to the program and will be shown at the program runtime
                    saved.Add($"SimpleGoal, {name}, ({desc}),{points}");
                }
                else if (int.Parse(goalType) == 2)
                {
                    var goals = goalEntry();
                    string name = goals[0];
                    string desc = goals[1];
                    string points = goals[2];
                    //If the goal type is Eternal
                    //Add the goal to a list for it to be saved outside the program.
                    goal.Add(new Eternal(desc, name, int.Parse(points)));
                    //Save it locally to the program and will be shown at the program runtime
                    saved.Add($"EternalGoal, {name}, ({desc}),{points}");
                }
                else if (int.Parse(goalType) == 3)
                {
                    var goals = goalEntry();
                    string name = goals[0];
                    string desc = goals[1];
                    string points = goals[2];
                    //If the goal type is Checklist
                    //The special question list for a checklist question.
                    var chkLst = checkListQues();
                    string bonusTime = chkLst[0];
                    string accomplishBonus = chkLst[1];
                    //Add the goal to a list for it to be saved outside the program.
                    goal.Add(new Checklist(desc, name, int.Parse(points), int.Parse(bonusTime), int.Parse(accomplishBonus)));
                    //Save it locally to the program and will be shown at the program runtime
                    saved.Add($"CheckListGoal, {name},:({desc}),{points},{accomplishBonus},0/{bonusTime}");
                }
            }

            //if 2 is entered
            else if (int.Parse(answer) == 2)
            {
                if (goal.Count > 0)
                {//to add an index number in front of each goal stored
                    int i = 0;
                    string uncheck = "[ ]";
                    foreach (Goals g in goal)
                    {
                        string n = g.getName();
                        string d = g.getDesc();
                        string p = g.getPoints();
                        int cT = g.getCompletedTime();
                        if (n == "SimpleGoal" || n == "EternalGoal")
                        {
                            //Show the goal in the console as unchecked
                            Console.WriteLine($"{i += 1}. {uncheck} {n}:({d})");
                        }
                        else
                        {
                            //Show the goal in the console as unchecked
                            Console.WriteLine($"{i += 1}. {uncheck} {n}:({d})--currently completed: {i}/{cT}");
                        }

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

            //If 3 is entered
            else if (int.Parse(answer) == 3)
            {
                Console.WriteLine("Enter file name");
                string _fileName = Console.ReadLine();
                //the file extension is programmed already user just need to enter the name, this can be considerd as a simple creativity
                using (StreamWriter outputFile = new StreamWriter($"{_fileName}.txt"))
                {
                    foreach (var g in saved)
                    {
                        outputFile.WriteLine(g);
                    }
                }
            }
            else if (int.Parse(answer) == 4)
            {
                Console.WriteLine("Enter file name");
                string _fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines($"{_fileName}.txt");
                // looping through the contents of the file and printig it to the console.
                foreach (string line in lines)
                {

                    string[] substring = line.Split(",");
                    string title = substring[0];
                    string desc = substring[1];
                    string points = substring[2];

                    Console.WriteLine(title);
                    Console.WriteLine(desc);
                    Console.WriteLine(points);
                }

                foreach (int item in totalPoint)
                {
                    // Console.Clear();
                    Console.Write("\b \b");
                    Console.WriteLine(total += item);
                }

            }
            else if (int.Parse(answer) == 5)
            {
                int i = 0;
                string check = "[√]";
                Console.WriteLine("The goals are:");
                string[] lines = System.IO.File.ReadAllLines("goals1.txt");
                // looping through the contents of the file and printig it to the console.

                
                foreach (string line in lines)
                {
                    string[] substring = line.Split(",");
                    string title = substring[0];
                    string desc = substring[1];
                    string points = substring[2];
                    //Printing the goals in the list to the console.
                    Console.WriteLine($"{i+=1}. {desc}");
                    // string ans = Console.ReadLine();
                    // if(int.Parse(ans) == i){
                    //     Console.WriteLine($"Congratulations! you have earned {points} points");
                    //     Console.WriteLine($" You now have {points} points");
                    //     gainedPoints=int.Parse(points);
                    //     Console.WriteLine();
                    // }
                }
                

            }
        }
    }
}
