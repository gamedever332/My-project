using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2Weapon : MonoBehaviour
{
    public static int SecondWeaponDamage = 25;
    public GameObject UsedButton;

    public void MakeUpgrade(){
        if (PlayerInventory.CoinCount >= 5 & PlayerInventory.LvlOf2Weapon < 25 & Buy2Weapon.WeaponBuy == true){
            PlayerInventory.CoinCount -= 5;
            SecondWeaponDamage ++;
            MonstersHealth.Damage = SecondWeaponDamage;
            CoinsFromMonsters.Damage = SecondWeaponDamage;
            PlayerInventory.LvlOf2Weapon ++;
        }
    }
    
    public void Update(){
        if (PlayerInventory.LvlOf2Weapon == 25){
            Destroy(gameObject);
            Instantiate(UsedButton, transform.position, Quaternion.identity);
        }
    }
}
