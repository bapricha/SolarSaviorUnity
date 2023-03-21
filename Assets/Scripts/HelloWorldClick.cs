using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class HelloWorldClick : MonoBehaviour
{
    public void OnHelloWorldClick() {
        SceneManager.LoadScene(1);
    }
}