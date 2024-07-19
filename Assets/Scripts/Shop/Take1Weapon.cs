using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take1Weapon : MonoBehaviour
{
    public void Use1Weapon(){
        MonstersHealth.Damage = Upgrade1Weapon.FirstWeaponDamage;
        CoinsFromMonsters.Damage = Upgrade1Weapon.FirstWeaponDamage;
        Shooting.Recharge = 0.0f;
    }
}
