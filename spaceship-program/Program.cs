using System;

namespace Course {

    class Program {
        
        static void Main(string[] args) {
            System.Console.WriteLine("   . * .        .            o .        o  .    o       .     ' ");    
            System.Console.WriteLine("            '            .                  .             . ");
            System.Console.WriteLine("     .                         *.              .            ' ");
            System.Console.WriteLine("         *                .-                     ~       .              '");
            System.Console.WriteLine("              .                      '         o                    *");  
            System.Console.WriteLine("                                     *.          '               *");
            System.Console.WriteLine("──────────────────START THE SHIP──────────────────▷ ┼ ┼");
            System.Console.WriteLine("Choose your path, commander :(1) Engage the warp drive and commence the mission [Enter] \n(2) Eject from the ship and abandon the mission [Esc]\n──────────────────");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            System.Console.WriteLine();


            if (keyInfo.Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Starting Basic Routines SpaceShip *Imorra IV*");
                System.Console.WriteLine();
                System.Console.WriteLine("Greetings from the stars, Commander. Engines primed and ready for departure."); 

                } else if (keyInfo.Key == ConsoleKey.Escape) {
                    System.Console.WriteLine("Ejected");
                    Environment.Exit(0);

               } 

            System.Console.WriteLine();
            System.Console.WriteLine("Temperature reading, Commander. Press enter to view the ship's thermal capabilities");

            int minTemperature;
            int maxTemperature;
            int idealTemperature;

            minTemperature = 10;
            maxTemperature = 30;
            idealTemperature = 20;

            Console.ReadLine();
            System.Console.WriteLine($"The ship's thermal capabilities include a minimum of {minTemperature}°C and a maximum of {maxTemperature}°C.");
            System.Console.WriteLine($"The ideal temperature it's {idealTemperature}°C");
            System.Console.WriteLine();
            System.Console.Write("What's the current temperature, Commander:");
            int currentTemperature = int.Parse(Console.ReadLine());
            System.Console.WriteLine();


            if (currentTemperature >= maxTemperature) {
                System.Console.WriteLine("MAXIMUM TEMPERATURE ALERT: Attention, crew! We're approaching the temperature danger zone. Emergency cooling measures must be taken immediately.");
            
            } else if (currentTemperature <= minTemperature) {
                System.Console.WriteLine("MINIMUM TEMPERATURE ALERT: WARNING! We're getting dangerously close to freezing temperatures. Initiate emergency heating procedures ASAP.");
            
            } else if (currentTemperature >= 25 || currentTemperature <= 15) {
                System.Console.WriteLine("WARNING: Temperature approaching critical threshold. Exercise caution.");
            
            } else {
                System.Console.WriteLine("Temperature on good levels.");
            
            }  
            System.Console.WriteLine();


            System.Console.Write("Commander, Hyperdrive speed check! Please report your current velocity in km/h:");
            int currentSpeed = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            
            if (currentSpeed <= 15000) {

                System.Console.WriteLine("You are travelling at a safe speed.");
            } else {
                System.Console.WriteLine("WARNING! Hyperdrive in overdrive. Excessive velocity detected. Adjust speed immediately.");
            }  

        }
    }
}