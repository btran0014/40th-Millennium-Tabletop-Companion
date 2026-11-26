namespace backend.Models
{
    public class ArmyList
    {
        public int Id {get; set;}
        public int UserId {get; set;}
        public User User {get; set;} = null!;
        public string Name {get; set;} = string.Empty;
        public int FactionId {get; set;}
        public Faction Faction {get; set;} = null!;
        public int BattleSize {get; set;} // 1000, 2000, or 3000 pts
        public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
        public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;
        public ICollection<ArmyListUnit> ArmyListUnits {get; set;} = new List<ArmyListUnit>();
    }
}