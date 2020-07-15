using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {

	public GameObject MainCanvas;
	public GameObject LootPanel;
	public GameObject InventoryPanel;

	void Start () {
		LoadLootWindow ();
	}
	
	public void LoadLootWindow () {
		GameObject LootWindow;
		LootWindow = Instantiate (LootPanel);
		LootWindow.transform.SetParent(MainCanvas.transform, false);
		LootWindow.SetActive (true);
	}

	public void LoadInventoryWindow () {
		GameObject InventoryWindow;
		InventoryWindow = Instantiate (InventoryPanel);
		InventoryWindow.transform.SetParent(MainCanvas.transform, false);
		InventoryWindow.SetActive (true);
	}
}