using UnityEngine;

public class PlayerControllerV1 : MonoBehaviour
{
    // movement
    public float speed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float gravity = 9.8f;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            // this is regular move
            // moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            // this is move for isometric
            float angle = -45f * Mathf.Deg2Rad;
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            moveDirection = new Vector3(horizontal * Mathf.Cos(angle) - vertical * Mathf.Sin(angle), 0.0f, horizontal * Mathf.Sin(angle) + vertical * Mathf.Cos(angle));

            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}