using System;
using UnityEngine;


public class Character : MonoBehaviour
{
	Camera cam;
	Rigidbody2D rb;

	[SerializeField] HingeJoint2D[] wheels;
	JointMotor2D motor;

	[SerializeField] float CannonSpeed;
	bool isMoving = false;

	Vector2 pos;
	float screenBounds;
	float velocityX;

    void Start()
    {
        cam = Camera.main;

        rb = GetComponent<Rigidbody2D>();
        pos = rb.position;

        motor = wheels[0].motor;

        screenBounds = Game.Instance.screenWidth - 0.56f;
    }

    void Update()
	{
		isMoving = Input.GetMouseButton(0);

		if (isMoving)
		{
			pos.x = cam.ScreenToWorldPoint(Input.mousePosition).x;
		}
	}

    void FixedUpdate()
    {
        if (isMoving)
        {
            rb.MovePosition(Vector2.Lerp(rb.position, pos, CannonSpeed * Time.fixedDeltaTime));
        }
        else
        {
            rb.velocity = Vector2.zero;
        }


        velocityX = rb.GetPointVelocity(rb.position).x;
        if (Mathf.Abs(velocityX) > 0.0f && Mathf.Abs(rb.position.x) < screenBounds)
        {
            motor.motorSpeed = velocityX * 150f;
            MotorActivate(true);
        }
        else
        {
            motor.motorSpeed = 0f;
            MotorActivate(false);
        }
    }

    public void MotorActivate(bool isActive)
    {
        wheels[0].useMotor = isActive;
        wheels[1].useMotor = isActive;

        wheels[0].motor = motor;
        wheels[1].motor = motor;
    }
}
