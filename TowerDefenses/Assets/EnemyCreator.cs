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
			createEnemy(Random.Range(0, 10), Random.Range(0, 10), 10, 3, 5);
		}
	}

	void createEnemy(int posX, int posY, int h, int a, int s)
	{
		enemy = Instantiate(enemyFab, new Vector3(posX, posY,0f), Quaternion.identity) as GameObject;
		enemy.GetComponent<Enemy>().setVar(h, a, s);
	}

}
