using ClassExercise1;
using System.Text.Json;



Console.WriteLine("Press 1 to add a cat food product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

CatFood catFood = new CatFood();



while (userInput.ToLower() != "exit")
{
    if (userInput == "1")

        Console.Write("Enter the brand name: ");

    string name = Console.ReadLine();
    catFood.Name = name;

    Console.Write("Enter the price: ");

    decimal price = decimal.Parse(Console.ReadLine());
    catFood.Price = price;

    Console.Write("Enter the quantity: ");

    int quantity = int.Parse(Console.ReadLine());
    catFood.Quantity = quantity;

    Console.Write("Enter the description: ");

    string description = Console.ReadLine();
    catFood.Description = description;

    Console.Write("Enter the weight in pounds: ");

    double weight = double.Parse(Console.ReadLine());
    catFood.WeightPounds = weight;

    Console.Write("Is it kitten food? (yes/no): ");

    string kitten = Console.ReadLine();
    bool isKitten = kitten == "yes";
    catFood.KittenFood = isKitten;

    Console.WriteLine();


    Console.WriteLine(JsonSerializer.Serialize(catFood));

}













