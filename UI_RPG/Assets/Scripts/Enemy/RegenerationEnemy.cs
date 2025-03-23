using UnityEngine;

public class RegenerationEnemy : Enemy
{
    [SerializeField]
    private int regenerationAmount = 10; 
    [SerializeField]
    private float regenerationCooldown = 5f; 

    private float lastRegenerationTime = 0f;

    public override void GetHit(int damage)
    {
        lastRegenerationTime = Time.time;
        base.GetHit(damage);
    }

    
    public void RegenerateHealthAtRoundStart()
    {
        if (Time.time - lastRegenerationTime >= regenerationCooldown)
        {
            health += regenerationAmount;
            health = Mathf.Min(health, maxHealth); 
            Debug.Log($"{name} regenerated {regenerationAmount} health. Current health: {health}");

            lastRegenerationTime = Time.time; 
        }
    }
}