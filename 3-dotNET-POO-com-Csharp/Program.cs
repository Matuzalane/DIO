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

// Heritage example
Student s1 = new Student();
s1.Name = "Caleb";
s1.Age = 24;
s1.Grade = 10;

s1.Introduce();

// Polymorphism example
Teacher t1 = new Teacher();
t1.Name = "Caleb";
t1.Age = 24;
t1.Salary = 1000;

t1.Introduce();

// Abstract class example
Current c = new Current();
c.Credit(500);
c.ShowBalance();
