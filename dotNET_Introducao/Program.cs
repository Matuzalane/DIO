using dotNET_Introducao.Models;

//Declaration of Variables
string presentation = "Olá, seja bem vindo";
int quantity = 1;
double height = 1.80;
decimal price = 1.80M;
bool condition = true;
DateTime dataAtual = DateTime.Now.AddDays(5);

//Displaying the values ​​of the variables on the screen
Console.WriteLine(presentation);
Console.WriteLine("Value of the quantity variable: " + quantity);
Console.WriteLine("Value of the height variable: " + height.ToString("0.00"));
Console.WriteLine("Value of the price variable: " + price);
Console.WriteLine("Value of the condition variable: " + condition);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Caleb";
// pessoa1.Idade = 24;
// pessoa1.Apresentar();