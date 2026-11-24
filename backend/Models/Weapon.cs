namespace backend.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string WeaponType { get; set; } = "Melee"; // "Ranged" or "Melee", defaulted to "Melee".
        public string RangeWeapon { get; set; } = "Melee"; // "Melee" or number of inches, defaulted to "Melee".
        public string Attacks { get; set; } = "1"; // A number or "[x]D[y]", where x is the number of dice to roll, with face value divided by y, defaulted to "1".
        public int WBSkill { get; set; }
        public int Strength { get; set; }
        public int ArmorPenetration { get; set; }
        public string Damage { get; set; } = "1"; // number or "[x]D[y]" where x is the number of dice to roll, with face value divided by y, defaulted to "1".
        public string? Keywords { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}