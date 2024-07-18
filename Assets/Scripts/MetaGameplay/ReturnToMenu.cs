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
}
