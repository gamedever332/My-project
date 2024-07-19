using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take2Weapon : MonoBehaviour
{
    public void Use2Weapon(){
        if (Buy2Weapon.WeaponBuy == true){
            MonstersHealth.Damage = Upgrade2Weapon.SecondWeaponDamage;
            CoinsFromMonsters.Damage = Upgrade2Weapon.SecondWeaponDamage;
            Shooting.Recharge = 1.0f;
        }
    }
}
