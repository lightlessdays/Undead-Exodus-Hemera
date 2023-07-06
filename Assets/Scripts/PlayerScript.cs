using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    //variables for jumping
    float jumpForce;
    bool allowJump;
    float gravity;

    //variables for movement
    float playerSpeed = 0.1f;
    float inputX, inputZ;
    float speed;

    //variables for coodinates
    float posY;

    //variables for particle system
    [SerializeField] private ParticleSystem muzzle;

    //GameObjects
    GameObject player;

    //Controllers
    private CharacterController _characterController;
    private Animator _animator;

    void Awake()
    {
        jumpForce = 3f;
        gravity = 9.8f;
        allowJump = true;
        speed = 6f;

        player = GameObject.FindGameObjectWithTag("Player");
        _characterController = player.GetComponent<CharacterController>();

        _animator = player.transform.GetChild(0).gameObject.GetComponent<Animator>();

    }

    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {

        //animation and speed
        animationCode();

        //rotation
        rotationCode();

        //gravity
        gravityCode();

        //jumping
        jump();

        //movement
        movementCode();

    }

    void jump()
    {
        if (Input.GetButtonDown("Jump") && allowJump && player.transform.position.y < 35f)
        {
            allowJump = false;
            posY = jumpForce;


            Invoke("allowJumpAgain", 0.7f);
        }
    }

    void allowJumpAgain()
    {
        allowJump = true;
    }

    void gravityCode()
    {
        if (_characterController.isGrounded)
        {
            posY = 0;
        }
        else
        {
            posY -= gravity * Time.deltaTime;
        }
    }

    void rotationCode()
    {
        if (inputX == 1)
        {
            player.transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        }
        else if (inputX == -1)
        {
            player.transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime);
        }
    }

    void animationCode()
    {
        if (inputZ == 0)
        {
            //setting idle to true
            _animator.SetBool("isRifleIdle", true);

            //setting all other animations to false
            _animator.SetBool("isWalking", false);
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                speed = 8f;

            }
            else
            {
                speed = 4f;

                //setting walking to true
                _animator.SetBool("isWalking", true);

                //setting all other animations to false
                _animator.SetBool("isIdle", false);
            }
        }
    }

    void movementCode()
    {
        Vector3 movePlayer = new Vector3(0, posY, 0);
        _characterController.Move(movePlayer * playerSpeed);
        player.transform.position += player.transform.forward * Time.deltaTime * inputZ * speed;
    }
}
