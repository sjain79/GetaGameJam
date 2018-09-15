using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    Rigidbody2D myRigidbody;

    [SerializeField]
    float speedFactor;

    private void Awake()
    {

        myRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        myRigidbody.velocity = new Vector2(Input.GetAxis("Horizontal")*speedFactor, 0);

        if (transform.position.x< -9.396702f)
        {
            transform.position = new Vector2(9.396702f, transform.position.y);
        }
        else if (transform.position.x > 9.396702f)
        {
            transform.position = new Vector2(-9.396702f, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name== "Ball")
        {
            
        }
    }


}
