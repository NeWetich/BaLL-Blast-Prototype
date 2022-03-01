using UnityEngine;

public class WallCollision : MonoBehaviour
{
 //   void OnTriggerBulletD(Collider2D other)
 //   {
 //       if (other.tag.Equals("bullet"))
 //       {
 //           Bullet.DestroyBullet(other.gameObject);
 //       }
 //   }

	//void OnTriggerGameplay(Collider2D other)
	//{
	//	if (other.tag.Equals("character"))
	//	{
	//		Debug.Log("gameover");
	//	}

	//	if (other.tag.Equals("bullet"))
	//	{
	//		Ball.TakeDamage(1);
	//		Bullet.DestroyBullet(other.gameObject);
	//	}

	//	if (!Ball.isShowing && other.tag.Equals("wall"))
	//	{
	//		float posX = transform.position.x;
	//		if (posX > 0)
	//		{
	//			Ball.rb.AddForce(Vector2.left * 150f);
	//		}
	//		else
	//		{
	//			Ball.rb.AddForce(Vector2.right * 150f);
	//		}

	//		Ball.rb.AddTorque(posX * 4f);
	//	}

	//	if (other.tag.Equals("floor"))
	//	{

	//		Ball.rb.velocity = new Vector2(Ball.rb.velocity.x, Ball.jumpForce);
	//		Ball.rb.AddTorque(-Ball.rb.angularVelocity * 4f);
	//	}
	//}
}
