using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class food : MonoBehaviour
{
 
    public int playerfood = 5;

    public Image[] foods;
    public Sprite fullfood;
    public Sprite emptyfood;

    public int numoffood = 5;


    public void healfood(int healamount)
    {
        playerfood += healamount;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("decreasefood");

    }

    IEnumerator decreasefood()
    {
        yield return new WaitForSeconds(hogueplayerint.Hardnesstime);
        playerfood -= 1;
        StartCoroutine("decreasefood");
    }
    // Update is called once per frame
    void Update()
    {
        if (playerfood > numoffood)
        {
            playerfood = numoffood;
        }
        for (int i = 0; i < foods.Length; i++)
        {
            if (i < playerfood)
            {
                foods[i].sprite = fullfood;
            }
            else
            {
                foods[i].sprite = emptyfood;
            }
            if (i < numoffood)
            {
                foods[i].enabled = true;
            }
            else
            {
                foods[i].enabled = false;
            }
        }



        if (playerfood == 0)
        {
            hogueplayerint.Howdied = 2;
            GetComponent<scenemanager>().end();
        }

    }

  
}
