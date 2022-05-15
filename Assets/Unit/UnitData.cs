using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "Data/Unit", order = 51)]
public class UnitData : ScriptableObject
{
    [SerializeField]
    private string unitName;
    [SerializeField]
    private string description;
    [SerializeField]
    private int damage;
    [SerializeField]
    private int move;
}
