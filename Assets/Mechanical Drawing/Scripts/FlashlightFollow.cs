using UnityEngine;
using UnityEngine.InputSystem;

public class FlashlightFollow : MonoBehaviour
{
    void Update()
    {
        //Converts Screen to World point, allowing for the Flashlight image have its position transformed at the mouse
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = mousePos;
    }
}
