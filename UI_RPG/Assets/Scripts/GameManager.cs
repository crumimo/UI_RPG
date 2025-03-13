using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyHealth;

    void Start()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.name;
        UpdateHealth();
    }
    
    public void DoRound()
    {
        //int damage = player.Shout();
        enemy.GetHit(player.Weapon);
        player.Weapon.ApplyEffect(enemy);

        int enemyDamage = enemy.Shout();
        player.GetHit(enemyDamage);
        enemy.Weapon.ApplyEffect(player);
        
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        playerHealth.text = player.health.ToString();
        enemyHealth.text = enemy.health.ToString();
    }
}
