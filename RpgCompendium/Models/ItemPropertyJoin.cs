namespace RpgCompendium.Models
{
  public class ItemPropertyJoin
  {
    public int ItemPropertyJoinId { get; set; }
    public int? ArmorId { get; set; }
    public int? WeaponId { get; set; }
    // public string ArmorSlot { get; set; }
    public virtual Armor Armor { get; set; }
    public virtual Weapon Weapon { get; set; }
  }
}