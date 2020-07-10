public class OnEquipmentEquippedArgs
{
    public OnEquipmentEquippedArgs(Equipment equipment) { Equipment = equipment; }
    Equipment Equipment { get; } // readonly
}
