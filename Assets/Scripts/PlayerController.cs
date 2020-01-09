using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpforce;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool jump = false;
    private Animator anim;
    private bool onground = false;
    private Transform groundCheck;
    private AudioController _audioController;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        groundCheck = gameObject.transform.Find("GroundCheck");
        _audioController = GameObject.Find("SoundEffects").GetComponent<AudioController>();

    }

    // Update is called once per frame
    void Update()
    {
        onground = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if(Input.GetButtonDown("Jump") && onground)
        {
            jump = true;
            anim.SetTrigger("isJumping");
            _audioController.playSound(0);
        }

        if (transform.position.x < -11.8f)
        {
            transform.position = new Vector3(-11.8f, transform.position.y, 0);
        }
        else if (transform.position.x > 160.75f)
        {
            transform.position = new Vector3(160.75f, transform.position.y, 0);
        }

    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("speed", Mathf.Abs(h));

        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        if(h>0 && !facingRight)
        {
            Flip();
        }
        else if(h < 0 && facingRight)
        {
            Flip();
        }

        if (jump)
        {
            rb.AddForce(new Vector2(0, jumpforce));
            jump = false;
        }
     
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
         if (other.gameObject.tag == "MovingPlatform")
        {
            this.transform.parent = other.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "MovingPlatform")
        {
            this.transform.parent = null;
        }
    }
    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
   
}
