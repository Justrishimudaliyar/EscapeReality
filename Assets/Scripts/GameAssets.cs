using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameAssets : MonoBehaviour
{
    public static GameAssets instance;
    public static GameAssets Instance { get { return instance; } }
    public SoundAudioClip[] soundAudioClipArray;
    [Serializable]

    

    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
    private void Awake()
    {
        instance = this;
    }
}