using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float movement = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newPosistion = transform.position;
        newPosistion.x += movement;
        transform.position = newPosistion;


        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPos.x >= Screen.width || screenPos.x <= 0)
        {
            movement = movement * -1;
        }
    }
}
