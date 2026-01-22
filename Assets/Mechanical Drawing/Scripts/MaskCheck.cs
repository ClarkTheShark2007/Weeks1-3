using UnityEngine;
using UnityEngine.InputSystem;

public class MaskCheck : MonoBehaviour
{
    public MaskScreen MaskScript; //The Mask Screen can only work if MouseOverMask bool is true, this scripts checks if player is over the button
    // Update is called once per frame
    void Update()
    {
        //Converts the Screen to worldpoint. Used to create a distance float between current mouse position vs transform position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(mousePos, transform.position);

        if(distance < 1)
        {
            MaskScript.MouseOverMask = true;

        }
        else
        {
            MaskScript.MouseOverMask = false;
        }
    }
}
