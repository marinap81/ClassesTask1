using System;
using System.Collections.Generic;

namespace Task1
{
                /*Task 1 - Create basic class for a Cookie
                Create class called Colour that represents a colour as a mix red, green and blue (rgb) values.  A colour should also have a name
                Include your Colour class inside the Cookie class*/

    public class Cookie
    { 
      public int weight;
      public string shape;
      public CookieColor myCookieColour;
      
      public void CookieSpecs()
      {          
       Console.WriteLine("This cookie weighs " + this.weight + " grams");
       Console.WriteLine("The shape is " + this.shape);
       Console.WriteLine("The colour name is " + this.myCookieColour.colourName + " RBG: (" + this.myCookieColour.red + "," + this.myCookieColour.green + "," + this.myCookieColour.blue + ")");
       Console.WriteLine("");
      }
    }

    public class CookieColor
    {
      // Colour Table : http://www.flounder.com/csharp_color_table.htm

      public string colourName; //sits in memory until its needed// STEP 3
      public int red;
      public int green;
      public int blue;

      public void AddColor(string param_colourName,int param_red,int param_green,int param_blue) //method 
      {
        this.colourName = param_colourName; //adds color chosen by user in the main class and saves it into the CookieColor class listed above
        this.red = param_red; //rgb value reference these values are shown in the colourName under CookieSpecs()
        this.green = param_green;
        this.blue = param_blue;
      }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Cookie Cookie1 = new Cookie();
          Cookie1.weight = 100;
          Cookie1.shape = "square";
         
          CookieColor cookieColour1 = new CookieColor();
          cookieColour1.AddColor("BlueViolet",138,43,226);
          

          Cookie1.myCookieColour = cookieColour1;
          Cookie1.CookieSpecs();

          Cookie Cookie2 = new Cookie(); //create cookie object//
          Cookie2.weight = 90;
          Cookie2.shape = "round";
          
          CookieColor cookieColour2 = new CookieColor(); //created color object step 1
          cookieColour2.AddColor("Red",255,0,0); //step 2
          Cookie2.myCookieColour = cookieColour2;
          Cookie2.CookieSpecs();


         
        }           
    }
}
