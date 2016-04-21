using UnityEngine;
using System.Collections;

/**
 * Potion
 * Consumable Item
 * Restores Health
*/
public class Potion : ConsumableItem {

	private int incHPNum; //Amount of HP to restore.

	//Constructor: Sets Name, Descirption, SellPrice, BuyPrice, and incHPNum;
	public Potion(){

		name = "Potion";
		description = "Heals a character for 50hp";
		sellPrice = 5;
		buyPrice = 10;
		incHPNum = 50;
	}

	//Called when using item from World Map
	//Calls the target's increaseHealth method and sends incHealthNum
	override
	public void useItemWorld(GameObject target)	//Parameter is the actual Game Object, such as the character that we are healing
	{
		CharacterStats targetHealth = target.GetComponent<CharacterStats>();	//Accesses the target's CharacterStats script
		targetHealth.increaseHP(incHPNum);								//Uses the target's scripts' method
	}
		
	//Called when using item from battle
	//Calls the target's increaseHealth method and sends incHealthNum
	override
	public void useItemBattle(GameObject target)
	{
		CharacterStats targetHealth = target.GetComponent<CharacterStats>();
		targetHealth.increaseHP (incHPNum);
	}
}
