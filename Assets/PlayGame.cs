using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

    public GameObject score, level,levelt, totalscore, totalscoretext, rotate, srotate, shoot, sshoot,line1,line2,line3;

	public void BeginGame()
    {
        line1.SetActive(false);
        line2.SetActive(false);
        line3.SetActive(false);
        sshoot.SetActive(false);
        srotate.SetActive(false);
        shoot.SetActive(true);
        rotate.SetActive(true);
        score.SetActive(true);
        level.SetActive(true);
        levelt.SetActive(true);
        totalscore.SetActive(true);
        totalscoretext.SetActive(true);
    }
}
