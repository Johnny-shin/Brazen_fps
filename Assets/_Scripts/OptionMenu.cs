using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    AudioMixer audioMixer;
    // Start is called before the first frame update
    public void SetVolume(float volume)
    {
        //Debug.Log("volume "+volume);
        audioMixer.SetFloat("volume", volume);
        
    }

}
