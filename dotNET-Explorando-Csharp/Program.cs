using dotNET_Explorando_Csharp.Models;

Person p1 = new Person(name: "Caleb", lastname: "Nunes");
Person p2 = new Person(name: "Eduardo", lastname: "Neves Queiroz");


Course englishCourse = new Course();
englishCourse.Name = "English";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudent();