using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ButtonTest : MonoBehaviour, IPointerClickHandler
{


    public Image spriteImage;

    public Sprite AfterClick;

    void Start()
    {
        spriteImage = GetComponent<Image>();
    }

    void Update()
    {
        
    }

    public void Test()
    {
        print("Button Clicked");
        spriteImage.sprite = AfterClick;
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        Test();
    }

}
