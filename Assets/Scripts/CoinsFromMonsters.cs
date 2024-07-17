using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsFromMonsters : MonoBehaviour
{
    public GameObject coin;
    public float health = 100.0f;
    public float damage = 10.0f;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject != gameObject){
            health -= damage;
            Destroy(other.gameObject);
        }
    }

    private void Update(){
        if (health <= 0){
            Instantiate(coin, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("Enemy was destroyed!");
        }
    }
}
