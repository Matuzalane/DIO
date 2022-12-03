﻿using dotNET_Introducao.Models;

// ------------------------------------------------------------- //
// -- Introduction to IDEs and .Net Environment Configuration -- // 
// ------------------------------------------------------------- //

    Person Person1 = new Person();

    Person1.Name = "Caleb";
    Person1.Age = 24;
    Person1.Present();

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //


// ----------------------------------------------------------- //
// -------------- Syntax and Data Types in C# ---------------- // 
// ----------------------------------------------------------- //

    //Declaration of Variables
    string presentation = "Hello, welcome";
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

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// ---------------- Types of Operators in C# ----------------- // 
// ----------------------------------------------------------- //

    // Assignment Operator
    int a = 10;
    int b = 20;

    int c = a + b;

    // Combining Operators
    c += 5; // This is equal to c = c + 5;

    // Cast or Casting
    a = Convert.ToInt32("5");
    a = int.Parse("5");

    a = 5;
    string x = a.ToString();

    // ------------------------------------------------------- //
    // - Difference between Parce and Convert -
    //
    // * The convert class replaces null values with 0 and 
    // * the parse method returns an error in the program";
    // ------------------------------------------------------- //
    
    // Converting types safely
    x = "15-";
    b = 0;

    int.TryParse(x, out b);

    // Conditional Operators
    int quantityInStock = 3;
    int purchaseQuantity = 0;
    bool possibleSale = purchaseQuantity > 0 && quantityInStock >= purchaseQuantity;


    Console.WriteLine($"Quantity in stock: {quantityInStock}");
    Console.WriteLine($"Purchase Quantity: {purchaseQuantity}");
    Console.WriteLine($"Is it possible to sell? {possibleSale}");

    if (purchaseQuantity == 0)
    {
        Console.WriteLine("Invalid sale.");
    }
    else if (possibleSale)
    {
        Console.WriteLine("Sale Done.");
    }
    else
    {
        Console.WriteLine("Sorry, we don't have that quantity in stock.");
    }

    // Switch Case
    Console.WriteLine("Type a letter");
    string letter = Console.ReadLine();

    switch (letter)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("Vowel");
            break;

        default:
            Console.WriteLine("Is not a vowel");
            break;
    }

    // Logical Operators - OR ||
    bool ofLegalAge = true;
    bool haveParentalConsent = false;

    if (ofLegalAge || haveParentalConsent)
    {
        Console.WriteLine("Authorized entry");
    }
    else
    {
        Console.WriteLine("Unauthorized entry");
    }

    // Logical Operators - AND &&
    bool hasMinimalPresence = true;
    double average = 7.5;

    if (hasMinimalPresence && average >= 7)
    {
        Console.WriteLine("Approved");
    }
    else
    {
        Console.WriteLine("Disapproved");
    }

    // Logical Operators - NOT !
    bool rained = true;
    bool itIsLate = true;

    if (!rained && !itIsLate)
    {
        Console.WriteLine("I'm going to pedal");
    }
    else
    {
        Console.WriteLine("I will pedal another day");
    }


    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);

    Console.WriteLine(x);
    
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //