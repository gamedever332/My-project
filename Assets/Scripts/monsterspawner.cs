using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterspawner : MonoBehaviour
{
    public GameObject monster;
    public GameObject monsterWithc;
    private float pauseDuration = 5.0f;
    private float pauseTimer = 0.0f;
    private int monsterWithCoinsInterval = 0;

    void Update(){
        if (pauseTimer < pauseDuration){
            pauseTimer += Time.deltaTime;
        }
        else{
            int countOfMonsters = UnityEngine.Random.Range(1, 5), i = 0;
            float[] cells = new float[] { -15.7f, 4.79f, 25.33f, 46.0f, 66.51f};
            while (i < countOfMonsters){
                int monsterpos = UnityEngine.Random.Range(1, 6) - 1;
                if (cells[monsterpos] != 0 & monsterWithCoinsInterval != 5){
                    Instantiate(monster, new Vector3(cells[monsterpos], -4.619827f, -117.9683f), Quaternion.identity);
                    monsterWithCoinsInterval ++;
                    cells[monsterpos] = 0;
                    i++;
                }
                else if (cells[monsterpos] != 0){
                    Instantiate(monsterWithc, new Vector3(cells[monsterpos], -4.619827f, -117.9683f), Quaternion.identity);
                    monsterWithCoinsInterval = 0;
                    i++;
                }
            }
            pauseTimer = 0.0f;
        }
    } 
}
