namespace backend.Models
{
    public class ArmyListUnit
    {
        public int Id { get; set;}
        public int ArmyListId{ get; set;}
        public ArmyList ArmyList {get; set;} = null!;
        public int UnitId {get; set;}
        public Unit Unit {get; set;} = null!;
        public int Quantity {get; set;} = 1;
    }
}