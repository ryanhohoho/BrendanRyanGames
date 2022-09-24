using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Vector2 speed = new Vector2(3, 3);
    public int sprintSpeed = 6;

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement = new Vector3(inputX * sprintSpeed, inputY * sprintSpeed);
        }
        else
        {
            movement = new Vector3(inputX * speed.x, inputY * speed.y);
        }

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }
}