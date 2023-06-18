using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instance;

    [SerializeField]
    private AudioSource coinSound;


    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }

    public void PlayCoinSound()
    {
        coinSound.Play();
    }

}//class






























