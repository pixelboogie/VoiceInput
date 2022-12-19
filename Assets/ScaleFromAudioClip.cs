using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromAudioClip : MonoBehaviour
{
    
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;


    void Start()
    {
        
    }


    void Update()
    {
        float loudness = detector.GetLoudnessFromAudioClip(source.timeSamples, source.clip) * loudnessSensibility;

        if(loudness < threshold)
            loudness = 0;

        // lerp value from minscale to maxscale
        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);
    }
}
