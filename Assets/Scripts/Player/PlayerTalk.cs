using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalk : MonoBehaviour
{

    public List<AudioClip> idleTalk;
    public Vector2 waitForTalkTime = new Vector2(5, 10);
    float nextTalkTime;

    AudioSource voice;

    // Start is called before the first frame update
    void Start()
    {
        voice = GetComponent<AudioSource>();
        nextTalkTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTalkTime)
        {
            AudioClip clip = idleTalk[Random.Range(0, idleTalk.Count)];
            voice.clip = clip;
            voice.Play();

            nextTalkTime = Time.time + Random.Range(waitForTalkTime.x, waitForTalkTime.y);
        }
    }
}
