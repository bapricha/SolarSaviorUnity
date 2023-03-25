using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerController;

public class Laser : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public GameObject GreenLaser;

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

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ground")){
            Destroy(this.gameObject);
            Instantiate(null, transform.position,transform.rotation);

        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
