using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float LimitTimer;
    public Text text_Timer;

    // Update is called once per frame
    void Update()
    {
        LimitTimer -= Time.deltaTime;
        text_Timer.text = Mathf.Round(LimitTimer) + " 초";
    }
}
