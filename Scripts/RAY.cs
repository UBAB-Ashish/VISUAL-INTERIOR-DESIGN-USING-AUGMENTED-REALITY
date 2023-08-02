using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RAY : MonoBehaviour
{

    public string Selected;
    public Text temp;

    public GameObject CANCEL;
    public GameObject BLOCK;

    public GameObject OC_PANEL;
    public GameObject IP_PANEL;
    public GameObject WIN_PANEL;
    public GameObject WALL_PANEL;
    public GameObject TILE_PANEL;
    public GameObject RAIL_PANEL;


    void Start()
    {
        Reset();
    }

    void Update()
    {
        //for (var i = 0; i < Input.touchCount; ++i)
        //{
        //    if (Input.GetTouch(i).phase == TouchPhase.Began)
        //    {

        //        // Construct a ray from the current touch coordinates
        //        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
        //        RaycastHit hit;
        //        // Create a particle if hit
        //        if (Physics.Raycast(ray, out hit))
        //        {

        //            Selected = hit.transform.name;
        //            SelectedMenu();
        //        }
        //    }
        //}


        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if (EventSystem.current.IsPointerOverGameObject(fingerID) == false)
            //{
                if (Physics.Raycast(ray, out hit))
                {
                    // the object identified by hit.transform was clicked
                    // do whatever you want
                    Selected = hit.transform.name;
                }

                SelectedMenu();
            //}
        }
    }
    public void Reset()
    {
        OC_PANEL.SetActive(false);
        IP_PANEL.SetActive(false);
        WIN_PANEL.SetActive(false);
        WALL_PANEL.SetActive(false);
        TILE_PANEL.SetActive(false);
        RAIL_PANEL.SetActive(false);

        Selected = null;
        CANCEL.SetActive(false);
        BLOCK.SetActive(false);
    }


    public void SelectedMenu()
    {
        if (Selected == "OC1_SLOT" ||
            Selected == "OC2_SLOT" ||
            Selected == "OC3_SLOT" ||
            Selected == "OC4_SLOT" ||
            Selected == "OC5_SLOT" ||
            Selected == "OC6_SLOT" ||
            Selected == "OC7_SLOT" ||
            Selected == "OC8_SLOT" ||
            Selected == "OC9_SLOT" ||
            Selected == "OC10_SLOT" ||
            Selected == "OC11_SLOT" ||
            Selected == "OC12_SLOT" ||
            Selected == "OC13_SLOT" ||
            Selected == "OC14_SLOT" ||
            Selected == "OC15_SLOT" ||
            Selected == "OC16_SLOT" ||
            Selected == "OC17_SLOT" ||
            Selected == "OC18_SLOT" ||
            Selected == "OC19_SLOT" ||
            Selected == "OC20_SLOT")
        {
            Reset();
            OC_PANEL.SetActive(true);
            CANCEL.SetActive(true);
            BLOCK.SetActive(true);
        }
        else if (Selected == "IP1_SLOT" ||
            Selected == "IP2_SLOT" ||
            Selected == "IP3_SLOT" ||
            Selected == "IP4_SLOT" ||
            Selected == "IP5_SLOT" ||
            Selected == "IP6_SLOT" ||
            Selected == "IP7_SLOT" ||
            Selected == "IP8_SLOT")
        {
            Reset();
            IP_PANEL.SetActive(true);
            CANCEL.SetActive(true);
            BLOCK.SetActive(true);
        }
        else if (Selected == "WIN1_SLOT" ||
            Selected == "WIN2_SLOT" ||
            Selected == "WIN3_SLOT" ||
            Selected == "WIN4_SLOT" ||
            Selected == "WIN5_SLOT" ||
            Selected == "WIN6_SLOT" ||
            Selected == "WIN7_SLOT" ||
            Selected == "WIN8_SLOT" ||
            Selected == "WIN9_SLOT" ||
            Selected == "WIN10_SLOT" ||
            Selected == "WIN11_SLOT" ||
            Selected == "WIN12_SLOT" ||
            Selected == "WIN13_SLOT" ||
            Selected == "WIN14_SLOT" ||
            Selected == "WIN15_SLOT" ||
            Selected == "WIN16_SLOT" ||
            Selected == "WIN17_SLOT" ||
            Selected == "WIN18_SLOT")
        {
            Reset();
            WIN_PANEL.SetActive(true);
            CANCEL.SetActive(true);
            BLOCK.SetActive(true);
        }
        else if (Selected == "MAIN WALLS")
        {
            Reset();
            WALL_PANEL.SetActive(true);
            CANCEL.SetActive(true);
            BLOCK.SetActive(true);
        }
        else if (Selected == "TILE")
        {
            Reset();
            TILE_PANEL.SetActive(true);
            CANCEL.SetActive(true);
            BLOCK.SetActive(true);
        }
        else if (Selected == "RAIL1" ||
            Selected == "RAIL2" ||
            Selected == "RAIL3" ||
            Selected == "RAIL4" ||
            Selected == "RAIL5" ||
            Selected == "RAIL6" ||
            Selected == "RAIL7" ||
            Selected == "RAIL8" ||
            Selected == "RAIL9" ||
            Selected == "RAIL10" ||
            Selected == "RAIL11" ||
            Selected == "RAIL12" ||
            Selected == "RAIL13" ||
            Selected == "RAIL14" ||
            Selected == "RAIL15" ||
            Selected == "RAIL16" ||
            Selected == "RAIL17" ||
            Selected == "RAIL18" ||
            Selected == "RAIL19")
        {
            Reset();
            RAIL_PANEL.SetActive(true);
            CANCEL.SetActive(true);
            BLOCK.SetActive(true);
        }
    }
}
