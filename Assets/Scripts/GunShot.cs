using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed = 60.0f;

    void Update()
    {
        transform.position += new Vector3(0, 0, -BulletSpeed) * Time.deltaTime;
        if (transform.position[2] < -140){
            Destroy(gameObject);
        }
    }
}
