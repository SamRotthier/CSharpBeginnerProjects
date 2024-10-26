namespace SimpleCurrencyAndTemperatureConverter;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Please enter 'c' to use the currency converter or anything else to use the temperature converter");
        string answer = Console.ReadLine();


        if(answer == "c")
        {
            Console.WriteLine("You have selected the currency converter.");
            Console.WriteLine("Please enter 'a' to convert pounds or anything else to convert from euros");
            string choice = Console.ReadLine();

            if(choice== "a")
            {
                Console.WriteLine("Please enter your amount in British pounds.");
                float pounds = float.Parse(Console.ReadLine());
                float euros = pounds * 1.16f;
                Console.WriteLine("The amount in euros is " + euros.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("Please enter your amount in euros.");
                float euros = float.Parse(Console.ReadLine());
                float pounds = euros / 1.16f;
                Console.WriteLine("The amount in pounds is " + pounds.ToString("0.00"));
            }
        }
        else
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine("Please enter 'a' to convert from celcius or anything else to convert from farenheit.");
            string choice = Console.ReadLine();

            if (choice == "a")
            {
                Console.WriteLine("Enter a temperature in celcius.");
                float celcius = float.Parse(Console.ReadLine());
                float farenheit = celcius * 1.18f + 32f;
                Console.WriteLine("The temperature in farenheit is " + farenheit);
            }
            else
            {
                Console.WriteLine("Enter a temperature in farenheit.");
                float farenheit = float.Parse(Console.ReadLine());
                float celcius = (farenheit -32f) / 1.18f;
                Console.WriteLine("The temperature in celcius is " + celcius);
            }
        }
    }
}