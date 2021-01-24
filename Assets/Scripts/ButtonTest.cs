using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ButtonTest : MonoBehaviour, IPointerClickHandler
{


    public Image spriteImage;
    public Sprite[] ResultImages;
    bool clicked;


    void Start()
    {
        clicked = false;

        spriteImage = GetComponent<Image>();
    }

    void Update()
    {
        
    }

    public void Test()
    {
        print("Button Clicked");

        int rand = Random.Range(1,100);
        if (rand <= 50)
        {
            print(0);
            spriteImage.sprite = ResultImages[3];

        }
        else if (rand <= 80 && rand > 50)
        {
            print(20);
            spriteImage.sprite = ResultImages[0];
            
        }
        else if (rand <= 90 && rand > 80)
        {
            print(50);
            spriteImage.sprite = ResultImages[1];
            
        }
        else if (rand > 90)
        {
            spriteImage.sprite = ResultImages[2];
            print(100);
        }

        clicked = true;
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        if (!clicked)
        {
            Test();
        }
    }

}
