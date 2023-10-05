using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    public float mass = 1f;

    public Animator playerAnim;

    public Rigidbody rb;

    CharacterController controller;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //controller.Move(Vector3.forward * movementSpeed * Time.deltaTime);
        //transform.position += transform.forward * movementSpeed * Time.deltaTime;


        UpdateMovement();
        //UpdateGravity();
    }

    void UpdateGravity()
    {
        var gravity = Physics.gravity * mass * Time.deltaTime;
        velocity.y = controller.isGrounded ? -1f : velocity.y * gravity.y;
    }

    void UpdateMovement()
    {
        if (Input.GetKey(KeyCode.W) || DDR.Pad.Center)
        {
            controller.Move(Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || DDR.Pad.Left == true)
        {
            controller.Move (Vector3.left * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || DDR.Pad.Right == true)
        {
            controller.Move(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.E) || DDR.Pad.Up == true)
        {
            playerAnim.SetBool("isSliding", true);
        }
        else
        {
            playerAnim.SetBool("isSliding", false);
        }
    }

}
