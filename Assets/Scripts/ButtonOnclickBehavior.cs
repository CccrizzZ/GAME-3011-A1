using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonOnclickBehavior : MonoBehaviour
{


    public Canvas ResourceCanvas;
    GameObject playercam;
    FPS_Camera cscript;

    CanvasScript cs;
    public Text ModeIndicator;


    void Start()
    {
        playercam = GameObject.FindGameObjectWithTag("MainCamera");
        cscript = playercam.GetComponent<FPS_Camera>();
        cs = GameObject.FindGameObjectWithTag("MiniGameCanvas").GetComponent<CanvasScript>();
    }

    public void OnQuitClicked()
    {
        print("quit resource geathering");

        // Hide the canvas
        if (ResourceCanvas.enabled == true)
        {
            ResourceCanvas.enabled = false;
            cscript.SetCameraMove();
        }
    }


    public void OnModeButtonClicked()
    {
        
        if (cs.scanmode)
        {
            ModeIndicator.text = "Extract Mode";
            cs.scanmode = false;
            cs.extractmode = true;
            print("extract mode on");
        }
        else if (cs.extractmode)
        {
            ModeIndicator.text = "Scan Mode";
            cs.scanmode = true;
            cs.extractmode = false;
            print("scan mode on");
        }
    }

}
