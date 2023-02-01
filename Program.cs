using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();

      PasswordManager pm = new PasswordManager("guest", true);

      Console.WriteLine("Welcome to your To Do list!");
      Console.WriteLine("Please enter your password to continue:");
      string password = Console.ReadLine();
      bool validPassword = pm.PasswordCheck(password);
      while (!validPassword)
      {
        Console.WriteLine("Password is incorrect, please try again (default is 'guest')");
        password = Console.ReadLine();
        validPassword = pm.PasswordCheck(password);
      }
      int run = 0;
      while (run<1)  {
          Console.WriteLine("What would you like to do?");
          Console.WriteLine("[1] Add item to list [2] View current To Do list [3] Remove an item [4] Clear list [5] Change your password");
          Console.WriteLine("Please respond with 1-5");

          string userInput = Console.ReadLine();

          switch(userInput)
          {
            case "1":
              Console.WriteLine("What would you like to add?");
              string newItem = Console.ReadLine();
              tdl.Add(newItem);
              Console.WriteLine("Excellent! You current list is:");
              tdl.Display();
              break;
            case "2":
              tdl.Display();
              break;
            case "3":
              tdl.Display();
              Console.WriteLine("Which item would you like to remove?");
              Console.WriteLine("Please enter a number 1-5");
              string input = Console.ReadLine();
              int index;
              bool validItem = Int32.TryParse(input, out index);
              tdl.Remove(index);        
              tdl.Display();  
              break;
            case "4":
              tdl.Reset();
              Console.WriteLine("Your list has been successfully cleared");
              break;
            case "5":
              pm.ChangePassword();
              break;
          }
          Console.WriteLine("Would you like to do something else? y/n");
          string answer = Console.ReadLine();
          if (answer == "n" ) {
            run++;
          }
        }
    }
  }
}
