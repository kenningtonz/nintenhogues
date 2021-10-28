using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public Image hogueonscreen;
    public Sprite[] hogues;
    private float decrease;
   // static int hogue = 1;
    void Start()
    {
        switch (hogueplayerint.Hoguenumber)
        {
            case (0):
                decrease = 0.3f;
                break;
            case (1):
                decrease = 0.4f;
                break;
            case (2):
                decrease = 0.5f;
                break;
            case (3):
                decrease = 0.75f;
                break;
        }

        hogueplayerint.Hardnesstime = 4.0f;
        hogueonscreen.sprite = hogues[hogueplayerint.Hoguenumber];
        StartCoroutine("decreasetime");
    }

    IEnumerator decreasetime()
    {
        yield return new WaitForSeconds(3f);
        hogueplayerint.Hardnesstime -= decrease;
        StartCoroutine("decreasetime");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
