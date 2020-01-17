using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safety : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.position = new Vector3(-86.75f, 1.108f, -88.38f);
    }
}
