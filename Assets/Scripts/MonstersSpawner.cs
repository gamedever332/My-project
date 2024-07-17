using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject Monster;
    public GameObject MonsterWithC;
    private float PauseDuration = 5.0f;
    private float PauseTimer = 0.0f;
    private int MonsterWithCoinsInterval = 0;

    void Update(){
        if (PauseTimer < PauseDuration){
            PauseTimer += Time.deltaTime;
        }
        else{
            int CountOfMonsters = UnityEngine.Random.Range(1, 5), i = 0;
            float[] Cells = new float[] { -15.7f, 4.79f, 25.33f, 46.0f, 66.51f};
            while (i < CountOfMonsters){
                int MonsterPos = UnityEngine.Random.Range(1, 6) - 1;
                if (Cells[MonsterPos] != 0 & MonsterWithCoinsInterval != 5){
                    Instantiate(Monster, new Vector3(Cells[MonsterPos], -4.619827f, -117.9683f), Quaternion.identity);
                    MonsterWithCoinsInterval ++;
                    Cells[MonsterPos] = 0;
                    i++;
                }
                else if (Cells[MonsterPos] != 0){
                    Instantiate(MonsterWithC, new Vector3(Cells[MonsterPos], -4.619827f, -117.9683f), Quaternion.identity);
                    MonsterWithCoinsInterval = 0;
                    i++;
                }
            }
            PauseTimer = 0.0f;
        }
    } 
}
