using System;
using System.Collections.Generic;



Console.WriteLine("Welcome to Tamagotchi!");

Tamagotchi myTama = new Tamagotchi();

Console.WriteLine("Please choose a name for your Tamagotchi!");
myTama.name = Console.ReadLine();

Console.WriteLine($"Great! {myTama.name} is a beautiful name!");

