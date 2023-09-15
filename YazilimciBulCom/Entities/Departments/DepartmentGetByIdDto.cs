namespace YazilimciBulCom.Entities.Departments
{
    public class DepartmentGetByIdDto
    {
        public string? Name { get; set; }

        public DepartmentGetByIdDto(string name)
        {
            Name = name;
        }
    }
}
