// See https://aka.ms/new-console-template for more information
//rakendus küsib tema vanust
//Kui kasutaja vanus väiksem kui 13, siis konsoolis:
//"You are too young to use Instagram"
//muul juhul
//Konsoolis kuvatakse "Weolcome Instagram"

using System.Collections.Specialized;

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Weolcome to Instagram!");
}
else if (userAge == 13)
{
    Console.WriteLine("Weolcome to Instargram!");

}
else //if (usegAge <13) 
{
    Console.WriteLine("You are too young to use Instagram.");
}
