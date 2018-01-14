using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{

    public static int ts;
    public Text totalscore;

    private void Start()
    {
        ts = 0;
    }

    private void Update()
    {
        totalscore.text = ts.ToString();
    }

}
