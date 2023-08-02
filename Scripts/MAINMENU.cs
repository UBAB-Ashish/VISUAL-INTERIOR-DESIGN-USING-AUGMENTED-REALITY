using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    public string name = "SampleScene";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NEXT_LEVEL()
    {
        SceneManager.LoadScene(name);
    }

    public void EXIT_LEVEL()
    {
        Application.Quit();
    }
}
