using UnityEngine;
using UnityEngine.InputSystem;

public class EyePulse : MonoBehaviour
{
    public AnimationCurve PulseCurve; //Animation Curve that can be drawn diffrently for each pair of Eyes
    public float PulseSpeed; //The speed at which the Animations curves will pulse at
    public float DistanceBetweenFlashlight;
    float PulseTime;

    void Update()
    {
        //Converts the Screen to worldpoint. Used to create a distance float between current mouse position vs transform position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(mousePos, transform.position);

       if (distance > DistanceBetweenFlashlight)
        {
            //A timer made for the diffrent eyes of each animatronic 
            PulseTime += PulseSpeed * Time.deltaTime;
            if(PulseTime > 1)
            {
                PulseTime = 0;
            }
            transform.localScale = Vector3.one * PulseCurve.Evaluate(PulseTime); //Pulse effect created by chaning the local scale of the whole object
        } else
        {
            PulseTime -= 1f * Time.deltaTime;
            if(PulseTime < 0)
            {
                PulseTime = 0;
            }
            transform.localScale = Vector3.one * PulseCurve.Evaluate(PulseTime); 
        }
    }
}
