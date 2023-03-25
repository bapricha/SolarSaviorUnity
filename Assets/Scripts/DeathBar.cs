using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBar : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        GameControlHeart.health -= 3;
    }
}
