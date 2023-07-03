Console.Write("type username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha") 
{
    Console.WriteLine("Hooray! This is Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}