using UnityEngine;

public class HealingWeapon : Weapon
{
    [SerializeField] private int healingAmount = 10; 
    [SerializeField] private bool isHealingWeapon = true; 

    public override void ApplyEffect(Character target)
    {
        if (isHealingWeapon)
        {
            HealOwner(target);
        }
    }

    private void HealOwner(Character target)
    {
        Player player = target as Player;
        if (player != null)
        {
            player.health += healingAmount;
            
            player.health = Mathf.Min(player.health, player.maxHealth);

            Debug.Log($"{player.CharName} healed for {healingAmount} health. Current health: {player.health}");
        }
    }
}