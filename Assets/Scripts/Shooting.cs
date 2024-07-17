using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            GameObject Clone = Instantiate(Bullet, transform.position, transform.rotation);
            Clone.gameObject.transform.localScale = new Vector3(7.0f, 7.0f, 7.0f);
            
        }
    }
}
