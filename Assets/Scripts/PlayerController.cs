using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private CharacterController conn;
    public bool isWalking;
    public Transform startPosition;
    public float respawnHeight = -10f;
    public float respawnOffset = 2f;

    private void Awake()
    {
        conn = GetComponent<CharacterController>();
        isWalking = false;
    }

    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement) * moveSpeed;
        movement.y -= 9.18f * Time.deltaTime;
        conn.Move(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Vector3 jump = new Vector3(0f, jumpForce, 0f);
            conn.Move(jump * Time.deltaTime);
        }

        if (transform.position.y < respawnHeight)
        {
            conn.enabled = false; //disable player
            transform.position = startPosition.position + Vector3.up * respawnOffset;
            conn.enabled = true; // re-enable player
        }
    }
    private bool IsGrounded()
    {
        return conn.isGrounded;
    }
}