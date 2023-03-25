using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class HelloWorldClick : MonoBehaviour
{
    public static int SceneIndex;
    public void OnHelloWorldClick() {
        SceneIndex = 0;
        SceneIndex++;
        SceneManager.LoadScene(SceneIndex);
    }
}