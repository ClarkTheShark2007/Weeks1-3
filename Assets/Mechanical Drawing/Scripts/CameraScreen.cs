using UnityEngine;

public class CameraScreen : MonoBehaviour
{
    public bool MouseOverCamera; //Bool being made true OR false depending on the CameraCheck script
    public Transform start; //Starting position of where the GameObject is located
    public Transform end; //Ending position of where the GameObject will be located
    float CameraTime;
    public AnimationCurve curve;

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosistion = transform.position;


        if(MouseOverCamera == true)
        {
            //Moves camera in frame via an Animation curve based off CameraTime
            CameraTime += 1f*Time.deltaTime;
            if(CameraTime > 1)
            {
                CameraTime = 1;
            }
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(CameraTime));
        }

        if(MouseOverCamera == false)
        {
            CameraTime -= 1f*Time.deltaTime;
            if(CameraTime < 0)
            {
                CameraTime = 0;
            }
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(CameraTime));
        }
    }
}
