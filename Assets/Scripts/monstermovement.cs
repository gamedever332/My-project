using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstermovement : MonoBehaviour
{
    void Update(){
        transform.position += new Vector3 (0.0f, 0.00f, 0.05f);
    }
}
