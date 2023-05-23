using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsController : MonoBehaviour
{
    //Three searching ingredients
    public GameObject Apple;
    public GameObject Flour;
    public GameObject Eggs;
    
    //Three ready ingredients
    public GameObject AppleTable;
    public GameObject FlourTable;
    public GameObject EggsTable;
    
    //Apple pie
    public GameObject Pie;
    public GameObject PieSlice;
    
    //Table hint
    public GameObject TableHint;
    public GameObject CanvasInstructions;

    public GameObject CanvasFeedGran;

    //Three ready ingredients are hidden for now
    private void Awake()
    {
        AppleTable.SetActive(false);
        FlourTable.SetActive(false);
        EggsTable.SetActive(false);
        
        Pie.SetActive(false);
        PieSlice.SetActive(false);
        
        CanvasFeedGran.SetActive(false);
    }
    
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Ingredient") == null)
        {
            Pie.SetActive(true);
            PieSlice.SetActive(true);
            
            AppleTable.SetActive(false);
            FlourTable.SetActive(false);
            EggsTable.SetActive(false);
            
            TableHint.SetActive(false);
            CanvasInstructions.SetActive(false);
            CanvasFeedGran.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Apple")
        {
            Destroy(Apple); 
            AppleTable.SetActive(true);
        } else if (collider.gameObject.name == "Flour")
        {
            Destroy(Flour);
            FlourTable.SetActive(true);
        } else if (collider.gameObject.name == "Bowl of eggs")
        {
            Destroy(Eggs);
            EggsTable.SetActive(true);
        }
    }
}