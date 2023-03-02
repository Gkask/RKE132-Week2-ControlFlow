// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt tema sugu(m/f)
//rakendus küsib kasutajalt tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat:
//"Welcome, MR Perekonnanimi /"Welcome, Ms kasutaja perekonnanimi"


Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid strin(sõne) formaadis

Console.WriteLine("Please enter your name;");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f') 
{
    Console.WriteLine($"Welcome, Ms. {userLastName} !");
}
else
{
    Console.WriteLine("Welcome!");
}

Console.WriteLine($"Weolcome, {userGender}");
