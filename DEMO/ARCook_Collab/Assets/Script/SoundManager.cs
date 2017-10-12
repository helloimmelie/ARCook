using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip sound; //임의의 소리 변수
    AudioSource myAudio;

    public static SoundManager instance;

    void Awake()
    {
        if (SoundManager.instance == null)
            SoundManager.instance = this;
    }
    // Use this for initialization
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        myAudio.PlayOneShot(sound); //PlayOneShot 함수를 사용하면 사운드가 재생됨
    }

    // Update is called once per frame
    void Update()
    {

    }
}