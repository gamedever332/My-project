using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public void OpenMenu(){
        SceneManager.LoadScene("Menu");
    }

    private void Update(){
        if (transform.position[2] > 1.5f){
            OpenMenu();
        }
    }

    public void Start(){
        Debug.Log("You can upgrade your weapon on the shop or start a new game");
    }
}
