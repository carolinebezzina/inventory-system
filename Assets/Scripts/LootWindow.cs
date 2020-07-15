using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LootWindow : MonoBehaviour {

	public GameObject LootButton;
	public Button LootItemButton;
	public Text buttonText;
	public int counter;
    ItemManager item = new ItemManager();

	void Start () {
		for (int counter = 0; counter < ItemManager.numOfItems; counter++) {
			CreateButton ();
		}
	}

	public void CreateButton () {
		GameObject LootItem;
		LootItem = Instantiate (LootButton);
		LootItem.transform.SetParent(gameObject.transform, false);

		LootItemButton = LootItem.GetComponent<Button>();
		//LootItemButton.GetComponentInChildren<Text> ().text = ItemManager.items [counter].name;
		print (item.items[counter].name);

	}
}
