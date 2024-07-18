using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade1Weapon : MonoBehaviour
{
    public static int FirstWeaponDamage = 10;
    public GameObject UsedButton;

    public void MakeUpgrade(){
        if (PlayerInventory.CoinCount >= 5 & PlayerInventory.LvlOfWeapon < 10){
            PlayerInventory.CoinCount -= 5;
            FirstWeaponDamage ++;
            MonstersHealth.Damage = Upgrade1Weapon.FirstWeaponDamage;
            CoinsFromMonsters.Damage = Upgrade1Weapon.FirstWeaponDamage;
            PlayerInventory.LvlOfWeapon ++;
        }
    }
    
    public void Update(){
        if (PlayerInventory.LvlOfWeapon == 10){
            Destroy(gameObject);
            Instantiate(UsedButton, transform.position, Quaternion.identity);
        }
    }
}
