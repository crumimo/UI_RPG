using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    [SerializeField] private string charName;
    [SerializeField] private List<Weapon> availableWeapons;
    [SerializeField] private Button[] weaponButtons;
    [SerializeField] private Shield shield;
    private Weapon currentWeapon;

    public string CharName => charName;

    void Start()
    {
        for (int i = 0; i < weaponButtons.Length; i++)
        {
            int index = i;
            weaponButtons[i].onClick.AddListener(() => SelectWeapon(index));
        }

        if (availableWeapons.Count > 0)
        {
            SelectWeapon(0);
        }
    }

    public void SelectWeapon(int index)
    {
        if (currentWeapon == availableWeapons[index]) return;

        currentWeapon = availableWeapons[index];

        for (int i = 0; i < weaponButtons.Length; i++)
        {
            weaponButtons[i].image.color = Color.red;
        }

        weaponButtons[index].image.color = Color.green;

        Debug.Log($"{currentWeapon.name} has been selected!");
    }

    public void Attack()
    {
        if (currentWeapon != null)
        {
            currentWeapon.ApplyEffect(this);
        }
    }

    public void ToggleShield()
    {
        shield.Toggle();
    }

    public bool IsShieldActive()
    {
        return shield.IsActive;
    }

    public int GetDamageReduction()
    {
        return shield.GetDamageReduction();
    }

    public override void GetHit(int damage)
    {
        int finalDamage = damage - GetDamageReduction();
        base.GetHit(finalDamage);

        if (shield.TryBreak())
        {
            Debug.Log("Shield broke!");
            FindObjectOfType<GameManager>().OnShieldBreak();
        }
    }
}