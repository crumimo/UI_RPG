using UnityEngine;

public class Enemy : Character
{
    [SerializeField] 
    protected int agression = 5;

    private int initialHealth; // To store the original health value

    private void Awake()
    {
        initialHealth = health; // Save initial health on start
    }

    public void ResetStats()
    {
        health = initialHealth; // Reset health to the original value
        agression = 5; // Reset aggression (optional)
    }
}
