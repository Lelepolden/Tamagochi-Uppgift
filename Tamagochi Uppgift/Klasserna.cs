using System;
using System.Collections.Generic;

public class Tamagotchi
{
  private int hunger;
  private int boredom;
  private List<string> words = new List<string>() {"Hello"};
  private bool isAlive;
  public string name;

  public Tamagotchi()
  {
    isAlive = true;
  }

  public void Feed()
  {
    Console.WriteLine($" [{name}] eats and isn't as hungry anymore");
    hunger -= 2;
    if (hunger < 0)
    {
      hunger = 0;
    }
  }
}
