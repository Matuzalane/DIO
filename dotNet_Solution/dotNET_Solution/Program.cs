using dotNET_Solution.Common.Models;

string option;
bool displayMenu = true;

while(displayMenu)
{
    Console.Clear();
    Console.WriteLine("Enter your option:");
    Console.WriteLine("1 - Register Customer");
    Console.WriteLine("2 - Search Customer");
    Console.WriteLine("3 - Delete Client");
    Console.WriteLine("4 - Close");

    option = Console.ReadLine();

    switch(option)
    {
        case "1":
            Console.WriteLine("Customer Registration");
            break;
        
        case "2":
            Console.WriteLine("Customer Search");
            break;
        
        case "3":
            Console.WriteLine("Delete Client");
            break;
        
        case "4":
            Console.WriteLine("Close");
            //Environment.Exit(0);
            displayMenu = false;
            break;
        
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}