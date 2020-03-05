using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : Pawn
{
    private Transform tf;
    public float rotationSpeed = 1.0f;
    public float movementSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
        Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position += tf.right * -movementSpeed * Time.deltaTime;
        }
    }

    public override void Attack()
    {
        Debug.Log("Player Attack");
        //base.Attack();
    }

    // If we want movement for the player to be very different
    // We can override our Move function...but we probably don't
}
