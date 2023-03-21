using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsClick : MonoBehaviour
{
    private bool hidden;
    public GameObject nameText;
    
    void Start()
    {
        hidden = true;  
        nameText.SetActive(false);
    }
    public void OnCreditsClick() {
        if(hidden) {
            nameText.SetActive(true);
        }
        else {
            nameText.SetActive(false);
        }
        hidden = !hidden;
    }
}
