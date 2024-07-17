using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public GameObject bullet;
    public float bspeed = 1.0f;

    void Update()
    {
        transform.position += new Vector3(0, 0, -bspeed) * Time.deltaTime;
        if (transform.position[2] < -140){
            Destroy(gameObject);
        }
    }
}
