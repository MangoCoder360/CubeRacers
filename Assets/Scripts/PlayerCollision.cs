using UnityEngine;

public class PlayerCollision : MonoBehaviour // THIS CODE SHOULD BE RUN AS "Player"
{
	private Vector3 lvl1pos = new Vector3(0f, 1.5f, 0f); // The start position of level 1
	private Vector3 lvl2Pos = new Vector3(100f, 1.5f, 0f); // The start position of level 2
	private Vector3 lvl3Pos = new Vector3(200f, 1.5f, 0f); // The start position of level 3
	private Vector3 lvl4Pos = new Vector3(300f, 1.5f, -15f); // The start position of level 4
	private int level = 1;
	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") // Check if player collided with obstacle (from tutorial)
		{
			if (level == 1)
			{
				transform.position = lvl1pos;
			}
			if (level == 2)
            {
				transform.position = lvl2Pos;
            }
			if (level == 3)
            {
				transform.position = lvl3Pos;
            }
			if (level == 4)
			{
				transform.position = lvl4Pos;
			}
		}

		if (collisionInfo.collider.tag == "Cap1")
		{
			transform.position = lvl2Pos;
			level = 2;
		}
		if (collisionInfo.collider.tag == "Cap2")
		{
			transform.position = lvl3Pos;
			level = 3;
		}
		if (collisionInfo.collider.tag == "Cap3")
		{
			transform.position = lvl4Pos;
			level = 4;
		}
	}
}
