using System;
namespace LuckySpin.Models
{
    public class Spin
    {

        Random random = new Random();
        private int a,b,c,luck; //instance variables

        //TODO: Create public getter and setter for Luck, referencing the instance variable
        public int Luck
        {
            get { return luck; }
            set { luck=value; }
        }

        //TODO: Create public getters for Random numbers, refernencing their instance variable
        public Spin()
        {
            a = random.Next(10);
            b = random.Next(10);
            c = random.Next(10);
        }
        public int A {
            get
            {
                
                return a;
            }
        }
        public int B {
            get
            {
                
                return b;
            }
        }
        public int C
        {
            get
            {
                
                return c;
            }
        }

        //TODO: Create a public getter that makes the decision to display the image or not by returning "block" or "none" for the Razor templates CSS
        public string Display
        {
            get
            {
                if (a == Luck || b == Luck || c == Luck)
                {
                    return "block";
                }
                else
                {
                    return "none";
                }
                
            }
        }
    }
    
}
