using UnityEngine;

public enum SoldierType { Warrior, Archer }

[CreateAssetMenu(fileName = "NewSoldier", menuName = "Tower Defense/Soldier")]
public class SoldierData : ScriptableObject
{
    public SoldierType soldierType;
    public string soldierName;
    public float health;
    public float speed;
    public float damage;
    public float attackRange;
    public float attackSpeed;
    public float cost;
    public GameObject soldierPrefab;
}