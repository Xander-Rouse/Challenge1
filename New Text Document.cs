using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	Random rand = new Random();
        
		    int CurrentRoll = rand.Next(6);
        CurrentRoll = CurrentRoll + 1;
        string History = CurrentRoll.ToString();
        int RollCount = 1;
        int RollTotal = CurrentRoll;
        int AvgRoll = RollTotal/RollCount;
        System.Console.WriteLine($"{CurrentRoll} was rolled. Would you like to roll again? (Y/N)");

        while (RollCount < 999999) {
        string Response = Console.ReadLine();
        if (Response == "Y")  {
	        CurrentRoll = rand.Next(6);
    	    CurrentRoll = CurrentRoll + 1;
          History = History + " " + CurrentRoll.ToString();
        	RollCount = RollCount + 1;
        	RollTotal =  RollTotal + CurrentRoll;
        	AvgRoll = RollTotal/RollCount;
        	System.Console.WriteLine($"{CurrentRoll} was rolled. A total of {RollTotal} has been rolled, with an average of {AvgRoll}. Your rolls were {History}. Would you like to roll again? (Y/N)");
        }
        else if (Response == "N")  {
          System.Console.WriteLine("How many rolls would you like to view? (From last roll)");
          int TakeOut = int.Parse(Console.ReadLine());
          Console.WriteLine("Your rolls were:");
          int Recount = RollCount * 2 - 2;
          char CharTotal = (char) 7;
          string StrTotal = "a";
          int FinalTotal = 0;
          while (TakeOut > 0) { 
            Console.Write(History[Recount] + " ");
            TakeOut = TakeOut - 1;
            Recount = Recount - 2;
            CharTotal = History[Recount];
            StrTotal = CharTotal.ToString();
            FinalTotal = FinalTotal + int.Parse(StrTotal);
            if (Recount == 0) 
            {
              Console.WriteLine("Not enough rolls");
              break;
            }
          }
          Console.WriteLine($"A total of {FinalTotal} was been rolled, with an average of {AvgRoll}.");
          break;
        }
        else {
          System.Console.WriteLine("Invalid response"); 
        }
        }  
    }
  }
}
