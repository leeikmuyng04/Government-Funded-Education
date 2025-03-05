using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    public static AudioManager Instance { get { return instance; } }

    [SerializeField] AudioSource audioSource;
  
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }       
    }

    public void Listener(AudioClip audioclip)
    {
        audioSource.PlayOneShot(audioclip);
    }


}
