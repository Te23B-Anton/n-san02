
// while (true)
// {
//     Console.Write("Skriv lösendordet: ");
//     string lösenord = Console.ReadLine();

//     if (lösenord == "sigma"){
//         Console.WriteLine("Rätt lösenord");
//         break;
//     }
//     else{
//     Console.WriteLine("fel lösenord");
//     }

// }
// Console.ReadLine();

// första saken och andra:

//  string[] leksaker = ["spadar" , "svärd" ,"bilar" , "gosedjur" , "dockor"];

// foreach(string leksak in leksaker)
//     Console.WriteLine(leksak);

// string[] namn = ["oscar" , "elis" , "teo" , "lucas" , "max" ];

// string[] siffra = ["2" , "3" , "5" , "7" , "9" ];


// Console.WriteLine($"{RandomFromList(namn)} ger {RandomFromList(siffra)} stycken {RandomFromList(leksaker)}");



// static string RandomFromList(string[] lista){
//     return lista[Random.Shared.Next(lista.Length)];
// }

using System.Runtime.InteropServices;

List<string> cities = new List<string>(); 

while (true)
{
    Console.WriteLine("write cities:");
    string city = Console.ReadLine() ?? String.Empty;

    if(city == "exit"){
        break;
    }
    cities.Add(city);
    
}
    Console.Clear();
    Console.WriteLine("You have : ");
foreach(string namn in cities){
    Console.WriteLine($"{namn}");
}

Console.ReadLine();
