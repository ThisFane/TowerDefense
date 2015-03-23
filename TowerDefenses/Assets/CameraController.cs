using UnityEngine;
using System.Collections;

// Camera Controller
// Revision 2
// Allows the camera to move left, right, up and down along a fixed axis.
// Attach to a camera GameObject (e.g MainCamera) for functionality.

public class CameraController : MonoBehaviour
{
	
	// How fast the camera moves
	public static int cameraVelocity = 10;
	
	// Use this for initialization
	void Start () 
	{
		
		// Set the initial position of the camera.
		// Right now we don't actually need to set up any other variables as
		// we will start with the initial position of the camera in the scene editor
		// If you want to create cameras dynamically this will be the place to
		// set the initial transform.positiom.x/y/z
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Camera.main.orthographicSize == 0)
			Camera.main.orthographicSize = 1;

		if (Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.orthographicSize != 1) 
		{
			Debug.Log("> 0");
			Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize-1, 5);
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize+1, 6);
		}

		// Left
		if((Input.GetKey(KeyCode.LeftArrow)) || Input.GetKey (KeyCode.A))
		{
			transform.Translate((Vector3.left* cameraVelocity) * Time.deltaTime);
		}
		// Right
		if((Input.GetKey(KeyCode.RightArrow)) || Input.GetKey (KeyCode.D))
		{
			transform.Translate((Vector3.right * cameraVelocity) * Time.deltaTime);
		}
		// Up
		if((Input.GetKey(KeyCode.UpArrow)) || Input.GetKey (KeyCode.W))
		{
			transform.Translate((Vector3.up * cameraVelocity) * Time.deltaTime);
		}
		// Down
		if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey (KeyCode.S))
		{
			transform.Translate((Vector3.down * cameraVelocity) * Time.deltaTime);
		}
	}
}