// See https://aka.ms/new-console-template for more information
using ConsoleAppexample_new;
//Console.WriteLine("Hello, World!");

List<Employee> employees = new List<Employee>()
{
new Employee(){ id =1,Name ="vijay",Designation ="Developer",Doj =new DateTime (day:12,month:11,year:2022)},
new Employee(){ id =2,Name ="Niraj",Designation ="Tester",Doj =new DateTime (day:12,month:11,year:2022)},
new Employee(){ id =3,Name ="varun",Designation ="Manager",Doj =new DateTime (day:12,month:11,year:2022)},
new Employee(){ id =4,Name ="Teejay",Designation ="Developer",Doj =new DateTime (day:12,month:11,year:2022)},
new Employee(){ id =5,Name ="Rocky",Designation ="Manager",Doj =new DateTime (day:12,month:11,year:2022)},
new Employee(){ id =6,Name ="Govind",Designation ="Developer",Doj =new DateTime (day:12,month:11,year:2022)},
};
Console.WriteLine("id\tName\tDesignation\tDate of joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.id + "\t\t");
    Console.Write(emp.Name + "\t\t");
    Console.Write(emp.Designation + "\t\t");
    Console.Write(emp.Doj.ToLongDateString() + "\t\t");
    Console.Write("\n");

}
