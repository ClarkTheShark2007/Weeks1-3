using UnityEngine;

public class MaskScreen : MonoBehaviour
{
    public bool MouseOverMask; //Bool being made true OR false depending on the CameraCheck script
    public Transform start; //Starting position of where the GameObject is located
    public Transform end; //Ending position of where the GameObject will be located
    float MaskTime;
    float MaskSpeed = 1f; //Controls how fast the animation curve is
    public AnimationCurve curve;

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosistion = transform.position;


        if(MouseOverMask == true)
        {
            //Moves camera in frame via an Animation curve based off CameraTime
            MaskTime += MaskSpeed*Time.deltaTime;
            if(MaskTime > 1)
            {
                //When the mask is on, it goes to the last part of the curve, witch makes the mask looks like its breathing, slowing down the speed of the curve being completed
                MaskTime = 0.75f;
                MaskSpeed = 0.05f;

            }
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(MaskTime));
        }

        if(MouseOverMask == false)
        {
            MaskSpeed = 1f;

            MaskTime -= MaskSpeed*Time.deltaTime;
            if(MaskTime < 0)
            {
                MaskTime = 0;
            }
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(MaskTime));
        }
    }
}
