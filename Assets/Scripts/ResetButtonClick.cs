using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class ResetButtonClick : MonoBehaviour
{
    public void OnResetButtonClick() {
        SceneManager.LoadScene(HelloWorldClick.SceneIndex);
    }
}