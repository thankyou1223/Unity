using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audiosource;
    void Start()
    {

    }

    public void Listen(AudioClip audioclip)
    {
        audiosource.PlayOneShot(audioclip);
    }

}  
