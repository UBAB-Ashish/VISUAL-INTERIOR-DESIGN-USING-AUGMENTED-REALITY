using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.UI.Image;

public class slots : MonoBehaviour
{
    public GameObject[] OC_SLOTS = new GameObject[20];
    public GameObject[] IP_SLOTS = new GameObject[8];
    public GameObject[] WIN_SLOTS = new GameObject[18];
    public GameObject[] RAIL_SLOTS = new GameObject[19];

    public GameObject[] OC_CLONES = new GameObject[20];
    public GameObject[] IP_CLONES = new GameObject[8];
    public GameObject[] WIN_CLONES = new GameObject[18];
    public GameObject[] RAIL_CLONES = new GameObject[19];

    public GameObject TILE;
    public GameObject WALL;

    public Material[] MaterialTILE = new Material[3];
    public Material[] MaterialWALL = new Material[3];

    public GameObject OC1;
    public GameObject OC2;
    public GameObject OC3;

    public GameObject IP1;
    public GameObject IP2;
    public GameObject IP3;

    public GameObject WIN1;
    public GameObject WIN2;
    public GameObject WIN3;

    public GameObject RAIL1;
    public GameObject RAIL2;
    public GameObject RAIL3;

    public GameObject parent;
    public bool isDAY = true;

    public GameObject DAY;
    public GameObject NIGHT;

    public GameObject LIGHT;

    // Start is called before the first frame update
    void Start()
    {
            ALL_START();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //ALL 1st spawns
    public void ALL_START()
    {
        //OUTER COLUMN 1st
        for (int i = 0; i < OC_SLOTS.Length; i++)
        {
            GameObject temp = Instantiate(OC1, OC_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = OC_SLOTS[i].transform.position;
            temp.transform.rotation = OC_SLOTS[i].transform.rotation;
            temp.transform.localScale = OC_SLOTS[i].transform.localScale;
            temp.tag = "OC_CLONE";
        }

        //INNER PILAR 1st
        for (int i = 0; i < IP_SLOTS.Length; i++)
        {
            GameObject temp = Instantiate(IP1, IP_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = IP_SLOTS[i].transform.position;
            temp.transform.rotation = IP_SLOTS[i].transform.rotation;
            temp.transform.localScale = IP_SLOTS[i].transform.localScale;
            temp.tag = "IP_CLONE";
        }

        //WINDOWS 1st
        for (int i = 0; i < WIN_SLOTS.Length; i++)
        {
            GameObject temp = Instantiate(WIN1, WIN_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = WIN_SLOTS[i].transform.position;
            temp.transform.rotation = WIN_SLOTS[i].transform.rotation;
            temp.transform.localScale = WIN_SLOTS[i].transform.localScale;
            temp.tag = "WIN_CLONE";
      
        }

        //TILE 1st
        TILE.GetComponent<MeshRenderer>().material = MaterialTILE[0];

        //WALL 1st
        WALL.GetComponent<MeshRenderer>().material = MaterialWALL[0];

        //RAIL 1st
        for (int i = 0; i < RAIL_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(RAIL1, RAIL_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = RAIL_SLOTS[i].transform.position;
            temp.transform.rotation = RAIL_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "RAIL_CLONE";
        }

    }

/// OUTER COLUMN
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
    public void changeOCtoOC1()
    {
        OC_CLONES = null;
        OC_CLONES = GameObject.FindGameObjectsWithTag("OC_CLONE");
        for (int i=0;i< OC_SLOTS.Length;i++)
        {
            GameObject temp = Instantiate( OC1, OC_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = OC_SLOTS[i].transform.position;
            temp.transform.rotation = OC_SLOTS[i].transform.rotation;
            temp.transform.localScale = OC_SLOTS[i].transform.localScale;
            temp.tag = "OC_CLONE";
            Destroy(OC_CLONES[i]);
        }
    }


    public void changeOCtoOC2()
    {
        OC_CLONES = null;
        OC_CLONES = GameObject.FindGameObjectsWithTag("OC_CLONE");
        for (int i = 0; i < OC_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(OC2, OC_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = OC_SLOTS[i].transform.position;
            temp.transform.rotation = OC_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "OC_CLONE";
            Destroy(OC_CLONES[i]);
        }
    }

    /// INNER PILARS<summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void changeIPtoIP1()
    {
        IP_CLONES = null;
        IP_CLONES = GameObject.FindGameObjectsWithTag("IP_CLONE");
        for (int i = 0; i < IP_SLOTS.Length; i++)
        {
            GameObject temp = Instantiate(IP1, IP_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = IP_SLOTS[i].transform.position;
            temp.transform.rotation = IP_SLOTS[i].transform.rotation;
            temp.transform.localScale = IP_SLOTS[i].transform.localScale;
            temp.tag = "IP_CLONE";
            Destroy(IP_CLONES[i]);
        }
    }


    public void changeIPtoIP2()
    {
        IP_CLONES = null;
        IP_CLONES = GameObject.FindGameObjectsWithTag("IP_CLONE");
        for (int i = 0; i < IP_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(IP2, IP_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = IP_SLOTS[i].transform.position;
            temp.transform.rotation = IP_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "IP_CLONE";
            Destroy(IP_CLONES[i]);
        }
    }

    /// WINDOWS <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void changeWINtoWIN1()
    {
        WIN_CLONES = null;
        WIN_CLONES = GameObject.FindGameObjectsWithTag("WIN_CLONE");
        for (int i = 0; i < WIN_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(WIN1, WIN_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = WIN_SLOTS[i].transform.position;
            temp.transform.rotation = WIN_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "WIN_CLONE";
            Destroy(WIN_CLONES[i]);
        }
    }

    public void changeWINtoWIN2()
    {
        WIN_CLONES = null;
        WIN_CLONES = GameObject.FindGameObjectsWithTag("WIN_CLONE");
        for (int i = 0; i < WIN_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(WIN2, WIN_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = WIN_SLOTS[i].transform.position;
            temp.transform.rotation = WIN_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "WIN_CLONE";
            Destroy(WIN_CLONES[i]);
        }
    }

    /// TILE <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public void changeTILEtoTILE1()
    {          
        TILE.GetComponent<MeshRenderer>().material = MaterialTILE[0];
    }

    public void changeTILEtoTILE2()
    {
        TILE.GetComponent<MeshRenderer>().material = MaterialTILE[1];
    }

    /// WALL <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public void changeWALLtoWALL1()
    {
        WALL.GetComponent<MeshRenderer>().material = MaterialWALL[0];
    }

    public void changeWALLtoWALL2()
    {
        WALL.GetComponent<MeshRenderer>().material = MaterialWALL[1];
    }

    /// RAIL <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void changeRAILtoRAIL1()
    {
        RAIL_CLONES = null;
        RAIL_CLONES = GameObject.FindGameObjectsWithTag("RAIL_CLONE");
        for (int i = 0; i < RAIL_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(RAIL1, RAIL_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = RAIL_SLOTS[i].transform.position;
            temp.transform.rotation = RAIL_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "RAIL_CLONE";
            Destroy(RAIL_CLONES[i]);
        }
    }

    public void changeRAILtoRAIL2()
    {
        RAIL_CLONES = null;
        RAIL_CLONES = GameObject.FindGameObjectsWithTag("RAIL_CLONE");
        for (int i = 0; i < RAIL_SLOTS.Length; i++)
        {
            Vector3 slot = new Vector3(1, 1, 1);
            GameObject temp = Instantiate(RAIL2, RAIL_SLOTS[i].transform);
            temp.transform.parent = parent.transform;
            temp.transform.position = RAIL_SLOTS[i].transform.position;
            temp.transform.rotation = RAIL_SLOTS[i].transform.rotation;
            temp.transform.localScale = slot;
            temp.tag = "RAIL_CLONE";
            Destroy(RAIL_CLONES[i]);
        }
    }

    public void day_night()
    {
        isDAY = !isDAY;
        if (isDAY)
        {
            DAY.SetActive(true);
            NIGHT.SetActive(false);
            LIGHT.SetActive(false);
        }
        else
        {
            DAY.SetActive(false);
            NIGHT.SetActive(true);
            LIGHT.SetActive(true);
        }
    }

}
