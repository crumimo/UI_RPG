using UnityEngine;
using UnityEngine.UI;

public class ShieldButton : MonoBehaviour
{
    public Player player;
    public Button button;
    public Color activeColor = Color.green;
    public Color inactiveColor = Color.red;

    private void Start()
    {
        button.onClick.AddListener(ToggleShield);
        UpdateButtonColor();
    }

    private void ToggleShield()
    {
        player.ToggleShield();
        UpdateButtonColor();
    }

    private void UpdateButtonColor()
    {
        ColorBlock colors = button.colors;
        colors.normalColor = player.IsShieldActive() ? activeColor : inactiveColor;
        button.colors = colors;
    }

    public void DisableButton()
    {
        button.interactable = false;
        ColorBlock colors = button.colors;
        colors.normalColor = Color.gray;
        button.colors = colors;
    }
}