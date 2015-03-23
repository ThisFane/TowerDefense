using UnityEngine;
using System.Collections;

public class CameraZommer : MonoBehaviour {



	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Camera.main.orthographicSize == 6)
		{
			transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		}
		if(Camera.main.orthographicSize == 5)
		{
			transform.localScale = new Vector3(0.84f, 0.84f, 1.0f);
		}
		if(Camera.main.orthographicSize == 4)
		{
			transform.localScale = new Vector3(0.68f, 0.68f, 1.0f);
		}
		if(Camera.main.orthographicSize == 3)
		{
			transform.localScale = new Vector3(0.52f, 0.52f, 1.0f);
		}
		if(Camera.main.orthographicSize == 2)
		{
			transform.localScale = new Vector3(0.36f, 0.36f, 1.0f);
		}
		if(Camera.main.orthographicSize == 1)
		{
			transform.localScale = new Vector3(0.20f, 0.20f, 1.0f);
		}

	}
}
