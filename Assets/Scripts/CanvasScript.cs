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



    public GameObject sourceCube;
    

    void Start()
    {
        resourcesCount = 0;
        chancesCount = 6;

        chances.text = chancesCount.ToString();
        resources.text = resourcesCount.ToString();

        Vector3 temp = transform.position;

        for (var i = 1; i <= 5; i++)
        {
            for (var j = 1; j <= 5; j++)
            {
                temp.y = i * 100 - 300;
                temp.x = j * 100 - 300;
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
