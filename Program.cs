using OOP;
using System.Net.Http.Headers;




Test5 test5 = new Test5();
test5.Method();
Console.WriteLine(test5.Name);

test5.Method1();
Console.WriteLine(test5.Name1);














public class Person1 //можно изменить 
{
    public string Name { get; set; } //можно изменить 
    public int Age { get; set; }

    //public string Name { get; init; }//не получится изменить с модификатором init 
    public Person1(string name, int age) { Name = name; Age = age; }
    public void Deconstruct(out string name, out int age) { name = Name; age = Age; } // => (name, age) = (Name, Age);
}

//public record Person //можно изменить 
//{
//    public string Name { get; set; } //можно изменить 
//    public int Age { get; set; }
//
//    //public string Name { get; init; }//не получится изменить с модификатором init 
//    public Person(string name, int age) { Name = name; Age = age; }
//    public void Deconstruct(out string name, out int age) { name = Name; age = Age; } // => (name, age) = (Name, Age);
//}
//
//public record Person 
//{
//    public string Name { get; init; } //не возможно изменить 
//    public int Age { get; init; } //не возможно изменить 
//
//    //public string Name { get; init; }//не получится изменить с модификатором init 
//    public Person(string name, int age) { Name = name; Age = age; }
//    public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
//}


public record class Person //не возможно создать record класса с модификатор readonly
{
    public string Name { get; init; } //можно изменить 
    public int Age { get; set; }

    //public string Name { get; init; }//не получится изменить с модификатором init 
    public Person(string name, int age) { Name = name; Age = age; }
    public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
}



//public record struct User //можно изменить
//{
//    public string Name { get; set; } //нужно сразу передать значенеи
//    public int Age { get; set; }//нужно сразу передать значенеи

//    public User(string name, int age)  { Name = name; Age = age; }
//}


//public readonly record struct User //не можно изменить
//{
//    public string Name { get; init; } = "";//нужно сразу передать значенеи и обизательно модефикатор init
//    public int Age { get; init; } = 0;//нужно сразу передать значенеи и обизательно модефикатор init
//
//    public User(string name, int age)  { Name = name; Age = age; }
//}

//public readonly record struct User(string Name, int Age);// не можно изменить
public record struct User(string Name, int Age);//можно изменить 


