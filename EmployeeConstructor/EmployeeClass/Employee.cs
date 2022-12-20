

public class Employee

{
    int _id;
    string _firstName;
    string _lastName;
    int _salary;

 
    public Employee(int id,string firstName,string lastName, int salary)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _salary = salary;
    }
    public int GetID()
    {
        return _id;
    }
    public string GetFirstName()
    {
        return _firstName;
    }
    public string GetLastName()
    {
        return _lastName;
    }
    public string Name()
    {
        return $"{_firstName} {_lastName}";
       
    }
    public int GetSalary()
    {
        return _salary;
    }
    public void SetSalary(int salary)
    {
        _salary=salary;
    }
    public int GetAnnaulSalary()
    {
        return _salary * 12;
    }
    public int RaiseSalary(int percent)
    {
        return     _salary+=(_salary * percent) / 100;
    }
    public string ToString()
    {
        return $"id={_id}  name={Name()} salary={_salary}";
    }

}
