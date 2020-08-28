using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public List<AudioClip> music;
    int index;

    AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;

        src = GetComponent<AudioSource>();
        PlayNextClip();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!src.isPlaying)
        {
            PlayNextClip();
        }
    }

    void PlayNextClip()
    {
        index += 1;
        src.clip = music[index % music.Count];
        Debug.Log("playing clip " + index);
        src.Play();
    }
}
