using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public DateTime gameDate;

    public float timeInterval = 10;

    private float elapsedTime = 0;

    public Text testLabel;

    // Start is called before the first frame update
    void Start()
    {
        gameDate = new DateTime(1900, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime > timeInterval)
        {
            elapsedTime = 0;
            gameDate = gameDate.AddMinutes(10);

            testLabel.text = gameDate.ToString("MM/dd HH:mm");
        }
    }
}
