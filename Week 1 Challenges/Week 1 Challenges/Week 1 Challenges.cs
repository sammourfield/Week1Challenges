using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Week1Challenges()
        {
            string firstAndLastName = "Sam Mourfield";
            int age = 26;
            int plusSeven = 7;
            string[] moveTitles = { "1 blow", "2 Dark Knight", "3 Whiplash", "4 The Town" };

            DateTime rightNow = DateTime.Now;
            DateTime today = DateTime.Today;

            int agePlusSeven = age + plusSeven;
            Console.WriteLine(agePlusSeven);

            int sleepTime = 12;
            if (sleepTime <= 10)
            {
                Console.WriteLine("You're getting a good night's sleep");

            }
            else if (sleepTime <= 5)
            {
                Console.WriteLine("You could use more sleep.");
            }
            else 
            {
                Console.WriteLine("You are sleeping too much!!");
            }

        }
        [TestMethod]
      public void SwitchCase()
       {
            string howWasYourDay = "Bad";

            switch (howWasYourDay)
            {
                case "great":
                    Console.WriteLine("What a Fantastic Day!");
                    break;
                case "good":
                    Console.WriteLine("It's a fairly SOLID day!");
                    break;
                case "Okay":
                    Console.WriteLine("This day is ok but could be better.");
                    break;
                case "Bad":
                    Console.WriteLine("What a crummy day lad!");
                    break;



            }
        }
        

       
    }
}
