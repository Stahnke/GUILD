using UnityEngine;
using System.Collections;

/** 
 * Abstract Consumable Item Class
 * 
*/
public abstract class ConsumableItem : Item {

	//Abstract Methods
	public abstract void useItemWorld(GameObject target);
	public abstract void useItemBattle(GameObject target);
}
