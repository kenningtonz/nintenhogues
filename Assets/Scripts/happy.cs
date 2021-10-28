using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class happy : MonoBehaviour
{
    public int playerhappy = 5;
    
    public Image[] happys;
    public Sprite fullhappy;
    public Sprite emptyhappy;

    public int numofhappy = 5;


    public void healhappy(int healamount)
    {
        playerhappy += healamount;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("decreasehappy");

    }

    IEnumerator decreasehappy()
    {
        yield return new WaitForSeconds(hogueplayerint.Hardnesstime);
        playerhappy -= 1;
        StartCoroutine("decreasehappy");
    }
    // Update is called once per frame
    void Update()
    {
        if (playerhappy > numofhappy)
        {
            playerhappy = numofhappy;
        }
        for (int i = 0; i < happys.Length; i++)
        {
            if (i < playerhappy)
            {
                happys[i].sprite = fullhappy;
            }
            else
            {
                happys[i].sprite = emptyhappy;
            }
            if (i < numofhappy)
            {
                happys[i].enabled = true;
            }
            else
            {
                happys[i].enabled = false;
            }
        }



        if(playerhappy == 0)
        {
            hogueplayerint.Howdied = 1;
            GetComponent<scenemanager>().end();
        }

    }
}
