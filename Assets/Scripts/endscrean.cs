using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscrean : MonoBehaviour
{
    public GameObject endtext;

    // Start is called before the first frame update
    void Start()
    {
        switch (hogueplayerint.Howdied)
        {
            case (0):
                endtext.GetComponent<Text>().text = "hogue needed more bones :(";
                break;
            case (1):
                endtext.GetComponent<Text>().text = "you couldnt keep him happy :(";
                break;
            case (2):
                endtext.GetComponent<Text>().text = "all you had to do was feed him :(";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
