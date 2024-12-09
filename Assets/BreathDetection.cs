using UnityEngine;

public class BreathDetection : MonoBehaviour
{
    private AudioClip micClip;
    private bool isExhaling = false;
    private int sampleRate = 44100; // Standard audio sample rate
    private const float inhaleThreshold = 0.05f;
    private const float exhaleThreshold = 0.1f;

    void Start()
    {
        // Start microphone recording
        micClip = Microphone.Start(null, true, 10, sampleRate);
        Debug.Log("Microphone started. Capturing audio.");
    }

    void Update()
    {
        if (micClip == null || !Microphone.IsRecording(null))
            return;

        float[] audioSamples = new float[256];
        micClip.GetData(audioSamples, 0);
        float volume = CalculateRMS(audioSamples);

        // Detect inhale and exhale based on thresholds
        if (volume > exhaleThreshold && !isExhaling)
        {
            Debug.Log("Exhaling...");
            isExhaling = true;
        }
        else if (volume < inhaleThreshold && isExhaling)
        {
            Debug.Log("Inhaling...");
            isExhaling = false;
        }
    }

    float CalculateRMS(float[] samples)
    {
        float sum = 0;
        foreach (float sample in samples)
            sum += sample * sample;

        return Mathf.Sqrt(sum / samples.Length);
    }

    void OnApplicationQuit()
    {
        Microphone.End(null);
        Debug.Log("Microphone stopped.");
    }
}