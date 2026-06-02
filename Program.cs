// On program start we show user a greeting or a menu
Console.WriteLine("Welcome to our app!");
Console.WriteLine();

// prompt user for a number
Console.WriteLine("Enter your lucky number: ");

int luckyNumber = int.Parse(Console.ReadLine()); // ReadLine gir oss en String


// luckyNumber = luckyNumber + 2000; // same as: luckyNumber += 2000;

// other math operators: -,*,/

// luckyNumber = luckyNumber - 2; // same as: luckyNumber -= 2;

//luckyNumber = luckyNumber * 5; // same as: luckyNumber *= 2;

// luckyNumber = luckyNumber / 5; // same as: luckyNumber /= 2;


Console.WriteLine("luckyNumber is now " + luckyNumber);