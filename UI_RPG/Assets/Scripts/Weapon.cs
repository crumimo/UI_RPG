using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
   [SerializeField] private int minDamage, maxDamage;


   public int GetDamage()
   {
      return Random.Range(minDamage, maxDamage);
   }
   
   public abstract void ApplyEffect(Character target);
}
