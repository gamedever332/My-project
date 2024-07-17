using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            GameObject clone = Instantiate(bullet, transform.position, transform.rotation);
            clone.gameObject.transform.localScale = new Vector3(7.0f, 7.0f, 7.0f);
            
        }
    }
}
