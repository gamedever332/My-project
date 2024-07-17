using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromMenuToShop : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("Shop");
    }    
}
