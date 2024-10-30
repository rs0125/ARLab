using Mediapipe.Tasks.Vision.HandLandmarker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmarkSpawner : MonoBehaviour
{

    public GameObject kumar;
    public void spawn(HandLandmarkerResult result)
    {
        Instantiate(kumar);
    }
    // Start is called before the first frame update
    void Start()
    {
        LandmarkResultReceiver.testkumar.AddListener(spawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
