using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[RequireComponent(typeof(Light2D))]
public class DayNightCycleController : MonoBehaviour
{
    public Gradient LightColor;

    [Range(0.0f, 24.0f)]
    public float Hour;

    private Light2D globalLight;

    // Start is called before the first frame update
    void Start()
    {
        globalLight = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Hour > 20)
        {
            Color sunlightColor = LightColor.Evaluate((Hour - 20)/ 4);
            globalLight.color = sunlightColor;
        }
        else if (Hour >= 0 && Hour < 6)
        {
            globalLight.color = Color.black;
        }
        else
        {
            globalLight.color = Color.white;
        }
    }
}
