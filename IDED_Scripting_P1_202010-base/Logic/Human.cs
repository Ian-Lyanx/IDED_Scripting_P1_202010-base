namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential)
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            Potential = _potential;

            if(_potential > 0.1f)
            {
                _potential = 0.1f;
            }

            if(UnitClass == EUnitClass.Dragon || UnitClass == EUnitClass.Orc || UnitClass == EUnitClass.Imp)
            {
                UnitClass = EUnitClass.Villager;
                _atk = 0;
                _def = 0;
                _spd = 0;
            }
        }

        public virtual bool ChangeClass(EUnitClass newClass)
        {
            bool cambio = false;

            if (newClass == EUnitClass.Dragon || newClass == EUnitClass.Imp || newClass == EUnitClass.Orc || UnitClass == newClass || UnitClass == EUnitClass.Villager)
            {
                cambio = false;
            }
            else if ((UnitClass == EUnitClass.Soldier && newClass != EUnitClass.Squire) || (UnitClass == EUnitClass.Squire && newClass != EUnitClass.Soldier))
            {
                cambio = false;
            }
            else if ((UnitClass == EUnitClass.Ranger && newClass != EUnitClass.Mage) || (UnitClass == EUnitClass.Mage && newClass != EUnitClass.Ranger))
            {
                cambio = false;
            }
            else 
            {
                cambio = true;
            }

           return cambio;
        }
    }
}