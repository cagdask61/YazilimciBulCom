namespace YazilimciBulCom.Entities.Provinces
{
    public class ProvinceListDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public ProvinceListDto(int id, int number, string name)
        {
            Id = id;
            Number = number;
            Name = name;
        }
    }
}
