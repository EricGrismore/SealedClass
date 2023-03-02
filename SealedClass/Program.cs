interface IEmployee
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
    public double Pay();
}
class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}
class Executive : Employee
{
    public double Rate { get; set; }
    public int Hour { get; set; }
    public Executive() :base()
    {
        Rate = 0;
        Hour = 0;

    }
    public Executive(int id, string firstName, string lastName, double rate, int hour)
        :base(id, firstName, lastName)
    {
        Rate = rate;
        Hour = hour;
    }

    public sealed override double Pay()
    {
        if (Hour > 20)
            return 20 * Rate;
        else 
            return Rate * Hour;
    }

    static void Main(string[] args)
    {
        Employee tyler = new Employee(5625, "Tyler", "Denmark");
        Console.WriteLine(tyler.Pay());
        Console.WriteLine("Good Work Today");

        Executive bill = new Executive(45561, "Bill", "Syfer", 45, 70);
        Console.WriteLine(bill.Fullname());
        Console.WriteLine(bill.Pay());

        Executive dexter = new Executive(44752, "Dexter", "Marshall", 50, 70);
        dexter.Id = 44752;
        dexter.FirstName = "Dexter";
        dexter.LastName = "Marshall";
        dexter.Rate = 60;
        dexter.Hour = 70;
        Console.WriteLine(dexter.Fullname());
        Console.WriteLine(dexter.Pay());

    }

}

