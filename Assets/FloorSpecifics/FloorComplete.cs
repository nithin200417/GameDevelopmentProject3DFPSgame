using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(2);
        GlobalScore.scoreValue = 0;
        GlobalComplete.enemyCount = 0;

        
        if (GlobalComplete.nextFloor <= 3) {
            GlobalComplete.nextFloor += 1;
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
        SceneManager.LoadScene(GlobalComplete.nextFloor);
        if(GlobalComplete.nextFloor > 3) {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
        
    }
}