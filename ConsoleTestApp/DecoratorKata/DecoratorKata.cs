
namespace ConsoleTestApp.DecoratorKata
{
    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarineWeaponUpgrade : IMarine
    {
        private IMarine marine;

        public MarineWeaponUpgrade(IMarine marine)
        {
            Armor = marine.Armor;
            Damage = marine.Damage;

            Damage++;

        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }

    public class MarineArmorUpgrade : IMarine
    {
        private IMarine marine;

        public MarineArmorUpgrade(IMarine marine)
        {
            Armor = marine.Armor;
            Damage = marine.Damage;

            Armor++;
        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }
}
