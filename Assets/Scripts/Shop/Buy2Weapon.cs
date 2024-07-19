using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy2Weapon : MonoBehaviour
{
    public static bool WeaponBuy = false;
    public GameObject UsedButton;

    public void Buy(){
        if (PlayerInventory.CoinCount >= 15){
            PlayerInventory.CoinCount -= 15;
            WeaponBuy = true;
        }
    }

    private void Update(){
        if (WeaponBuy == true){
            Destroy(gameObject);
        }
    }
}
