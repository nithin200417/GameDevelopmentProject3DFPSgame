using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoldCollect : MonoBehaviour {

	
	public GameObject goldIngots;
	public AudioSource collectSound;
	public GameObject pickupDisplay;

	void OnTriggerEnter(Collider other) {

		GlobalScore.scoreValue += 500;
		goldIngots.SetActive(false);
		collectSound.Play();
		GetComponent<BoxCollider>().enabled = false;
		pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "GOLD x3";
        pickupDisplay.SetActive(true);
	}
}
