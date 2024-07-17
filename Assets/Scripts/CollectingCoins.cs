using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int CoinCount = 0;
    void OnMouseDown(){
        CoinCount ++;
        Destroy(gameObject);
    }
}
