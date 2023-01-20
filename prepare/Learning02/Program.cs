using System;

class Program
{

    // This is where the code is called so that it can run inside the terminal//
    static void Main(string[] args)
    {
        Console.WriteLine("Working");


    Person person = new Person();
    person._givenName = "David";
    person._familyName = "Omotoso";
    person.ShowWesternName();
    person.ShowEasternName();
    Person person1 = new Person();
    person1._givenName = "Bayode";
    person1._familyName = "Akolade";
    person1.ShowEasternName();
    person1.ShowWesternName();


    // Instances of Job
    Job job1 = new Job("Tamopei","Senior Front End Developer",2022,2024);
    job1.DisplayJob();
    job1._jobTitle="Software Engineer";

    Job job2 = new Job("LightmanBro", "Director", 2013,2023);

    // Instances of Resume
    Resume myResume = new Resume();
    myResume._name = "David";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);
    }

}

public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "";
        public string _familyName = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }
// Another way of Declaring the class constructor

/*public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName;
        public string _familyName;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.

        // this can be called this way
        Person person2 = new Person("givenName", "Family name")
        public Person(string _givenName,string _familyName)
        {
            this._givenName = _givenName;
            this._familyName = _familyName;
        }
        


        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }*/
