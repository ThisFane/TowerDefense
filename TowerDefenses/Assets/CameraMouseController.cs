using UnityEngine;
using System.Collections;

public class CameraMouseController : MonoBehaviour {

	public int dir = 0;



	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseOver()
	{
		//Links
		if(dir == 0)
		 Camera.main.transform.Translate((Vector3.left* CameraController.cameraVelocity) * Time.deltaTime);
		//Rechts
		if(dir == 1)
		 Camera.main.transform.Translate((Vector3.right * CameraController.cameraVelocity) * Time.deltaTime);
		//Oben
		if(dir == 2)
		 Camera.main.transform.Translate((Vector3.up * CameraController.cameraVelocity) * Time.deltaTime);
		//Unten
		if(dir == 3)
		 Camera.main.transform.Translate((Vector3.down * CameraController.cameraVelocity) * Time.deltaTime);

		//Later Diagonale!
		/*if(dir == 1)
		{
			Camera.main.transform.Translate((Vector3.right * CameraController.cameraVelocity) * Time.deltaTime);
			Camera.main.transform.Translate((Vector3.up * CameraController.cameraVelocity) * Time.deltaTime);
		}
		 */
	}
}
