using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
using Oculus.Voice.Dictation;

public class VoiceScript : MonoBehaviour
{
    public AppDictationExperience dictationExperience;

    // Start is called before the first frame update
    void Start()
    {
        dictationExperience.Activate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
