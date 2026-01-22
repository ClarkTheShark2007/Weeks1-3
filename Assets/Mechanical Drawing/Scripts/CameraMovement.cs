using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public bool MouseOverCamera; //True if the mouse is over Camera GameObject
    public float CameraSpeed;

    // Update is called once per frame
    void Update()
    {
        if(MouseOverCamera == true)
        {
            //Moves cameras screen transform position, determinded by the camera speed
            Vector2 newPosistion = transform.position;
            newPosistion.x += CameraSpeed * Time.deltaTime;

            //Gives the camera littler boarders where, when its moved enough, it will move in the other direction
            if(newPosistion.x <= -3)
            {
            CameraSpeed = CameraSpeed * -1;
            } 

            if(newPosistion.x >= 3)
            {
            CameraSpeed = CameraSpeed * -1;
            } 

            transform.position = newPosistion;
        } 
    }
}
