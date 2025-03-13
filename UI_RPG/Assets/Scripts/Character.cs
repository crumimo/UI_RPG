using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon weapon;

    public Weapon Weapon
    {
        get { return weapon; }
    }

    public virtual int Shout()
    {
        return weapon.GetDamage();
    }

    public void GetHit(int damage)
    {
        Debug.Log(name + " startingHealth: " + health);
        health -= damage;
        Debug.Log(name + " Health after hit: " + health);
    }

    public void GetHit(Weapon weapon)
    {
        Debug.Log(name + " startingHealth: " + health);
        health -= weapon.GetDamage();
        Debug.Log(" after getting hit by " + weapon.name+ ":" + health);
        
    }
}
