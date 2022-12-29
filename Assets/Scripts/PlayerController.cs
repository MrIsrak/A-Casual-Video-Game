using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private int speed;

    [SerializeField] private int jump;

    private bool ground;

    private Animator anim;

    private Rigidbody2D rb;

    [SerializeField] private int direction;


    private void Start()
    {
        anim = GetComponent<Animator> ();
        rb = GetComponent<Rigidbody2D> ();
    }

    
    private void Update()
    {
        rb.velocity = new Vector2 (direction * speed, rb.velocity.y);
        if (direction != 0)
            anim.SetBool ("Walk", true);
        else if (direction == 0 )
            anim.SetBool ("Walk", false);
        if (direction >= 0.5f)
            Jump();

    }

    public void Jump()
    {
        rb.AddForce (transform.up * jump, ForceMode2D.Impulse); 
    }
}
