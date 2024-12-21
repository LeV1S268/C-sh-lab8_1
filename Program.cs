using System;
using System.IO;
using System.Text.Json;
using System.Text.Json;
using ClassLibrary08;

class Program
{
    public static void Main()
    {
        Lion lion = new Lion("India", "Leo");

        //Сериализация
        string jsonstring = JsonSerializer.Serialize(lion);
        Console.WriteLine(jsonstring);
    }
}