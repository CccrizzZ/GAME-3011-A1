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

    void Start()
    {

        chances = GameObject.FindGameObjectWithTag("Chance");
        cs = GameObject.FindGameObjectWithTag("MiniGameCanvas").GetComponent<CanvasScript>();


        clicked = false;
        spriteImage = GetComponent<Image>();
    }



    public void OnCubeClicked()
    {
        print("Button Clicked");

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
            cs.resourcesCount += 20;
        }
        else if (rand <= 90 && rand > 80)
        {
            print(50);
            spriteImage.sprite = ResultImages[1];
            cs.resourcesCount += 50;
            
        }
        else if (rand > 90)
        {
            print(100);
            spriteImage.sprite = ResultImages[2];
            cs.resourcesCount += 100;

        }

        clicked = true;
        cs.chancesCount--;
        cs.UpdateChanceAndReources();
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        if (!clicked && cs.chancesCount > 0)
        {
            OnCubeClicked();
        }
    }

}
