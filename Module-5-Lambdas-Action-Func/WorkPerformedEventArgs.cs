public class WorkPerformedEventArgs 
{ 
    public int Hours { get; } 
    public WorkType WorkType { get; } 
    public WorkPerformedEventArgs(int hours, WorkType workType) => 
        (Hours, WorkType) = (hours, workType); 
}

