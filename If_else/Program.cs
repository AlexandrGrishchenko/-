
Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();

if (username.ToLower() == "masha") 
{
  Console.WriteLine("Hello, Masha!!!!");

}
else 
{
    Console.Write("Hello, ");
    Console.Write(username);
}