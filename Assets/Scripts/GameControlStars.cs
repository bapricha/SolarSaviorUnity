using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlStars : MonoBehaviour
{
    public GameObject Star1, Star2, Star3;
    public static int starsCount;

    // Start is called before the first frame update
    void Start()
    {
        starsCount = 0;
        Star1.gameObject.SetActive(true);
        Star2.gameObject.SetActive(true);
        Star3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (starsCount < 0){
            starsCount = 0;
        }

        switch(starsCount){
            case 3:
                Star1.gameObject.SetActive(true);
                Star2.gameObject.SetActive(true);
                Star3.gameObject.SetActive(true);
                break;
            case 2:
                Star1.gameObject.SetActive(true);
                Star2.gameObject.SetActive(true);
                Star3.gameObject.SetActive(false);
                break;
            case 1:
                Star1.gameObject.SetActive(true);
                Star2.gameObject.SetActive(false);
                Star3.gameObject.SetActive(false);
                break;
            case 0:
                Star1.gameObject.SetActive(false);
                Star2.gameObject.SetActive(false);
                Star3.gameObject.SetActive(false);
                // Time.timeScale = 0;
                break;                            
        }
    }
}
