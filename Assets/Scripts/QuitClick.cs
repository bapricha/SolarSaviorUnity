using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class QuitClick : MonoBehaviour
{
    public void OnQuitClick() {
        Application.Quit();
    }
}