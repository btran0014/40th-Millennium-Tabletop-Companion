namespace backend.Models
{
    public class Faction
    {
        public int Id {get; set;}
        public string? ExternalSlug {get; set;} //Using a slug allows us to actually name our domain suffix rather than using a generated number ID on our URL
        public string Name {get; set;} = string.Empty;
        public string? Description {get; set;}
        public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;
        public ICollection<Unit> Units {get; set;} = new List<Unit>();
        public ICollection<ArmyList> ArmyLists {get; set;} = new List<ArmyList>();

    }
}