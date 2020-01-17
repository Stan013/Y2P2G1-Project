using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public OVRPlayerController player;

    public float xPosition;
    public float zPosition;
    public float yRotation;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            Debug.Log("Handy");
            player.transform.position = new Vector3(xPosition, transform.position.y, zPosition);
            player.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, transform.rotation.eulerAngles.z);
        }
    }
}
