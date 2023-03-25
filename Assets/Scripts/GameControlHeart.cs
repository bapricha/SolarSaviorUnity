using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameControlHeart : MonoBehaviour
{
    public GameObject Heart1, Heart2, Heart3;
    public static int health;
    // SceneOrganizer so = new SceneOrganizer();

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3){
            health = 3;
        } else if (health < 0) {
            health = 0;
        }

        switch(health){
            case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;
            case 2:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(false);
                break;
            case 1:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                break;
            case 0:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                // Debug.Log(so.GameOverIndex);
                SceneManager.LoadScene(SceneOrganizer.GameOverIndex);
                break;                            
        }
    }
}
