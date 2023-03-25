using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class FinishLevel1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene(SceneOrganizer.BossLevel);
        
    }
}
