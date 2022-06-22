namespace Entity6._0Solution.DTO
{
    public class MedicamentDTO
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Type { get; set; }
        public MedicamentDTO(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
