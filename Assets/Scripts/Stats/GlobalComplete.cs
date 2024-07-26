using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour {

	public static int enemyCount;
	public GameObject enemyDisplay;
	public  static int nextFloor = 2;
	void Update () {
		enemyDisplay.GetComponent<Text>().text = "" + enemyCount; 
	}
}
