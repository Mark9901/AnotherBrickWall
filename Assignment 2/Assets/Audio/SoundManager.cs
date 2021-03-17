using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public static class SoundManager
{
    //all the possible sounds which can be played go here
    //make sure that the tower shots are named after the DAMAGE TYPE cause this is how the tower will find what audio to use
    // how to play audio; SoundManager.PlaySound(string);

    public static GameObject audioGameoObject;
    public static AudioSource oneShotAudioSource;



    public static void PlaySound(string sound) // this string has to match a clip name in the soundassetmanager
    {
        //dont fill the whole scene with tons of audiosources, only one
        if (audioGameoObject == null)
        {
            audioGameoObject = new GameObject("Audio");
            oneShotAudioSource = audioGameoObject.AddComponent<AudioSource>();

            //set the audio mixer channel
            AudioMixer mixer = Resources.Load("AudioMixer") as AudioMixer;
            audioGameoObject.GetComponent<AudioSource>().outputAudioMixerGroup = mixer.FindMatchingGroups("VolumeFX")[0]; // since its the only one in the group set it to 0

        }
        //random pitch
        audioGameoObject.GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
        //look for the audio source in the assetmanager
        oneShotAudioSource.PlayOneShot(GetAudioClip(sound));

        //Object.Destroy(soundGameObject, audioSource.clip.length);
    }

    private static AudioClip GetAudioClip(string findSound)
    {
        //search the list of audio sources until the string matches a name of clip
        foreach (SoundAssetManager.SoundAudioClip soundAudioClip in SoundAssetManager.i.SoundAudioClipArray)
        {
            if (soundAudioClip.nameOfClip == findSound)
            {
                return soundAudioClip.audioclip;
            }
        }
        Debug.LogError("no sound found?=?");
        return null;
    }
}
