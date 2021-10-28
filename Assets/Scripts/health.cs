using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
   
    public int playerhealth = 5;

    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyheart;

    public int numofhealth = 5;


    public void healhealth(int healamount)
    {
        playerhealth += healamount;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("decreasehealth");

    }

    IEnumerator decreasehealth()
    {
        yield return new WaitForSeconds(hogueplayerint.Hardnesstime);
        playerhealth -= 1;
        StartCoroutine("decreasehealth");
    }
    // Update is called once per frame
    void Update()
    {
        if (playerhealth > numofhealth)
        {
            playerhealth = numofhealth;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerhealth)
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = emptyheart;
            }
            if (i  < numofhealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (playerhealth == 0)
        {
            hogueplayerint.Howdied = 0;
            GetComponent<scenemanager>().end();
        }

    }
}
