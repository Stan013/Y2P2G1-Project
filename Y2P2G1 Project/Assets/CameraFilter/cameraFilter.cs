using UnityEngine;
using System.Collections;
 
public class cameraFilter : MonoBehaviour {
 
    private Material noSkybox;
 
    void Start () {
	    GetComponent<Camera>().backgroundColor = new Color(0, 0.4f, 0.7f, 1);
        
    }
 
    void Update () {

            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
            RenderSettings.fogDensity = 0.028f;
            RenderSettings.skybox = noSkybox;
    }
}
