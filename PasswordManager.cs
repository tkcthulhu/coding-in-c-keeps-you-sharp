using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResettable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public bool PasswordCheck(string password)
    {
      if (password == Password)
      {
        return true;
      } else {
        return false;
      }
    }

    public void Display()
    {
      if (Hidden)
      {
        int length = Password.Length;

        string[] hashed = new string[length];

        int i = 0;

        foreach (string x in hashed)
        {
          hashed[i] = "*";
          i++;
        }

        Console.WriteLine(string.Join("", hashed));
      } else {
        Console.WriteLine(Password);
      }
    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }

    public void ChangePassword()
    {
      Console.WriteLine("Please enter your old password (The default is 'guest')");
      string oldPassword = Console.ReadLine();
      if (oldPassword == Password) 
      {
        Console.WriteLine("Please enter your new password");
        string newPassword = Console.ReadLine();
        Password = newPassword;
        Hidden = true;
        Console.WriteLine("Your password has been successfully changed!");
      }
    }

  }
}
