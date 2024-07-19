using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsFromMonsters : MonoBehaviour
{
    public GameObject Coin;
    public float Health = 150.0f;
    public static float Damage = 10.0f;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject != gameObject){
            Health -= Damage;
            Destroy(other.gameObject);
        }
    }

    private void Update(){
        if (Health <= 0){
            Instantiate(Coin, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
