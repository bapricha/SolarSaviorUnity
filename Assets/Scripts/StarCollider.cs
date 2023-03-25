using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollider : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collision){
        // if (collision.gameObject.CompareTag("Stars")){
        this.gameObject.SetActive(false);
        GameControlStars.starsCount++;// Instantiate(null, transform.position,transform.rotation);

        // }
        
    }
}
