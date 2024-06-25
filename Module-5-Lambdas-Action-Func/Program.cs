class Program
{
    static void Main(string[] args)
    {
        var custs = new List<Customer>
        {
            new("Phoenix", "John", "Doe", 1),
            new("Phoenix", "Jane", "Doe", 500),
            new("Seattle", "Suki", "Pizzoro", 3),
            new("New York City", "Michelle", "Smith", 4)
        };

        var phxCusts = custs.
            Where(c => c.City == "Phoenix" && c.Id < 500).
            OrderBy(c => c.FirstName);

        foreach (var cust in phxCusts)
        {
            Console.WriteLine(cust.FirstName);
        }

        var data = new ProcessData();
        BizRulesDelegate addDel = (x, y) => x + y;
        BizRulesDelegate multiplyDel = (x, y) => x * y;
        data.Process(2, 3, multiplyDel);

        Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
        Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
        data.ProcessAction(2, 3, myMultiplyAction);

        Func<int, int, int> funcAddDel = (x, y) => x + y;
        Func<int, int, int> funcMultipleDel = (x, y) => x * y;
        data.ProcessFunc(3, 2, funcMultipleDel);

        var worker = new Worker();
        worker.WorkPerformed += (s, e) => {
            Console.WriteLine("Worked: " + e.Hours + " hour(s) doing: " + e.WorkType);
            Console.WriteLine("Some other value");
        };
        worker.WorkCompleted += (s, e) => Console.WriteLine("Work is complete");
        worker.DoWork(8, WorkType.GenerateReports);

        Console.Read();
    }    

    static void Worker_WorkCompleted(object? sender, EventArgs e)
    {
        Console.WriteLine("Work has completed");
    }

    static void Worker_WorkPerformed(object? sender, WorkPerformedEventArgs e)
    {
        Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
    }

}

public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}