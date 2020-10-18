using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public SpriteRenderer thisSprite;
    public Rigidbody2D thisRigidbody2D;
    public float force = 10f;
    public GroundCheck2 groundCheckScript;
    public float gravityInAir;
    public Animator thisAnimator;
    public AudioSource Sounds;
    public AudioClip jumpSound;

    void Start()
    {

    }

    void Update()
    {
        if (groundCheckScript.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Sounds.PlayOneShot(jumpSound);
                thisRigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            }

            thisRigidbody2D.gravityScale = 0;
        }
     
        if (groundCheckScript.isGrounded == false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            thisAnimator.SetFloat("Horizontal", 0f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            thisAnimator.SetFloat("Horizontal", 0f);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            thisAnimator.SetFloat("Horizontal",1f); 
            thisRigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == true)
            {
                thisSprite.flipX = false;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            thisAnimator.SetFloat("Horizontal", 1f);
            thisRigidbody2D.AddForce(-Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == false)
            {
                thisSprite.flipX = true;
            }
        }

    }

    
}