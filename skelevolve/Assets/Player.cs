using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float movespeed = 5f;
    public Rigidbody2D rb;
    /*private float moveH;
    private float moveV;*/
    public SpriteRenderer sr;

    private Vector2 playerMovement;

    private Vector2 lastDirect = Vector2.up;
    public Animator an;


    // Update is called once per frame
    void Update()

    {
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerMovement = playerMovement.normalized;
        rb.MovePosition(rb.position + playerMovement * movespeed * Time.fixedDeltaTime);

        an.SetBool("Forward", Input.GetKey(KeyCode.W));
        an.SetBool("Left", Input.GetKey(KeyCode.A));
        an.SetBool("Right", Input.GetKey(KeyCode.D));
        an.SetBool("Backward", Input.GetKey(KeyCode.S));
        an.SetBool("Movement", playerMovement != Vector2.zero);

    }
}
