using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{
    public GameObject[] planet;
    Rigidbody2D rb;
    public float gravityForce;
    public float gravityDistance;
    float lookAngle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject g in planet) {
            float dist = Vector3.Distance(gameObject.transform.position, g.transform.position);
            if(dist<8) {
              Vector3 v = g.transform.position - transform.position;
              //rb.AddForce(v.normalized*(1.0f-dist/gravityDistance)*gravityForce);
              rb.AddForce(v.normalized*(gravityForce/dist));
              lookAngle=90+Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
              transform.rotation=Quaternion.Euler(0f, 0f, lookAngle);
            }
        }
    }
}
