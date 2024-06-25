class Program
{
    static void Main(string[] args)
    {
        //var del1 = new WorkPerformedHandler(WorkPerformed1);
        //var del2 = new WorkPerformedHandler(WorkPerformed2);

        //del1 += del2;

        //int finalHours = del1(10, WorkType.Golf);

        var worker = new Worker();
        worker.WorkPerformed += Worker_WorkPerformed;
        worker.WorkCompleted += Worker_WorkCompleted;
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

    //static int WorkPerformed1(int hours, WorkType workType)
    //{
    //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
    //    return hours + 1;
    //}

    //static int WorkPerformed2(int hours, WorkType workType)
    //{
    //    Console.WriteLine("WorkPerformed2 called " + workType.ToString());
    //    return hours + 1;
    //}

}

public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}