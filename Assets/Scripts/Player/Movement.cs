using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A) & transform.position[0] <= 89.5f){
            transform.position += new Vector3(0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) & transform.position[0] >= -41.7f){
            transform.position += new Vector3(-0.5f, 0, 0);
        }
    }
}
