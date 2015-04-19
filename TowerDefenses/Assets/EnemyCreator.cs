using UnityEngine;
using System.Collections;

public class EnemyCreator : MonoBehaviour
{
	public GameObject enemyFab;
	private GameObject enemy;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			createEnemy(10, 3, 5);
		}
	}

	void createEnemy(int h, int a, int s)
	{
		enemy = Instantiate(enemyFab, new Vector3(6f,5f,0f), Quaternion.identity) as GameObject;
		enemy.GetComponent<Enemy>().setVar(h, a, s);
	}
}
