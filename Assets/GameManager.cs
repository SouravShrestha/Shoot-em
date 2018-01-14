using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private bool ended = false;
    public Rotator rt;
    public Shoot sh;

    public void endGame()
    {
        if (ended)
            return;
        ended = true;
        SceneManager.LoadScene("GameOverScene");
    }
    

    public void resetRotator()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("PIN");
        foreach (GameObject item in items)
        {
            Destroy(item);
        }
        GameObject rot = GameObject.FindGameObjectWithTag("ROTATOR");
        rot.GetComponent<Rotator>().speed = Mathf.Abs(rot.GetComponent<Rotator>().speed) + GetRandomVal.getSpeed();
    }
}
