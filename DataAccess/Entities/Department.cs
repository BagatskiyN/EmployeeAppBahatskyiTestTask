namespace DataAccess.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public int Floor { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
