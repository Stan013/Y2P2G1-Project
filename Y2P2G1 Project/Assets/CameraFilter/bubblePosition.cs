using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblePosition : MonoBehaviour
{
    private Vector3 velocity;
    public float smoothTimeY;
    public float smoothTimeX;
    public float smoothTimeZ;
    public OVRPlayerController player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y - 0.05f, ref velocity.y, smoothTimeY);
        float posZ = Mathf.SmoothDamp(transform.position.z, player.transform.position.z, ref velocity.z, smoothTimeZ);

        transform.position = new Vector3(posX, posY, posZ);
    }
}
