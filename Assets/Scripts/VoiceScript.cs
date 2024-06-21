using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;
using Oculus.Voice.Dictation;
using Meta.WitAi.Data;

public class VoiceScript : MonoBehaviour
{
    [SerializeField]
    private AppDictationExperience dictationExperience;

    // Start is called before the first frame update
    void Start()
    {
        dictationExperience.Activate();

        // dictationExperience.AudioEvents.OnMicStoppedListening.AddListener(() => {
        //     dictationExperience.Activate();
        // });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
