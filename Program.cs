// See https://aka.ms/new-console-template for more information

//Enumeratore: tipo di dato che contiene dei valori fissi
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear(); 

// Ciclo for
for (int i = 0; i < 10; i++) 
{
    Console.WriteLine(i);
}
Console.WriteLine("END"); // Viene invocato il metodo toString() che converte quello che scrivo in una vera e propria stringa

var x = Console.ReadLine(); // Il ReadLine ci lascia scrivere, e rimane fermo fin tanto che non premiamo invio
var k = Console.ReadKey(); // Il ReadKey ci lascia premere solo un tasto, e non appena lo premiamo il codice prosegue
if(k.Key == ConsoleKey.Enter) 
{
    Console.WriteLine("Hai premuto invio");
}
else if (k.KeyChar == 'a') 
{
    Console.WriteLine("Hai premuto a");
}

// Quando compiliamo codice, siamo in modalità "debug"


// Per avviare il progetto: dotnet run
// Per compilare il progetto: dotnet build
