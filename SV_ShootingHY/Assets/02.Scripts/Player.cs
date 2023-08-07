using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5;
    public Vector2 moveInput;
    public Vector2 playerMinToMax(Transform Max)
    {
        return Camera.main.ScreenToWorldPoint(Max.position);
    }
    public Transform MaxMinUI;
    public Vector3 MaxSave;
    // Start is called before the first frame update

    private void Reset()
    {
        rb = GetComponent<Rigidbody2D>();
        MaxMinUI = GameObject.Find("Max").transform;
        MaxSave = playerMinToMax(MaxMinUI);
    }
    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x < MaxSave.x && transform.position.x > -MaxSave.x)|| transform.position.y < MaxSave.y && transform.position.y > -MaxSave.y)
        {
            rb.velocity = moveInput * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0)
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        }
        else
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }
}
