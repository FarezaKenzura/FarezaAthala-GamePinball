using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioBGM;
    public GameObject[] audioSFX;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();   
    }

    
    public void PlayBGM() 
    {
        audioBGM.Play();
    }
    public void PlaySFX(Vector3 spawnPosition, int sfxIndex) 
    {
        if (sfxIndex >= 0 && sfxIndex < audioSFX.Length)
        {
            GameObject.Instantiate(audioSFX[sfxIndex], spawnPosition, Quaternion.identity);
        }
    }
}
