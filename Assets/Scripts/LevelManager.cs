using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //this script is useless but I'm keeping it just in case
    public static LevelManager instance;
    public Transform respawnPoint;
    public GameObject playerPrefab;
    private Vector3 startPos;

    private void Awake() {
        instance = this;
        startPos = transform.position;
    }
    public void Respawn() {
        //Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        transform.position=startPos;
    }
}
