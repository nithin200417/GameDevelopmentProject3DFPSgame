using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

	public GameObject ScoreDisplay;
	public static int scoreValue = 0;
	public int internalScore;
	public GameObject finalScore;
	void Update () {
		internalScore = scoreValue;
		ScoreDisplay.GetComponent<Text>().text = "" + scoreValue;
		finalScore.GetComponent<Text>().text = "" + scoreValue;
	}
}	