using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public GameObject sourceCube;

    void Start()
    {
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

    
}
