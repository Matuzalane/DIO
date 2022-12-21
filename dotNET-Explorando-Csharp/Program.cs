using dotNET_Explorando_Csharp.Models;
using Models;
using Newtonsoft.Json;

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

// ----------------------------------------------------------- //
// ----------------- How Tuples work in c# ------------------- // 
// ----------------------------------------------------------- //

    (int Id, string Name, string LastName, decimal Height) tuple = (1, "Caleb", "Castilho Nunes", 1.85M);

    // ValueTuple<int, string, string, decimal> anotherExempleTuple = (1, "Caleb", "Castilho Nunes", 1.85M);
    // var anotherExempleTupleCreate = Tuple.Create(1, "Caleb", "Castilho Nunes", 1.85M);

    Console.WriteLine($"Id: {tuple.Item1}");
    Console.WriteLine($"Name: {tuple.Item2}");
    Console.WriteLine($"Last Name: {tuple.Item3}");
    Console.WriteLine($"Height: {tuple.Item4}");

    FileReading archieve = new FileReading();

    var (success, archiveLines, _) = archieve.ReadFile("Archives/readFlie.txt");

    if (success)
    {
        //Console.WriteLine($"Number of lines in the archieve: {numberOfLines}");
        foreach (var line in archiveLines)
        {
            Console.WriteLine(line);
        }
    }
    else
    {
        Console.WriteLine("Could not read the file.");
    }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// -------------- How Deconstruct work in c# ----------------- // 
// ----------------------------------------------------------- //

    Person p3 = new Person("Caleb", "Castilho Nunes");

    (string name, string lastname) = p3;

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// -------------- How ternary if work in c# ------------------ // 
// ----------------------------------------------------------- //

    int number = 15;
    bool isEven = false;

    isEven = number % 2 == 0;
    Console.WriteLine($"The number {number} is " + (isEven ? "Even" : "Odd"));

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// -------------- Serialization in Practice ------------------ // 
// ----------------------------------------------------------- //

    DateTime currentDate = DateTime.Now;

    List<Sale> salesList = new List<Sale>();

    Sale s1 = new Sale(1, "Office Supplies", 25.00M, currentDate);
    Sale s2 = new Sale(2, "Software License", 150.00M, currentDate);

    salesList.Add(s1);
    salesList.Add(s2);

    string serialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);

    File.WriteAllText("Archives/sales.json", serialized);

    Console.WriteLine(serialized);

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// ------------- Deserialization in Practice ----------------- // 
// ----------------------------------------------------------- //

    string archiveContent = File.ReadAllText("Archives/sales.json");

    List<Sale> salesConvert = JsonConvert.DeserializeObject<List<Sale>>(archiveContent);

    foreach (Sale sale in salesConvert)
    {
        Console.WriteLine($"Id: {sale.Id}, Product: {sale.Product}, Price: {sale.Price}, Date: {sale.SaleDate.ToString("dd/MM/yyyy HH:mm")}");
    }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //

// ----------------------------------------------------------- //
// ----------------- Special Tipes in C# --------------------- // 
// ----------------------------------------------------------- //

    // Nulable Tipes
    bool? wantReceiveEmail = null;

    if (wantReceiveEmail.HasValue && wantReceiveEmail.Value)
    {
        Console.WriteLine("The user has opted in to receive email.");
    }
    else
    {
        Console.WriteLine("The user did not respond or opted out of receiving email.");
    }


    // Anonymous Tipes
    var anonymousTipe = new { Name = "Caleb", LastName = "Castilho Nunes", Height = 1.80 };

    Console.WriteLine("Name: " + anonymousTipe.Name);
    Console.WriteLine("Last Name: " + anonymousTipe.LastName);
    Console.WriteLine("Height: " + anonymousTipe.Height);


    // Dynamics Tipes
    dynamic dynamicVariable = 4;
    Console.WriteLine($"Variable Type: {dynamicVariable.GetType()}, Value: {dynamicVariable}");

    dynamicVariable = "Text";
    Console.WriteLine($"Variable Type: {dynamicVariable.GetType()}, Value: {dynamicVariable}");

    dynamicVariable = true;
    Console.WriteLine($"Variable Type: {dynamicVariable.GetType()}, Value: {dynamicVariable}");


    // Generic Class in C# 
    MyArray<string> arrayString = new MyArray<string>();

    arrayString.AddElementArray("Caleb Castilho Nunes");

    Console.WriteLine(arrayString[0]);


    MyArray<int> arrayInteger = new MyArray<int>();

    arrayInteger.AddElementArray(30);

    Console.WriteLine(arrayInteger[0]);


    // Extension Methods in c# 
    int x = 15;
    bool isOdd = false;

    isOdd = x.IsEven();

    string mensage = $"The number {x} is " + (isOdd ? "Even" : "Odd");
    Console.WriteLine(mensage);


// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ //