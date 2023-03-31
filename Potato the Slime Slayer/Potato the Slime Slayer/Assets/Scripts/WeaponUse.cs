using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WeaponUse : MonoBehaviour, IPointerClickHandler
{
    public Text Weapon;
    private GameObject Player;

    public void OnPointerClick(PointerEventData eventData)
    {
        Player = GameObject.Find("Player"); 
        Player playerFromComponent = Player.GetComponent<Player>();

        int weaponCount = Int32.Parse(Weapon.text);

        if (weaponCount > 0)
        {
            Weapon.text = (weaponCount - 1).ToString();
            playerFromComponent.Strength++;
        }
        
        SaveSystem.SavePlayer(playerFromComponent);
    }
}
