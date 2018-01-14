using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandomVal {

    public static int getPoint()
    {
        int x = Level.i;

        if (x <= 3)
            return 3*x;
        else if (x > 3 && x <= 5)
            return x * 2;
        else if (x > 5 && x < 10)
            return Random.Range(5, 15);
        else
            return Random.Range(8, 20);
    }

    public static int getRotate()
    {
        int x = Level.i;

        if (x < 10 && x%5!=0 || x==0)
        {

            if (x % 3 == 0 && x > 0)
                return -1;
            else
                return 1;
        }

        else
        {
            float f = Random.value;

            if (f > 0.5)
                return -1;
            else
                return 1;
        }

    }

    public static int getSpeed()
    {
        int x = Level.i;

        if (x % 4 == 0 && x!=0)
        {
            return 10;
        }

        else
            return 0;
    }

}
