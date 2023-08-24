namespace EmployeeSolutionAssignment
{
    public class EmployeeDetailsStructure
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string Mobile { get; set; }


        public EmployeeDetailsStructure(string name, int id, string mobile)
        {
            Name = name;
            Id = id;
            Mobile = mobile;
        }
    }
}
