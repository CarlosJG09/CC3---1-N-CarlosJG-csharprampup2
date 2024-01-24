using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());
        double weightInKilograms = weightInPounds * 0.453592;
        Console.WriteLine("Weight in pounds: " + weightInPounds + " lbs");
        Console.WriteLine("Converted to kilograms: " + weightInKilograms + " kg");

        Console.Write("\nEnter the distance in miles: ");
        double distanceInMiles = Convert.ToDouble(Console.ReadLine());
        double distanceInKilometers = distanceInMiles * 1.60934;
        Console.WriteLine("Distance in miles: " + distanceInMiles + " mi");
        Console.WriteLine("Converted to kilometers: " + distanceInKilometers + " km");

        Console.Write("\nEnter the temperature in Fahrenheit: ");
        double temperatureInFahrenheit = Convert.ToDouble(Console.ReadLine());
        double temperatureInCelsius = (temperatureInFahrenheit - 32) * 5 / 9;
        Console.WriteLine("Temperature in Fahrenheit: " + temperatureInFahrenheit + " °F");
        Console.WriteLine("Converted to Celsius: " + temperatureInCelsius + " °C");

        Console.WriteLine("\nEnter the ages of 10 students:");

        int totalAge = 0;
        int studentIndex = 1;

        while (studentIndex <= 10)
        {
            Console.Write("Student " + studentIndex + ": ");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            totalAge += studentAge;
            studentIndex++;
        }
        double averageAge = totalAge / 10.0;
        Console.WriteLine("\nAverage Age of Students: " + averageAge);

        string character1 = "Zilong";
        string character2 = "Tigreal";
        string character3 = "Nana";
        string character4 = "Miya";
        string character5 = "Fanny";

        string equipment1 = "Great Dragon Spear";
        string equipment2 = "Antique Cuirass";
        string equipment3 = "Lightning Truncheon";
        string equipment4 = "Scarlet Phantom";
        string equipment5 = "Blade of the Heptaseas";

        string item1 = "Wind Talker";
        string item2 = "Dominance Ice";
        string item3 = "Holy Crystal";
        string item4 = "Berserker's Fury";
        string item5 = "Bloodlust Axe";

        string ability1 = "Supreme Warrior";
        string ability2 = "Implosion";
        string ability3 = "Molina Blitz";
        string ability4 = "Hidden Moonlight";
        string ability5 = "Cut Throat";

        string story = "\nLong ago in the land of dawn there are four adventurers, has set to a journey to defeat the Demon King." +
            "\n" + character1 + ", their leader who has the ability of " + ability1 + " and the equipment and item, " + equipment1 + " and " + item1 + "." +
            "\n" + character2 + ", the tank he has the ability " + ability2 + " and has the equipment and item, " + equipment2 + " and " + item2 + "." +
            "\n" + character3 + ", the mage she has ability " + ability3 + " and has the equipment and item, " + equipment3 + " and " + item3 + "." +
            "\n" + character4 + ", the marksman she has the ability " + ability4 + " and has the ability and item, " + equipment4 + " and " + item4 + "." +
            "\n" + character5 + ", the assassin she has the ability " + ability5 + " and has the ability and item, " + equipment5 + " and " + item5 + "." +
            "\n\nThese brave adventurers have their each and different abilities, equipment, and skill, " +
            "\nhave embarked to defeat the Demon Lord to save their land.";

        Console.WriteLine(story);

        // Input validation for number pattern
        int patternInput = 0;

        while (patternInput <= 0)
        {
            Console.Write("\nEnter a number for pattern: ");
            patternInput = int.Parse(Console.ReadLine());

            if (patternInput <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        Console.WriteLine("\nNumber Pattern (Task 1):");
        int i = 1;

        while (i <= patternInput)
        {
            int j = 1;
            while (j <= i)
            {
                Console.Write(j + " ");
                j++;
            }
            Console.WriteLine();
            i++;
        }
        int sumInput = 0;

        while (sumInput <= 0)
        {
            Console.Write("\nEnter a number for sum calculation: ");
            sumInput = int.Parse(Console.ReadLine());

            if (sumInput <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
        int sum = 0;
        i = 1;

        while (i <= sumInput)
        {
            sum += i;
            i++;
        }
        Console.WriteLine("\nSum Calculation (Task 2): Formula: 1 + 2 + 3 + ... + " + sumInput);
        Console.WriteLine("Result: " + sum);

       
        int decreasingPatternInput = 0;

        while (decreasingPatternInput <= 0)
        {
            Console.Write("\nEnter a number for decreasing pattern: ");
            decreasingPatternInput = int.Parse(Console.ReadLine());

            if (decreasingPatternInput <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        Console.WriteLine("\nDecreasing Number Pattern:");
        i = decreasingPatternInput;

        while (i >= 1)
        {
            int j = 1;
            while (j <= i)
            {
                Console.Write(j + " ");
                j++;
            }
            Console.WriteLine();
            i--;
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
