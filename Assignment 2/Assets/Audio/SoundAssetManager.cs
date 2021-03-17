using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAssetManager : MonoBehaviour
{
    private static SoundAssetManager _i;

    public static SoundAssetManager i
    {
        get
        {
            //if the soundassetmanager is not found, instansiate it, boom
            if (_i == null) _i = (Instantiate(Resources.Load("SoundAssetManager")) as GameObject).GetComponent<SoundAssetManager>();
            return _i;
        }
    }

    //the source to all the audio clips go here in the ionspector, prefab found in resources folder

    public SoundAudioClip[] SoundAudioClipArray;

    [System.Serializable]
    public class SoundAudioClip
    {
        public string nameOfClip;
        //public SoundManager.Sound sound;
        public AudioClip audioclip;
    }



}
