using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating different types of employees
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());

        // getting a custom calculation for each employee;
        foreach (Employee employee in employees)
        {
                float pay = employee.calculatePay();
                Console.WriteLine(pay);
        }
    }

    public class Employee{

       private float salary = 100f;

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