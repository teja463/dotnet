
namespace ProjectA;

internal class EmployeeIndex
{
   

    public int EmployeeId { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{EmployeeId}, {Name}";
    } 
}
public class Indexers
{
    private List<EmployeeIndex> employees;

    public Indexers()
    {
        employees = new List<EmployeeIndex>();
        employees.Add(new EmployeeIndex() { EmployeeId =1, Name = "Test1"});
        employees.Add(new EmployeeIndex() { EmployeeId = 2, Name = "Test2" });
    }

    public string this[int employeeId]
    {
        get
        {
            return employees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
        }
        set
        {
            EmployeeIndex employees1 = employees.FirstOrDefault(emp => emp.EmployeeId.Equals(employeeId));
            employees1.Name = value;
        }
    }
}
