using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    public static AudioManager Instance {  get { return instance; } }

    [SerializeField] AudioSource audiosource;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Listener(AudioClip audioclip)
    {
        audiosource.PlayOneShot(audioclip);
    }

}  
