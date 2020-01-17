using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration : MonoBehaviour
{

    public GameObject pickup;
    private Pickup picky;
    public GameObject unlockable;

    private bool hasSpawned;

    // Start is called before the first frame update
    void Start()
    {
        picky = pickup.GetComponent<Pickup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (picky.hasUnlocked && !hasSpawned)
        {
            unlockable.SetActive(true);
            hasSpawned = true;
        }
    }
}
