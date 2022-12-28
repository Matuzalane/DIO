using _3_dotNET_POO_com_Csharp.Models;

// OOP example
Person p1 = new Person();
p1.Name = "Caleb";
p1.Age = 24;

p1.Introduce();

// Encapsulation example
CurrentAccount c1 = new CurrentAccount(123, 1000);

c1.DisplayBalance();
c1.Withdraw(500);
c1.DisplayBalance();
