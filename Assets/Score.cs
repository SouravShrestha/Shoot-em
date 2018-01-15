using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int s=0;
    public Text tscore;
    public Camera cam;
    public Color[] colors;
    GameManager ob = new GameManager();

    private void Start()
    {
        s = 5;
    }

    private void Update()
    {
        tscore.text = s.ToString();
        if (s == 0)
        {
            cam.backgroundColor = colors[Random.Range(0,colors.Length)];
            ob.resetRotator();
            Level.i++;
            Level.point.Add(GetRandomVal.getPoint());
            s = Level.point[Level.i];
        }
    }

}
