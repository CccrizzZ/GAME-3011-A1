using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasScript : MonoBehaviour
{

    public int resourcesCount;
    public int chancesCount;
    public Text chances; 
    public Text resources; 

    public bool scanmode;
    public bool extractmode;

    public GameObject sourceCube;
    

    void Start()
    {

        scanmode = true;
        extractmode = false;
        
        resourcesCount = 0;
        chancesCount = 6;

        chances.text = chancesCount.ToString();
        resources.text = resourcesCount.ToString();

        Vector3 temp = transform.position;


        // throw 100 tiles onto the canvas
        for (var i = 1; i <= 10; i++)
        {
            for (var j = 1; j <= 10; j++)
            {
                temp.y = i * 100 - 500;
                temp.x = j * 100 - 500;
                GameObject newCube = Instantiate(sourceCube, temp, transform.rotation);
                newCube.transform.SetParent(transform,false);
            }
        }



        
    }

    public void UpdateChanceAndReources()
    {
        chances.text = chancesCount.ToString();
        resources.text = resourcesCount.ToString();
    }


    
}
