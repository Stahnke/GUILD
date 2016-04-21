using UnityEngine;
using System.Collections;

/**
 * Abstract Item Class
 * Class Heirarchy:
 * Item -> ConsumableItem -> Instance
 * 		-> CraftItem -> Instance
 * 		-> KeyItem -> Instance
 *
*/
public abstract class Item {

	protected string name;			//Name
	protected string description;	//Description
	protected int buyPrice;			//Buy Price
	protected int sellPrice;		//Sell Price

	//Returns the description of the item
	public void viewItem(){

		Debug.Log ("Name: " + name + "\n" + "Description: " + description);
	}


	//Getters
	public string getName(){
		return name;
	}
	public int getBuyPrice(){
		return buyPrice;
	}
	public int getSellPrice(){
		return sellPrice;
	}

}
