using UnityEngine;
using System.Collections;

public class CharacterStats : MonoBehaviour {

	//Max stats
	private int maxHP;
	private int maxMP;
	private int maxStr;
	private int maxInt;
	private int maxDef;

	//Current stats
	private int HP;
	private int MP;
	private int Str;
	private int Int;
	private int Def;

	public CharacterStats(){

		HP = maxHP = 100;

	}

	public void increaseHP(int incHPNum){
		HP += incHPNum;
		if (HP > maxHP) 
		{
			HP = maxHP;
		}
	}

	public void setHP(int HPNum){
		HP = HPNum;
	}
	public int getHP(){
		Debug.Log ("Character HP: " + HP);
		return HP;
	}

}
