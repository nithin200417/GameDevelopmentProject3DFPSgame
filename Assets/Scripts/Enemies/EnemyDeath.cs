using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {

	public int enemyHealth = 60;
	public bool enemyDead = false;
	public GameObject enemyAI;
	void DamageEnemy(int damageAmount) {
		enemyHealth -= damageAmount;
	}
	void Update () {
		if (enemyHealth <= 0 && enemyDead == false) {
			enemyDead = true;
			this.GetComponent<Animator>().Play("Death");
			enemyAI.SetActive(false);
			this.GetComponent<LookPlayer>().enabled = false;
			GlobalScore.scoreValue += 100;
			GlobalComplete.enemyCount += 1;
		}
	}
}
