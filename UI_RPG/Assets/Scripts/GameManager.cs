using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // Add this directive

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy[] enemyPrefabs; // Array of enemy prefabs
    private Enemy currentEnemy;

    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyHealth;
    [SerializeField] private ShieldButton shieldButton;

    void Start()
    {
        // Set player's name and health on UI
        playerName.text = player.CharName;
        playerHealth.text = player.health.ToString(); // Show player's health immediately
        SpawnNewEnemy(); // Create the first enemy
    }

    public void DoRound()
    {
        // Interact with the enemy
        int damage = player.Shout();
        currentEnemy.GetHit(damage); // Enemy takes damage from the player

        // Apply player's weapon effect (if the weapon restores health)
        player.Weapon.ApplyEffect(currentEnemy); // Apply weapon effect to the enemy

        // Enemy's counterattack
        int enemyDamage = currentEnemy.Shout();
        player.GetHit(enemyDamage); // Player takes damage from the enemy

        // Apply enemy's weapon effect (if the enemy has a weapon that deals damage or heals)
        currentEnemy.Weapon.ApplyEffect(player); // Apply weapon effect to the player (if any)

        // Update health on UI
        UpdateHealthUI();

        // If the enemy is dead, spawn a new one
        if (currentEnemy.health <= 0)
        {
            Destroy(currentEnemy.gameObject); // Destroy the defeated enemy
            SpawnNewEnemy();
        }

        // If the player is dead, restart the scene
        if (player.health <= 0)
        {
            RestartScene();
        }
    }

    public void SpawnNewEnemy()
    {
        // Randomly select an enemy from the array of enemies
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        Enemy newEnemy = Instantiate(enemyPrefabs[randomIndex]);

        // Set the enemy's health through the inspector in Unity,
        // and ResetStats() can be used if you need to reset health when respawning an enemy.
        newEnemy.ResetStats();

        currentEnemy = newEnemy;

        // Update enemy's name on UI without "(Clone)"
        enemyName.text = currentEnemy.name.Replace("(Clone)", ""); // Remove "(Clone)" suffix from enemy's name

        enemyHealth.text = currentEnemy.health.ToString(); // Update enemy's health on UI
    }

    private void UpdateHealthUI()
    {
        playerHealth.text = player.health.ToString(); // Update player's health on UI
        enemyHealth.text = currentEnemy.health.ToString(); // Update enemy's health on UI
    }

    public void OnShieldBreak()
    {
        shieldButton.DisableButton();
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }
}