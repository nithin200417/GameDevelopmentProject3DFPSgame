﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunPickup : MonoBehaviour {

	public GameObject realHandgun;
	public GameObject fakeHandgun;
	public AudioSource handgunPickupSound;
	public GameObject pickupDisplay;

	void OnTriggerEnter(Collider other) {
		realHandgun.SetActive(true);
		fakeHandgun.SetActive(false);
		handgunPickupSound.Play();
		GetComponent<BoxCollider>().enabled = false;
		pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "HAND GUN";
        pickupDisplay.SetActive(true);
	}
}
