using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ButtonTest : MonoBehaviour, IPointerClickHandler
{

    GameObject chances;
    public Image spriteImage;
    public Sprite[] ResultImages;
    bool clicked;
    CanvasScript cs;

    int ResourceValue;


    void Start()
    {

        chances = GameObject.FindGameObjectWithTag("Chance");
        cs = GameObject.FindGameObjectWithTag("MiniGameCanvas").GetComponent<CanvasScript>();


        clicked = false;
        spriteImage = GetComponent<Image>();
    }



    public void OnCubeClicked()
    {
        print("scan");

        int rand = UnityEngine.Random.Range(1,100);
        if (rand <= 50)
        {
            print(0);
            spriteImage.sprite = ResultImages[3];

        }
        else if (rand <= 80 && rand > 50)
        {
            print(20);
            spriteImage.sprite = ResultImages[0];
            ResourceValue = 20;
        }
        else if (rand <= 90 && rand > 80)
        {
            print(50);
            spriteImage.sprite = ResultImages[1];
            ResourceValue = 50;
            
        }
        else if (rand > 90)
        {
            print(100);
            spriteImage.sprite = ResultImages[2];
            ResourceValue = 100;

        }

        clicked = true;
        cs.chancesCount--;
    }



    void OnExtract()
    {
        cs.resourcesCount += ResourceValue;
        cs.UpdateChanceAndReources();
        Destroy(gameObject);
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        if (!clicked && cs.chancesCount > 0 && cs.scanmode)
        {
            OnCubeClicked();
        }
        else if(clicked && cs.extractmode)
        {
            OnExtract();
        }
    }

}
