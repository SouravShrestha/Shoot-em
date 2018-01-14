using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static List<int> point = new List<int>();
    public static int i;
    public Text level;

    private void Start()
    {
        point.Add(5);
        Debug.Log("Added");
        i = 0;
    }

    private void Update()
    {
        level.text = (i+1).ToString();
    }

}
