using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    [SerializeField] SoldierData soldierData;
    [SerializeField] float currentHP;
    float atkcooldown;

    void Start()
    {
        InitializeWarrior();
    }
    void InitializeWarrior()
    {
        currentHP = soldierData.health;
        atkcooldown = soldierData.attackSpeed;
    }

    void Update()
    {
        
    }
}
