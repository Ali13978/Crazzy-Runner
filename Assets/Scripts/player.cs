using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour
{
    // Config
    [SerializeField] float MovementSpeed = 5f;
    [SerializeField] int JumpSpeed = 5;
    [SerializeField] int JumpDownSpeed = 5;

    bool Abc = true;
    // States
  // Cache
    Rigidbody2D MyRigidBody;
    Animator MyAnimator;
    BoxCollider2D MyBoxCollider;
    CapsuleCollider2D MyCapsuleCollider;

    private void Start()
    {
        MyAnimator = GetComponent<Animator>();
        MyRigidBody = GetComponent<Rigidbody2D>();
        MyBoxCollider = GetComponent<BoxCollider2D>();
        MyCapsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    private void Jump()
    {
        if (!MyBoxCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector2 JumpVelocity = new Vector2(0f, JumpDownSpeed);
                MyRigidBody.velocity -= JumpVelocity;
            }
            return;
        }
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<AudioSource>().Play();
            Vector2 JumpVelocity = new Vector2(0f, JumpSpeed);
            MyRigidBody.velocity += JumpVelocity;
        }
    }

    private void Update()
    {
        Jump();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Apple")
        {
            Destroy(collision.gameObject.GetComponent<CircleCollider2D>());
            FindObjectOfType<FruitsCounter>().IncrementApples();
            collision.gameObject.GetComponent<Animator>().SetBool("IsTaken", true);
        }

        if(collision.gameObject.tag == "Banana")
        {
            Destroy(collision.gameObject.GetComponent<CircleCollider2D>());
            FindObjectOfType<FruitsCounter>().IncrementBananas();
            collision.gameObject.GetComponent<Animator>().SetBool("IsTaken", true);
        }

        if(collision.gameObject.tag == "Cherry")
        {
            Destroy(collision.gameObject.GetComponent<CircleCollider2D>());
            FindObjectOfType<FruitsCounter>().IncrementCherries();
            collision.gameObject.GetComponent<Animator>().SetBool("IsTaken", true);
        }
    }
}