using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;
    public static float Recharge = 0.0f;
    private float LastShotTime = 0.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && (Time.time - LastShotTime) >= Recharge){
            GameObject Clone = Instantiate(Bullet, transform.position, transform.rotation);
            Clone.gameObject.transform.localScale = new Vector3(7.0f, 7.0f, 7.0f);
            LastShotTime = Time.time;
        }
    }
}
