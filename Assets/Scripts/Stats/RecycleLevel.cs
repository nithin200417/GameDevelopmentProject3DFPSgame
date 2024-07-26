using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour {

		public GameObject gameOver;
		void Start () {
		GlobalLife.lifeValue -= 1;
		if (GlobalLife.lifeValue == 0) {
			SceneManager.LoadScene(5);
		}
		else {
			//GlobalComplete.nextFloor -= 2;
			GlobalScore.scoreValue = 0;
			GlobalComplete.enemyCount = 0;
			if (GlobalComplete.nextFloor == 2) {
				SceneManager.LoadScene(1);
			}
			SceneManager.LoadScene(GlobalComplete.nextFloor);
		}
	}
}
