using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject SleepBuild;
    public GameObject HeatBuild;
    public GameObject LightBuild;

    public GameObject SleepSource;
    public GameObject HeatSource;
    public GameObject LightSource;

    private bool hasSleepSource;
    private bool hasHeatSource;
    private bool hasLightSource;

    private float waitTime1 = 0.5f;
    private float waitTime2 = 0.5f;
    private float waitTime3 = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasSleepSource)
        {
            waitTime1 -= Time.deltaTime;

            if(waitTime1 <= 0)
            {
                Destroy(SleepSource);
                SleepBuild.SetActive(true);
                hasSleepSource = false;
            }
        }

        if (hasHeatSource)
        {
            waitTime2 -= Time.deltaTime;

            if (waitTime2 <= 0)
            {
                Destroy(HeatSource);
                HeatBuild.SetActive(true);
                hasHeatSource = false;
            }
        }

        if (hasLightSource)
        {
            waitTime3 -= Time.deltaTime;

            if (waitTime3 <= 0)
            {
                Destroy(LightSource);
                LightBuild.SetActive(true);
                hasLightSource = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sleep Source")
        {
            hasSleepSource = true;
        }
        if (collision.gameObject.name == "Heat Source")
        {
            hasHeatSource = true;
        }
        if (collision.gameObject.name == "Light Source")
        {
            hasLightSource = true;
        }
    }
}
