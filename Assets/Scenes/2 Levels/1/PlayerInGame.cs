using UnityEngine;

public class PlayerInGameController : MonoBehaviour
{
    // movement
    public float speed = 1.0f;
    public float gravity = 9.8f;
    private Vector3 moveDirection = Vector3.right;

    void Update()
    {
        CharacterController controllerInGame = GetComponent<CharacterController>();
        if (controllerInGame.isGrounded)
        {
            moveDirection = new Vector3(1, 0.0f, Input.GetAxis("Vertical"));
            //moveDirection = new Vector3(1.0f, 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controllerInGame.Move(moveDirection * Time.deltaTime);
    }
}