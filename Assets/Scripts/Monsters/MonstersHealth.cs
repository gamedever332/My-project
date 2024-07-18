using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersHealth : MonoBehaviour
{
    public float Health = 100.0f;
    public static float Damage = 10.0f;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject != gameObject){
            Health -= Damage;
            Destroy(other.gameObject);
        }
    }

    private void Update(){
        if (Health <= 0){
            Destroy(gameObject);
        }
    }
}
