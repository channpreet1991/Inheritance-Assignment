using System;
class Project {
    static void Main() {
        Employee employee = new Employee(); 
        employee.FirstName = "Sample";
        employee.LastName = "Student";
        employee.sayName(); 
    }
}
class Person {
    public string FirstName;
    public string LastName;
    public void sayName() {
        Console.WriteLine("Name: " + FirstName + " " + LastName);  
    }
}
class Employee : Person {
    public int Id;
}