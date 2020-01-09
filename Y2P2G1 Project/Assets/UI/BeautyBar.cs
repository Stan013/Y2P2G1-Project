using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeautyBar : MonoBehaviour
{
    public Text bText;
    public Text lightText;
    public Text heatText;
    public Text sleepText;
    public Text ready;
    public Text obj;
    public Text objDone;

    public Image readyTop;
    public Image checkmark1;
    public Image checkmark2;
    public Image checkmark3;
    public Slider beautyBar;
    public float beauty;

    public bool lightSource;
    public bool heatSource;
    public bool sleepSource;

    public bool objectA;
    public bool objectB;
    public bool objectC;

    // Start is called before the first frame update
    void Start()
    {
       lightText = GameObject.FindGameObjectWithTag("lightText").GetComponent<Text>();
       heatText = GameObject.FindGameObjectWithTag("heatText").GetComponent<Text>();
       sleepText = GameObject.FindGameObjectWithTag("sleepText").GetComponent<Text>();
       ready = GameObject.FindGameObjectWithTag("Ready").GetComponent<Text>();
       bText = GameObject.FindGameObjectWithTag("Attract").GetComponent<Text>();
       obj = GameObject.FindGameObjectWithTag("Objective").GetComponent<Text>();
       objDone = GameObject.FindGameObjectWithTag("objDone").GetComponent<Text>();
       checkmark1 = GameObject.FindGameObjectWithTag("Checkmark1").GetComponent<Image>();
       checkmark2 = GameObject.FindGameObjectWithTag("Checkmark2").GetComponent<Image>();
       checkmark3 = GameObject.FindGameObjectWithTag("Checkmark3").GetComponent<Image>();
       readyTop = GameObject.FindGameObjectWithTag("Ready").GetComponent<Image>();


       lightSource = false;
       heatSource = false;
       sleepSource = false;

       objectA = false;
       objectB = false;
       objectC = false;

       beautyBar.value = beauty;
    }

    // Update is called once per frame
    void Update()
    {
        // Checkbox for lightsource
        if (lightSource == true){
            checkmark1.gameObject.SetActive(true);
            lightText.color = Color.green;
        }
        else if (lightSource == false) {
            lightText.color = Color.white;
        }
        // Checkbox for heatsource
        if (heatSource == true){
            checkmark2.gameObject.SetActive(true);
            heatText.color = Color.green;
        }
        else if (heatSource == false){
            heatText.color = Color.white;
        }
        // Checkbox for sleepsource
        if (sleepSource == true){
            checkmark3.gameObject.SetActive(true);
            sleepText.color = Color.green;
        }
        else if (sleepSource == false){      
            sleepText.color = Color.white;
        }



        




        //Beauty Object A
        if (objectA == true){
            beauty =+ 0.334f;
            beautyBar.value = beauty;
        }
        else if (objectA == false){
            beauty =- 0.334f;
            beautyBar.value = beauty;
        }

        //Beauty Object B
        if (objectB == true){
            beauty = beautyBar.value + 0.334f;
            beautyBar.value = beauty;
        }

        //Beauty Object C
        if (objectC == true){
            beauty = beautyBar.value + 0.334f;
            beautyBar.value = beauty;
        }

        if (objectA == true && objectB == true && objectC == true){
            bText.color = Color.green;
        }

        if (lightSource == true && heatSource == true && sleepSource == true){
            obj.color = Color.green;
            objDone.gameObject.SetActive(true);
        }

        if (lightSource == true && heatSource == true && sleepSource == true && objectA == true && objectB == true && objectC == true){
            readyTop.gameObject.SetActive(true);
            ready.gameObject.SetActive(true);
        }
    
    }
}
