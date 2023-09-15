namespace YazilimciBulCom.Entities.Provinces
{
    public class ProvinceGetByIdDto
    {
        public string? Name { get; set; }

        public ProvinceGetByIdDto(string name)
        {
            Name = name;
        }
    }
}
