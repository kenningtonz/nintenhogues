using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class selectahogue : MonoBehaviour
{
    public GameObject gamemanager;
    //    private int scale = 2;
    public int hoguenumber;


    private void OnMouseOver()
    {
        transform.localScale = new Vector3(0.8f, 0.8f, 0);
    }

    private void OnMouseExit()
    {
        
        transform.localScale = new Vector3(0.4f, 0.4f, 0);
    }

    private void OnMouseDown()
    {
        Debug.Log("changed");
        gamemanager.GetComponent<scenemanager>().play();
        hogueplayerint.Hoguenumber = hoguenumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
