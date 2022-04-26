// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
  public static void Main(string[] args)
  {
    // This function states user's address input.
    int userValue;
    Random rnd = new Random();
    int randomNumber = rnd.Next(1,6);
    
    //Input
    Console.WriteLine("This program is a guessing game.");
    Console.WriteLine("");
    Console.Write("Enter a number from 1-6: ");
    userValue = Convert.ToInt32(Console.ReadLine());
    
    //Process
    if ( userValue == randomNumber ) {
      Console.WriteLine("Congratulations!");
    } 
    
    if ( userValue != randomNumber ) {
      Console.WriteLine("Oops! The number was " + randomNumber + ".");
    }
    
    Console.WriteLine("\nDone.");
  }
}