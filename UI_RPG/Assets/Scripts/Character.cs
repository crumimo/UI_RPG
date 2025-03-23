using UnityEngine;

public class Character : MonoBehaviour
{
    public int health; 
    public int maxHealth; 
    public string CharName;  
    [SerializeField] private Weapon weapon;

    public Weapon Weapon => weapon;

    public virtual int Shout()
    {
        return weapon.GetDamage();
    }

    public virtual void GetHit(int damage)
    {
        health -= damage;
        health = Mathf.Max(health, 0); 
    }

    public void GetHit(Weapon weapon)
    {
        Debug.Log(name + " starting health: " + health);
        health -= weapon.GetDamage();
        Debug.Log(name + " after getting hit by " + weapon.name + ": " + health);
    }
}