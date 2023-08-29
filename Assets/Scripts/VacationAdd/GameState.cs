using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    float freqTime;

    void Update()
    {
        freqTime += Time.deltaTime;
    }

    public float GetFreqTime()
    {
        return freqTime;
    }

    public void SetFreqTimeZero()
    {
        freqTime=0;
    }
}
