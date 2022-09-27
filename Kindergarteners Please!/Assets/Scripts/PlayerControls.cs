using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 1f;
    //Planning to add a skidding function where the player skids instead of stopping completely
    
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetKey(KeyCode.A) ? -speed : (Input.GetKey(KeyCode.D) ? speed : 0 );
        float inputY = Input.GetKey(KeyCode.S) ? -speed : (Input.GetKey(KeyCode.W) ? speed : 0 );
        Vector3 movement;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement = new Vector3(inputX * 2, inputY * 2);
        }
        else
        {
            movement = new Vector3(inputX, inputY);
        }

        transform.Translate(movement/100);
    }
}