using UnityEngine;
using System.Collections;

public class UsePotionTest : MonoBehaviour {

	public GameObject testCharacter;

	// Use this for initialization
	void Start () {

		Debug.Log ("Begin Test: Use Potion");
	
		Potion potion = new Potion ();	//We have to create a new potion, to use it (Normally we would just access it from our inventory)
		CharacterStats stats = testCharacter.GetComponent<CharacterStats> (); //We don't have to create a new character, 
																			  //because there is already one in the environment

		Debug.Log ("Check Current Health");
		stats.getHP ();
		Debug.Log ("Set Health to 50, then check health again");
		stats.setHP (50);
		stats.getHP ();

		Debug.Log ("Check potion description and name");
		potion.viewItem ();

		Debug.Log ("Use potion for +50hp, then check health again");
		potion.useItemWorld (testCharacter);

		stats.getHP ();

		Debug.Log ("Use potion again for +50hp, then check health to see if it went above max health");
		potion.useItemWorld (testCharacter);
		stats.getHP ();
	}
}
