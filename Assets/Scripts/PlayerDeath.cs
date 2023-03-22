using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Vector3 startPos;
    private Quaternion startRot;

    private void Awake() {
        startPos = transform.position;
        startRot = Quaternion.identity;
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Deadzone")) {
            transform.position=startPos;
            transform.rotation=startRot;
        }
    }
}
