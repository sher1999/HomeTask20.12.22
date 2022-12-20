
Employee employee=new Employee(12345,"Sherzod","Ishankulov",2000);
System.Console.WriteLine("ID : "+employee.GetID());
System.Console.WriteLine("FirstName : "+employee.GetFirstName());
System.Console.WriteLine("LastName : "+employee.GetLastName());
System.Console.WriteLine("Name : "+employee.Name());
System.Console.WriteLine("Salary : "+employee.GetSalary());


System.Console.Write("Do you want to change the salary ? ");
string change=Convert.ToString(Console.ReadLine());
  if (change=="YES")
  {
    System.Console.Write("Add amount : ");
    int a=Convert.ToInt32(Console.ReadLine());
    employee.SetSalary(a);
    System.Console.WriteLine($"Salary successfuly changed to : {a} ");
  }
 

System.Console.WriteLine( "Annual salary : "+ employee.GetAnnaulSalary());

System.Console.Write("How many percent to raise the salary : ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("After raising by percentage : "+ employee.RaiseSalary(n));

System.Console.WriteLine(employee.ToString());

// System.Console.WriteLine();

// Employee employe=new Employee(54321,"Shahzod","Ishankulov",3000);
// System.Console.WriteLine("ID : "+employe.GetID());
// System.Console.WriteLine("FirstName : "+employe.GetFirstName());
// System.Console.WriteLine("LastName : "+employe.GetLastName());
// System.Console.WriteLine("Name : "+employe.Name());
// System.Console.WriteLine("Salary : "+employe.GetSalary());


// System.Console.Write("Do you want to change the salary ? ");
// string chang=Convert.ToString(Console.ReadLine());
//   if (chang=="YES")
//   {
//     System.Console.Write("Add amount : ");
//     int a=Convert.ToInt32(Console.ReadLine());
//     employe.SetSalary(a);
//     System.Console.WriteLine($"Salary successfuly changed to : {a} ");
//   }
 

// System.Console.WriteLine( "Annual salary : "+ employe.GetAnnaulSalary());

// System.Console.Write("How many percent to raise the salary : ");
// int b=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("After raising by percentage : "+ employe.RaiseSalary(b));

// System.Console.WriteLine(employe.ToString());
