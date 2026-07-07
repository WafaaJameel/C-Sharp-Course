using System; // 🚀 Importing the System namespace so we can use Console and other core features

// 🎯 Step 1: Define an interface called IQuittable
// Interfaces are like contracts: any class that signs this contract must implement its methods.
public interface IQuittable
{
    void Quit(); // 📜 The contract says: "You must provide a Quit() method!"
}

// 👔 Step 2: Create an Employee class that inherits from IQuittable
// This means Employee promises to implement the Quit() method defined in the interface.
public class Employee : IQuittable
{
    public string Name { get; set; } // 🏷️ A property to hold the employee's name

    // 🛠️ Step 3: Implement the Quit() method from IQuittable
    // Here we decide what "Quit" means for an Employee.
    public void Quit()
    {
        // 🎤 Our custom implementation: print a dramatic resignation message
        Console.WriteLine($"{Name} has decided to quit the company. 🎉 Time for new adventures!");
    }
}

// 🖥️ Step 4: Build the Console App entry point
class Program
{
    static void Main(string[] args)
    {
        // 🧑‍💻 Create an Employee object and give it a name
        Employee employee = new Employee() { Name = "WafaaJameel" };

        // 🔄 Step 5: Use polymorphism
        // Even though 'employee' is an Employee, we can treat it as an IQuittable because Employee implements IQuittable.
        IQuittable quittableEmployee = employee;

        // 🎬 Step 6: Call the Quit() method on the interface type
        // Polymorphism in action: the interface reference calls the Employee's implementation of Quit().
        quittableEmployee.Quit();

        // 🏁 Keep console open until user presses a key
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
