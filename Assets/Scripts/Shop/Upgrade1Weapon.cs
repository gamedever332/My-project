using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade1Weapon : MonoBehaviour
{
    public static int FirstWeaponDamage = 10;
    public GameObject UsedButton;

    public void MakeUpgrade(){
        if (PlayerInventory.CoinCount >= 5 & PlayerInventory.LvlOf1Weapon < 10){
            PlayerInventory.CoinCount -= 5;
            FirstWeaponDamage ++;
            MonstersHealth.Damage = FirstWeaponDamage;
            CoinsFromMonsters.Damage = FirstWeaponDamage;
            PlayerInventory.LvlOf1Weapon ++;
        }
    }
    
    public void Update(){
        if (PlayerInventory.LvlOf1Weapon == 10){
            Destroy(gameObject);
            Instantiate(UsedButton, transform.position, Quaternion.identity);
        }
    }
}
