using UnityEngine;

public class colider : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter (Collision infocolisao)
	{
		if (infocolisao.collider.tag == "Obstacle")
			
		{

			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame ();
		}



	}

}