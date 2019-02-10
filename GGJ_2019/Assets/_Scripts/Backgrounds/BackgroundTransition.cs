using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Referance to https://answers.unity.com/questions/1121691/how-to-modify-images-coloralpha.html
public class BackgroundTransition : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public float fadeTime = 1;
    private float transparent1 = 1;
    private float transparent2 = 1;
    private float transparent3 = 1;
    private int backgroundTotal;
    private int maxTotal;
    // Start is called before the first frame update
    void Start()
    {
        //First image
        if(image1 != null)
        {
            var tempColor1 = image1.color;
            tempColor1.a = transparent1;
            image1.color = tempColor1;
        }
        //Second Image
        if(image2 != null)
        {
            var tempColor2 = image2.color;
            tempColor2.a = transparent2;
            image2.color = tempColor2;
        }
        //Third Image
        if(image3 != null)
        {
            var tempColor3 = image3.color;
            tempColor3.a = transparent3;
            image3.color = tempColor3;
        }
        //Find total image use, by overwrite if image exist
        if (image1 != null)
        {
            backgroundTotal = 1;
            Debug.Log(backgroundTotal);
            if(image2 != null)
            {
                backgroundTotal = 2;
                Debug.Log(backgroundTotal);
                if (image3 != null)
                {
                    backgroundTotal = 3;
                    Debug.Log(backgroundTotal);
                }
            }
        }
        maxTotal = backgroundTotal;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(maxTotal > backgroundTotal)
            {
                backgroundTotal += 1;
            }
            else if(maxTotal == backgroundTotal)
            {
                backgroundTotal = 1;
            }
            else if(maxTotal < backgroundTotal)
            {
                Debug.Log("You should not be seeing this, debug maxTotal < backgroundTotal (Line 57)");
            }
        }
        Transition();
    }

    //Really unconfortable to write but should beable to transition of the background
    void Transition()
    {
        if (backgroundTotal == 1)
        {
            if(image1 != null && transparent1 <= 1)
            {
                transparent1 += Time.deltaTime * fadeTime;
                var tempColor1 = image1.color;
                tempColor1.a = transparent1;
                image1.color = tempColor1;
            }
            if (image2 != null && transparent2 >= 0)
            {
                transparent2 -= Time.deltaTime * fadeTime;
                var tempColor2 = image2.color;
                tempColor2.a = transparent2;
                image2.color = tempColor2;
            }
            if (image3 != null && transparent3 >= 0)
            {
                transparent3 -= Time.deltaTime * fadeTime;
                var tempColor3 = image3.color;
                tempColor3.a = transparent3;
                image3.color = tempColor3;
            }
        }
        if (backgroundTotal == 2)
        {
            if (image2 != null && transparent2 <= 1)
            {
                transparent2 += Time.deltaTime * fadeTime;
                var tempColor2 = image2.color;
                tempColor2.a = transparent2;
                image2.color = tempColor2;
            }
            if (image1 != null && transparent1 >= 0)
            {
                transparent1 -= Time.deltaTime * fadeTime;
                var tempColor1 = image1.color;
                tempColor1.a = transparent1;
                image1.color = tempColor1;
            }
            if (image3 != null && transparent3 >= 0)
            {
                transparent3 -= Time.deltaTime * fadeTime;
                var tempColor3 = image3.color;
                tempColor3.a = transparent3;
                image3.color = tempColor3;
            }
        }
        if (backgroundTotal == 3)
        {
            if (image3 != null && transparent3 <= 1)
            {
                transparent3 += Time.deltaTime * fadeTime;
                var tempColor3 = image3.color;
                tempColor3.a = transparent3;
                image3.color = tempColor3;
            }
            if (image1 != null && transparent1 >= 0)
            {
                transparent1 -= Time.deltaTime * fadeTime;
                var tempColor1 = image1.color;
                tempColor1.a = transparent1;
                image1.color = tempColor1;
            }
            if (image2 != null && transparent2 >= 0)
            {
                transparent2 -= Time.deltaTime * fadeTime;
                var tempColor2 = image2.color;
                tempColor2.a = transparent2;
                image2.color = tempColor2;
            }
        }
    }
}
