using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    void OnMouseDown(){
        PlayerInventory.CoinCount ++;
        Destroy(gameObject);
    }
}
