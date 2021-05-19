using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform player;
	public bool DevMode;
    void FixedUpdate()
	{
		transform.Translate(Input.acceleration.x * 0.6f, 0, -Input.acceleration.z * 0.6f);

		rb.AddForce(0, 0, 10 * Time.deltaTime, ForceMode.VelocityChange);

		if (Input.GetKey("w"))
		{
			rb.AddForce(0, 0, 30 * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetKey("d"))
        {
			rb.AddForce(40 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

		if (Input.GetKey("a"))
		{
			rb.AddForce(-40 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("s"))
        {
			rb.AddForce(0, 0, -20 * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetKey("space"))
		{
			if (player.position.y < 5 && DevMode == true)
            {
				rb.AddForce(0, 80 * Time.deltaTime, 0, ForceMode.VelocityChange);
			}
		}

	}
}
