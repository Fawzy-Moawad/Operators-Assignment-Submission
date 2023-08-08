using System;

namespace EmployeeComparisonApp
{
    // Step 1: Create an Employee class
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Step 2: Overload the "==" operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                return true;
            }
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }
            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 3: Instantiate two Employee objects
            Employee employee1 = new Employee(1, "John", "Doe");
            Employee employee2 = new Employee(2, "Jane", "Smith");

            // Compare the two Employee objects using overloaded operators
            bool areEqual = employee1 == employee2;
            bool areNotEqual = employee1 != employee2;

            // Display the results
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");
            Console.WriteLine($"Are employee1 and employee2 not equal? {areNotEqual}");
        }
    }
}
