using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    [SerializeField]
    private GameObject purpleParticles;

    public void TakeDamage(float damage){
        // health -= damage;
        if (health <= 0){
            Instantiate(purpleParticles,transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
