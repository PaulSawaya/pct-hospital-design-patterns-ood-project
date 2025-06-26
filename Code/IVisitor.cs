namespace OOD_Hospital_Project.Entrants
{
    public interface IVisitor : IEntrants
    {
        DateTime VisitDate { get; set; }
        string DisplayInfo();
    }   
}