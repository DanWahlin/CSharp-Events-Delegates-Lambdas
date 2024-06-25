class Program
{
    static void Main(string[] args)
    {

        //var del1 = new WorkPerformedHandler(WorkPerformed1);
        //var del2 = new WorkPerformedHandler(WorkPerformed2);

        //del1 += del2;

        //int finalHours = del1(10, WorkType.Golf);

        var worker = new Worker();


        Console.Read(); 
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