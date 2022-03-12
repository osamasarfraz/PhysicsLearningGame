using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushRocket : MonoBehaviour
{
    Rigidbody2D rocketRb;
    float forceValue;
    public Text AccelerationValueTxt;
    bool isPointerDown = false;

    float acceleration;
    float lastVelocity;

    private void Awake()
    {
        rocketRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isPointerDown)
        {
            rocketRb.AddForce(new Vector2(0, forceValue));
        }
        AccelerationValueTxt.text = acceleration.ToString();
    }

    private void FixedUpdate()
    {
        acceleration = (rocketRb.velocity.y - lastVelocity) / Time.fixedDeltaTime;
        
    }

    public void SetForce(float forceVal)
    {
        forceValue = forceVal;
    }

    public void SetPointerToggle(bool toggle)
    {
        isPointerDown = toggle;
        if(toggle)
            lastVelocity = rocketRb.velocity.y;
    }
}
