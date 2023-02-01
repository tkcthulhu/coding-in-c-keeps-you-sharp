using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResettable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

    public void Display()
    {
      int itemNum = 1;
      foreach (string item in Todos)
      {
        Console.WriteLine($"{itemNum}. {item}");
        itemNum++;
      }
    }

    public void Remove(int index)
    {
      index = index-1;
      string[] newTodos = new string[5];
      int count = 0;
      for (int i = 0; i < 5; i++)
      {
        if (i == index )
        {
          i++;
          continue;
        }
        newTodos[count] = Todos[i];
        count++;
      }
      Todos = newTodos;
      nextOpenIndex--;
    }

    public void Reset()
    {
      Todos = new string[5];
    }
  }
}
