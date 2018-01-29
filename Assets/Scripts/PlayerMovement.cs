using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody rb;

	public float velocidade = 600f;
	public float sidewaysForce = 500f;
	// Update is called once per frame
	void FixedUpdate () 
	{

		rb.AddForce (0, 0, velocidade * Time.deltaTime);

		if ( Input.GetKey("d"))
		{

			rb.AddForce(sidewaysForce* Time.deltaTime, 0,0);

		}
	
		if ( Input.GetKey("a"))
		{

			rb.AddForce(-sidewaysForce* Time.deltaTime, 0,0);

		}

		if (rb.position.y < -1f)
			FindObjectOfType<GameManager> ().EndGame ();
	}


}
