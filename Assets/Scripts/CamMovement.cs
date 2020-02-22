using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    private Transform tf;
    public float movementSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        // Aim at the player at start
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, tf.position, movementSpeed * Time.deltaTime);
        // Always move forward
    }
}