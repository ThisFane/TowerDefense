using UnityEngine;
using System.Collections;

public class Enemy1 : Enemy
{
	private GameObject thisEnemy;

	void Start()
	{
		thisEnemy = this.gameObject;
	}

	public Enemy1(int h, int a, int smth): base(h, a, smth)
	{

	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.L))
		{ 
			Debug.Log(this.getHealth());
			Debug.Log(this.getAttack());
			Debug.Log(this.getSmth());
		}
	}
}
