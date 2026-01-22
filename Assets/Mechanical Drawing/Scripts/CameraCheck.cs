using UnityEngine;
using UnityEngine.InputSystem;

public class CameraCheck : MonoBehaviour
{
    public CameraScreen CameraScript; //Camera Screen can only work if MouseOverCamera bool is true, this scripts checks if player is over the button
    public CameraMovement CameraMovementScript; //Camera Screen can only work if MouseOverCamera bool is true, this scripts checks if player is over the button
    // Update is called once per frame
    void Update()
    {
        //Converts the Screen to worldpoint. Used to create a distance float between current mouse position vs transform position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(mousePos, transform.position);

        if(distance < 1)
        {
            CameraScript.MouseOverCamera = true;
            CameraMovementScript.MouseOverCamera = true;
        }
        else
        {
            CameraScript.MouseOverCamera = false;
            CameraMovementScript.MouseOverCamera = false;
        }
    }
}
