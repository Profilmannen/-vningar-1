
if (6 >= 3){
    Console.WriteLine("Hellwo world");
}


Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();
Console.WriteLine("Vad är ditt lösenord?");

string lösenord = Console.ReadLine(); 

if (namn == "noname" && lösenord == "nopass")
{
     Console.WriteLine("Välkommen");
}

else
{
    Console.WriteLine("Fel lösenord eller namn!");

}

for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello world!");
}
    





Console.ReadLine();