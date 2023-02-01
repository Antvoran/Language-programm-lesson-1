Console.WriteLine("введите имя");
string username = Console.ReadLine();
if(username.ToLower() == "Маша")
{
    Console.WriteLine("Здравствуй, Машенька!");
}
else 
{
    Console.Write("Здарова, ");
    Console.WriteLine(username);
}