namespace backend.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public int FactionId { get; set; }
        public Faction Faction { get; set; } = null!;
        public string? ExternalSlug { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PointsCost { get; set; }
        public int ModelCount { get; set; } = 1;
        public int Movement { get; set; }
        public int Toughness { get; set; }
        public int ArmorSave { get; set; }
        public int? InvulnSave { get; set; }
        public int Wounds { get; set; }
        public int Leadership { get; set; }
        public int ObjectiveControl { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}