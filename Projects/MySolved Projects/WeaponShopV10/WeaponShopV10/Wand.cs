namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Wand. A Wand is 
    /// considered to be a weapon.
    /// </summary>
    public class Wand : Weapon
    {
        public const int InitialWandMinDamage = 10;
        public const int InitialWandMaxDamage = 30;
        public bool IsEnchanted { get; set; }

        #region Constructor
        public Wand(string description) 
            : base(description, InitialWandMinDamage, InitialWandMaxDamage)
        {
        }

        public int DamageFromWand()
        {
            if (IsEnchanted)
            {
                return CalculateDamage() * 2;
            }
            else
            {
                return CalculateDamage();
            }
        }
        #endregion
    }
}