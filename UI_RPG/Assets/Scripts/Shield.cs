using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private int damageReduction = 5;
    [SerializeField] private float breakChance = 0.1f; // 10% chance to break
    public bool IsActive { get; private set; } = false;

    public void Toggle()
    {
        IsActive = !IsActive;
    }

    public int GetDamageReduction()
    {
        return IsActive ? damageReduction : 0;
    }

    public bool TryBreak()
    {
        if (IsActive && Random.value < breakChance)
        {
            IsActive = false;
            return true;
        }
        return false;
    }
}