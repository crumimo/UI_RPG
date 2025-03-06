using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public  Player player;
    public Enemy enemy;
    public Character character;
    void Start()
    {
        player.Shout();
        enemy.Shout();
        character.Shout();
        
        Debug.Log("player name: " + player.CharName);
    }

    
}
