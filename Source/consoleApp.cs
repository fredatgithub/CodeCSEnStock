Action<string> display = Console.WriteLine;
display("Press a key to exit:");
Console.ReadKey();

Console.WriteLine($"La valeur du path Windows est : {Environment.GetEnvironmentVariable("Path")}");

