namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Unit
    {
        public int BaseAtk { get; protected set; }
        public int BaseDef { get; protected set; }
        public int BaseSpd { get; protected set; }

        public int MoveRange { get; protected set; }
        public int AtkRange { get; protected set; }

        public float BaseAtkAdd { get; protected set; }
        public float BaseDefAdd { get; protected set; }
        public float BaseSpdAdd { get; protected set; }

        public float Attack { get; }
        public float Defense { get; }
        public float Speed { get; }

        protected Position CurrentPosition;

        public EUnitClass UnitClass { get; protected set; }

        public Unit(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange)
        {
            UnitClass = _unitClass;
            BaseAtk = _atk;
            BaseDef = _def;
            BaseSpd = _spd;
            MoveRange = _moveRange;

        }

        public virtual bool Interact(Unit otherUnit)
        {
            bool cambio = false;

            if (UnitClass == EUnitClass.Villager)
            {
                cambio = false;
            }
            else if (UnitClass == EUnitClass.Soldier && otherUnit.UnitClass == EUnitClass.Villager)
            {
                cambio = false;
            }
            else if (UnitClass == EUnitClass.Squire && otherUnit.UnitClass == EUnitClass.Villager)
            {
                cambio = false;
            }
            else if (UnitClass == EUnitClass.Ranger && otherUnit.UnitClass == EUnitClass.Mage)
            {
                cambio = false;
            }
            else if (UnitClass == EUnitClass.Mage && otherUnit.UnitClass == EUnitClass.Mage)
            {
                cambio = false;
            }
            else if (UnitClass == EUnitClass.Imp && otherUnit.UnitClass == EUnitClass.Dragon)
            {
                cambio = false;
            }
            else if (UnitClass == EUnitClass.Orc && otherUnit.UnitClass == EUnitClass.Dragon)
            {
                cambio = false;
            }
            else cambio = true;            
              
            return cambio;

            
        }

        public virtual bool Interact(Prop prop)
        {
            bool cambio = false;

            if(UnitClass == EUnitClass.Villager)
            {
                cambio = true;
            }

            return cambio;
        }

        public bool Move(Position targetPosition)
        {
            bool mover = false;

            int sumaT = targetPosition.x + targetPosition.y;
            int sumaC = CurrentPosition.x + CurrentPosition.y;

            if (CurrentPosition.x == targetPosition.x && CurrentPosition.y == targetPosition.y)
            {
                mover = false;
            }
            else if (sumaC + MoveRange >= sumaT)
            {
                mover = true;
                CurrentPosition = targetPosition;
            }

            return mover;
        }
        
        
    }
}