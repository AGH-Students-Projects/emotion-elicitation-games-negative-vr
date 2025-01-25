using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using UnityEngine.Experimental.GlobalIllumination;


public class Score : MonoBehaviour
{
    private float timer;
    private float delay;
    public int score;
    public Slider slider;
    public Transform floor;
    public float initialY;

    public Light sun;

    public float sunBaseRotation = 130;
    // Update is called once per frame
    
    private void Start()
    {
        floor = GameObject.FindWithTag("Finish").transform;
        initialY = floor.position.y;
    }
    
    private void Update()
    {
        timer = Time.timeSinceLevelLoad;
        if (timer < 50)
        {
            score = (int)timer;
        }
        else if(timer < 100)
        {
            score = (int)(timer * 0.8 + 10);
        }
        else
        {
            score = (int)(timer * 0.5 + 40);
        }
        slider.value = 1 - Mathf.Exp(-0.03f * timer);
        sun.transform.rotation = Quaternion.Euler(sunBaseRotation + 0.2f * timer, 10, 0);
        floor.position = new Vector3(floor.position.x, initialY + 0.01f * timer, floor.position.z);
        
        if (score >= 100)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
