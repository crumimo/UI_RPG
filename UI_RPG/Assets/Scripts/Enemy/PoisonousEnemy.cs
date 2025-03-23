using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonousEnemy : Enemy
{
    [SerializeField] private int poisonStrengthIncrease = 2;
    private int currentPoisonStrength = 3;

    public override int Shout()
    {
        // Возвращаем урон плюс сила яда, которая увеличивается с каждым раундом
        int damage = Weapon.GetDamage();
        int poisonDamage = currentPoisonStrength;
        currentPoisonStrength += poisonStrengthIncrease; // Увеличиваем силу яда
        Debug.Log($"PoisonousEnemy deals {poisonDamage} poison damage");
        return damage + poisonDamage;
    }
}