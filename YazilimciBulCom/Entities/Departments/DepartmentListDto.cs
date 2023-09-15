namespace YazilimciBulCom.Entities.Departments
{
    public class DepartmentListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DepartmentListDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}