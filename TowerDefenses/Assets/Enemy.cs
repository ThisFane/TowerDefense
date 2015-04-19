using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour 
{

	private int health;
	private int attack;
	private int something;

	public Enemy(int h, int a, int smth)
	{
		this.health = h;
		this.attack = a;
		this.something = smth;
	}
	
	public void setVar(int h, int a, int s)
	{
		this.health = h;
		this.attack = a;
		this.something = s;
	}

	public int getHealth()
	{
		return this.health;
	}

	public int getAttack()
	{
		return this.attack;
	}

	public int getSmth()
	{
		return this.something;
	}

}
