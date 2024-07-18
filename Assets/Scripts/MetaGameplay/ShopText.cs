using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ShopText : MonoBehaviour
{
    public TextMeshProUGUI MyText;
    void Update(){
        MyText.text = PlayerInventory.CoinCount.ToString();
    }
}
