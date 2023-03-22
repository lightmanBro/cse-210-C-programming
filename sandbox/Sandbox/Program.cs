using System;
class Program
{
    static void Main(string[] args)
    {
        // Creating different types of employees
        // List<Employee> employees = new List<Employee>();
        // employees.Add(new Employee());
        // employees.Add(new HourlyEmployee());

        // // getting a custom calculation for each employee;
        // foreach (Employee employee in employees)
        // {
        //         float pay = employee.calculatePay();
        //         Console.WriteLine(pay);
        // }
        Employee employee = new Employee();
        
        
    //     Console.WriteLine("Enter file name");
    //     string _fileName = Console.ReadLine();
    //     // to add a file as a json file then the AddRange() should be used.
    //     _entryTitle.Add(_fileName);

    //     using (StreamWriter outputFile = new StreamWriter($"{_fileName}.txt"))
    //     {
    //         foreach (var _item in _userDetails)
    //         {
    //             outputFile.WriteLine($"[{_item}],");
            

    //         }
    //         // You can add text to the file with the WriteLine method
    //     }

    // }"
    }

    public class Employee{

       private float salary {get;set;}


       public virtual float calculatePay(){
            return salary;
       }     
    }

    public class HourlyEmployee :Employee{

        private float rate = 9f;
        private float hours = 100f;


        //Method overriding
        public override float calculatePay(){

            return rate * hours;
        }
    }

    // Shape Practice
}