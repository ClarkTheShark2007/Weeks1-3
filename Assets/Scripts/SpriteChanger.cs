using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Color colorwheel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        //pickARandomColour();

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = colorwheel;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void pickARandomColour()
    {

        //if(Keyboard.current.leftArrowKey.wasPressedThisFrame)
        //{
        //    spriteRenderer.color = Random.ColorHSV();
        //}

        //if(Keyboard.current.rightArrowKey.wasPressedThisFrame)
        //{
        //    spriteRenderer.color = colorwheel;
        //}

    }
}
