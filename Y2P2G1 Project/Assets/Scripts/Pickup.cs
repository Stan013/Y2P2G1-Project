using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [SerializeField] float timeBeforeDeletion = 2;

    private bool hasTouched;
    public bool hasUnlocked;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTouched)
        {
            timeBeforeDeletion -= Time.deltaTime;
            
            if (timeBeforeDeletion <= 0)
            {
                hasUnlocked = true;
                Destroy(gameObject);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand" && !hasTouched)
        {
            hasTouched = true;
        }
    }
}
