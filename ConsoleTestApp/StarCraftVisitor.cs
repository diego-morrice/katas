
namespace Codes
{
   
    public interface IVisitor
    {
        void VisitLight(ILightUnit unit);
        void VisitArmored(IArmoredUnit unit);
    }

    public interface ILightUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }

    public interface IArmoredUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }

    public class Marine : ILightUnit
    {

        public Marine()
        {
            Health = 100;
        }

        public int Health { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }

    public class Marauder : IArmoredUnit
    {

        public Marauder()
        {
            Health = 125;
        }

        public int Health { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitArmored(this);
        }
    }

    public class TankBullet : IVisitor
    {
        public void VisitLight(ILightUnit unit)
        {
            unit.Health = unit.Health - 21;
        }

        public void VisitArmored(IArmoredUnit unit)
        {
            unit.Health = unit.Health - 32;
        }
    }
}
