using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    void Update(){
        transform.position += new Vector3 (0.0f, 0.00f, 0.07f);
    }
}
