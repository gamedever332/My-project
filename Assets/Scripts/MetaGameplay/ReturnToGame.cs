using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToGame : MonoBehaviour
{
    public string Scene;

    public void LoadScene(){
        SceneManager.LoadScene(Scene);
    }
}
