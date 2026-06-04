Console.Clear();
// Control flow intro

// greeting based on time of day App
// give a greeting if time of day is a number (0-23) or else tell user the time is invalid

// Pseudokode:

// if hour is outside of 0-23 range print invalid time
// if hour is between 0 and 6 say "Good night"
// if hour is between 7 and 11 say "Good morning"
// if hour is between 12 and 17 say "Good afternoon"
// if hour is between 18 and 23 say "Good evening"

int hour = 999;

// AND operator: &&
// OR operator: ||

if (hour < 0 || hour > 23)
{
    // show error msg
    Console.WriteLine("Invalid time!");
}
else
{
    // user entered a valid time
    if (hour <= 6)
    {
        Console.WriteLine("Good night");
    }
    else if (hour <= 11)
    {
        Console.WriteLine("Good morning");
    }
    else if (hour <= 17)
    {
        Console.WriteLine("Good afternoon");
    }
    else
    {
        Console.WriteLine("Good night");
    }
}