﻿using dotNET_Explorando_Csharp.Models;

Person p1 = new Person(name: "Caleb", lastname: "Nunes");
Person p2 = new Person(name: "Eduardo", lastname: "Neves Queiroz");


Course englishCourse = new Course();
englishCourse.Name = "English";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudent();


// ----------------------------------------------------------- //
// ----------------- Read an archive in C# ------------------- // 
// ----------------------------------------------------------- //

    try 
    {
        string[] lines = File.ReadAllLines("Archives/read_File.txt");

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    } 
    catch(FileNotFoundException ex)
    {
        Console.WriteLine($"A file read error occurred. File not found. {ex.Message}");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"A generic exception occurred. {ex.Message}");
    }
    finally 
    {
        Console.WriteLine("Hello World!");
    }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// ----------------- Read an archive in C# ------------------- // 
// ----------------------------------------------------------- //

    new ExceptionExemple().Method1();

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// ----------------- How Queues work in c# ------------------- // 
// ----------------------------------------------------------- //

    Queue<int> queue = new Queue<int>();

    queue.Enqueue(2);
    queue.Enqueue(4);
    queue.Enqueue(6);
    queue.Enqueue(8);

    foreach (var item in queue)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Remove the element: {queue.Dequeue()}");
    queue.Enqueue(10);

    foreach (var item in queue)
    {
        Console.WriteLine(item);
    }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// ------------------ How Stack work in c# ------------------- // 
// ----------------------------------------------------------- //

    Stack<int> stack = new Stack<int>();

    stack.Push(4);
    stack.Push(6);
    stack.Push(8);
    stack.Push(10);

    foreach (var item in stack)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Remove the top element: {stack.Pop()}");
    
    stack.Push(20);

    foreach (var item in stack)
    {
        Console.WriteLine(item);
    }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// --------------- How Dictionary work in c# ----------------- // 
// ----------------------------------------------------------- //

    Dictionary<string, string> states = new Dictionary<string, string>();

    states.Add("SP", "São Paulo");
    states.Add("BA", "Bahia");
    states.Add("MG", "Minas Gerais");

    foreach (var item in states)
    {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
    }

    Console.WriteLine(".......................");

    states.Remove("BA");
    states["SP"] = "São Paulo - Altered Value";

    foreach (var item in states)
    {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
    }

    string key = "BA";
    Console.WriteLine($"Verifying the key: {key}");

    if (states.ContainsKey(key))
    {
        Console.WriteLine($"Existing value: {key}");
    }
    else
    {
        Console.WriteLine($"Value does not exist. Is it safe to add the key: {key}");
    }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //