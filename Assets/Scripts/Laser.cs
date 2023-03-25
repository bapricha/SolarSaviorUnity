using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerController;

public class Laser : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(PlayerController.instance.facingRight == false) {
            rb.velocity=transform.right*speed * -1; 
        } else if(PlayerController.instance.facingRight == true) {
            rb.velocity=transform.right*speed * 1; 
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision){

        Instantiate(null, transform.position,transform.rotation);
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
