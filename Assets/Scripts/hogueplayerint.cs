using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class hogueplayerint
{
    private static int hoguenumber;
    private static float hardnesstime;
    private static int howdied;
    public static int Hoguenumber
    {
        get
        {
            return hoguenumber;
        }
        set
        {
            hoguenumber = value;
        }
    }

    public static int Howdied
    {
        get
        {
            return howdied;
        }
        set
        {
            howdied = value;
        }
    }
    public static float Hardnesstime
    {
        get
        {
            return hardnesstime;
        }
        set
        {
            hardnesstime = value;
        }
    }

}
