using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumePlayerMusic : MonoBehaviour
{
    private AudioSource audioSrc;
    // Start is called before the first frame update
    private float musicVolume = 1f;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;



    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

}
