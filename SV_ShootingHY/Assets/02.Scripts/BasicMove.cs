using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 4.5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
        transform.Rotate(new Vector3(0,0,Time.deltaTime*20));
    }
}
