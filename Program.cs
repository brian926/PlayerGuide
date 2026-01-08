// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Target Row? ");
string row = Console.ReadLine();
Console.Write("Target Column? ");
string column = Console.ReadLine();
Console.WriteLine("Deploy to:");
int rowInt = Convert.ToInt32(row);
int colInt = Convert.ToInt32(column);

Console.WriteLine($"({rowInt + 1}, {column})");
Console.WriteLine($"({row}, {colInt - 1})");
Console.WriteLine($"({rowInt - 1}, {column})");
Console.WriteLine($"({row}, {colInt + 1})");

