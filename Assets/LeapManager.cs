using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapManager : MonoBehaviour
{
    Exercise exercise;
    Leap.Unity.LeapServiceProvider leapServiceProvider;
    
    // Start is called before the first frame update
    void Start()
    {
        leapServiceProvider.Load(exercise.recording);
        Debug.Log(leapServiceProvider.CurrentFrame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
