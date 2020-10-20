using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Weapon
  {
    public Weapon()
    {
      this.Monsters = new HashSet<MonsterWeapon>();
    }

    public int WeaponId { get; set; }
    public string WeaponName { get; set; }
    public string WeaponDescription { get; set; }
    public string WeaponSlot { set; get; }
    // public int WeaponClass { get; set; }
    // public string WeaponType { get; set; }
    // public string WeaponWorth { get; set; }
    // public int WeaponHp { get; set; }
    // public int WeaponLevel { get; set; }
    // public string WeaponStatus { get; set; }
    // public string WeaponFlags { get; set; }
    // public string WeaponRarity { get; set; }
    public virtual ICollection<MonsterWeapon> Monsters { get; set; }
  }
}
//slot,acBonus,type,name,Id,worth,Hp,level,status,flags,rarityA