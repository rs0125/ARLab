using Mediapipe.Tasks.Vision.HandLandmarker;
using Mediapipe.Unity.Sample.HandLandmarkDetection;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class Eventkumar : UnityEvent<HandLandmarkerResult>
{

}

public class LandmarkResultReceiver : MonoBehaviour
{
    private HandLandmarkerRunner handLandmarkerRunner;
    public static LandmarkResultReceiver Instance { get; private set; }

    public static Eventkumar testkumar = new Eventkumar();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);

        }
    }

    private void OnDestroy()
    {
        if(Instance == this)
        {
            Instance = null;
        }
    }

    void Start()
    {
        handLandmarkerRunner = FindObjectOfType<HandLandmarkerRunner>();
        if (handLandmarkerRunner == null)
        {
            Debug.LogError("HandLandmarkerRunner not found in the scene.");
        }
    }

    public void ReceiveLandmarkResult(HandLandmarkerResult result)
    {
        Debug.Log(result);
        testkumar.Invoke(result);

    }


}
