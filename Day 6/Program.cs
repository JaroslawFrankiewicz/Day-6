using Day_6;

Employee employee1 = new Employee("Adam", "Nowak", 24);
Employee employee2 = new Employee("Monika", "Kowalska", 25);
Employee employee3 = new Employee("Zuzia", "Stępień", 27);

employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(2);
employee1.AddScore(3);

employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(8);
employee2.AddScore(2);
employee2.AddScore(3);

employee3.AddScore(7);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(9);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Pracownik: " + employeeWithMaxResult.FirstName + " " + employeeWithMaxResult.SureName + " lat " + employeeWithMaxResult.Age + " uzyskał(-a) najwięcej punktów: " + maxResult);
