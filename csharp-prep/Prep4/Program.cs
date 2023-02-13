using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Person p = new Person();
        // Console.WriteLine();
        p.SetNames("Mr","David","Omotoso");
        string names = p.GetFormalSignature();
        Console.WriteLine(names);
    }

    public class Person{
        private string _title;
        private String _firstName;
        private string _lastName;

        public string GetInformationSignature(){
            return "Thanks,  " + _firstName;
        }
        public string GetFormalSignature(){
            return "Sincerely " + GetFullName(); 
        }

        private string GetFullName(){
            return _title + " "+ _firstName+ " "+ _lastName;
        }
        public void SetNames(string title, string first, string last){
            _title = title;
            _firstName = first;
            _lastName = last;
        }
    }
}