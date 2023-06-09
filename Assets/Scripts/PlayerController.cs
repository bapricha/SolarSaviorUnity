using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float jumpStrength;
    private Rigidbody2D rb;
    private PlayerControls controls;
    public float movement;
    public bool facingRight;
    private bool isGrounded;
    public static PlayerController instance;
    public Animator animator;

    private void Awake() {
        rb=GetComponent<Rigidbody2D>();
        controls = new PlayerControls();
        controls.Player.Movement.performed += ctx => movement = ctx.ReadValue<float>();
        controls.Player.Movement.canceled += _ => movement = 0;
        controls.Player.Jump.started += _ => Jump();
        facingRight = true;
        instance = this;
        animator = GetComponent<Animator>();
    }

    private void OnEnable() => controls.Enable();
    private void OnDisable() => controls.Disable();

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("movement", (int) movement);
        if(movement<0){
            transform.localScale = new Vector3(-1, 1, 1);
            facingRight = false;
        }
        else if(movement>0){
            transform.localScale = new Vector3(1, 1, 1);
            facingRight = true;
        }
            
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(movement*movementSpeed, rb.velocity.y);
    }

    private void Jump() {
        if(isGrounded) {
            rb.velocity = new Vector2(rb.velocity.x, jumpStrength);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground")) {
            isGrounded = false;
        }
    }

}
