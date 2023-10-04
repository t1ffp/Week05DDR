using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;


    public Animator playerAnim;

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
        transform.position += transform.forward * movementSpeed * Time.deltaTime;

        UpdateMovement();
    }

    void UpdateMovement()
    {
        if (DDR.Pad.Left == true)
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }

        if (DDR.Pad.Right == true)
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
    }

}
