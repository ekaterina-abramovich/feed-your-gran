using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    public GameObject Granny;
    public GameObject CanvasReadLetter;
    public GameObject CanvasLetter;
    public GameObject StartDoor;
    public GameObject Letter;

    public GameObject CanvasReadTableHint;
    public GameObject TableHint;
    public GameObject CanvasTableHint;
    public GameObject KitchenDoor;

    public GameObject CanvasInstructions;
    
    public GameObject FlourHint;
    public GameObject EggsHint;
    public GameObject AppleHint;

    public GameObject CanvasFlourHint;
    public GameObject CanvasEggsHint;
    public GameObject CanvasAppleHint;


    private void Awake()
    {
        Granny.SetActive(false);

        CanvasLetter.SetActive(false);
        CanvasReadTableHint.SetActive(false);
        CanvasReadLetter.SetActive(true);
        CanvasTableHint.SetActive(false);
        CanvasInstructions.SetActive(false);
        
        CanvasFlourHint.SetActive(false);
        CanvasEggsHint.SetActive(false);
        CanvasAppleHint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Reading the letter
        if (Vector3.Distance(gameObject.transform.position, Letter.transform.position) < 3 &&
            Input.GetKeyDown(KeyCode.T))
        {
            Destroy(CanvasReadLetter);
            Destroy(StartDoor);
            CanvasLetter.SetActive(true);
        }
        //Closing the letter
        if (Vector3.Distance(gameObject.transform.position, Letter.transform.position) > 3)
        {
            CanvasLetter.SetActive(false);
        }
        //CanvasReadTableHint appears
        if (Vector3.Distance(gameObject.transform.position, Letter.transform.position) > 3 && StartDoor == null && KitchenDoor != null)
        {
            CanvasReadTableHint.SetActive(true);
        }
        
        //Reading the table hint
        if (Vector3.Distance(gameObject.transform.position, TableHint.transform.position) < 5 &&
            Input.GetKeyDown(KeyCode.T))
        {
            CanvasReadTableHint.SetActive(false);
            Destroy(KitchenDoor);
            CanvasTableHint.SetActive(true);
            CanvasInstructions.SetActive(true);
        }
        //Closing the table hint
        if (Vector3.Distance(gameObject.transform.position, TableHint.transform.position) > 5)
        {
            CanvasTableHint.SetActive(false);
        }
        
        //Activating Granny
        if (Vector3.Distance(gameObject.transform.position, TableHint.transform.position) > 5 && KitchenDoor == null)
        {
            Granny.SetActive(true);
        }
        
        //Reading the apple hint
        if (Vector3.Distance(gameObject.transform.position, AppleHint.transform.position) < 3 &&
            Input.GetKeyDown(KeyCode.T))
        {
            CanvasAppleHint.SetActive(true);
        }
        //Closing the apple hint
        if (Vector3.Distance(gameObject.transform.position, AppleHint.transform.position) > 3)
        {
            CanvasAppleHint.SetActive(false);
        }
        
        //Reading the flour hint
        if (Vector3.Distance(gameObject.transform.position, FlourHint.transform.position) < 3 &&
            Input.GetKeyDown(KeyCode.T))
        {
            CanvasFlourHint.SetActive(true);
        }
        //Closing the flour hint
        if (Vector3.Distance(gameObject.transform.position, FlourHint.transform.position) > 3)
        {
            CanvasFlourHint.SetActive(false);
        }
        
        //Reading the eggs hint
        if (Vector3.Distance(gameObject.transform.position, EggsHint.transform.position) < 3 &&
            Input.GetKeyDown(KeyCode.T))
        {
            CanvasEggsHint.SetActive(true);
        }
        //Closing the eggs hint
        if (Vector3.Distance(gameObject.transform.position, EggsHint.transform.position) > 3)
        {
            CanvasEggsHint.SetActive(false);
        }
    }
}
