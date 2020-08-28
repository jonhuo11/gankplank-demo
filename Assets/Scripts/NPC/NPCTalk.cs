using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{

    public List<AudioClip> interactTalk;
    public float interactRadius = 1f;
    public LayerMask playerMask;
    public Vector2 waitForTalkTime = new Vector2(7, 12);
    float nextTalkTime;


    AudioSource voice;

    // Start is called before the first frame update
    void Start()
    {
        voice = GetComponent<AudioSource>();
        nextTalkTime = Time.time;
    }

    void Update()
    {
        // TODO: add dynamic interactions
        if (Physics2D.OverlapCircle(transform.position, interactRadius, playerMask))
        {
            if (Time.time > nextTalkTime)
            {
                voice.clip = interactTalk[Random.Range(0, interactTalk.Count)];
                voice.Play();

                nextTalkTime = Time.time + Random.Range(waitForTalkTime.x, waitForTalkTime.y);
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, interactRadius);
    }
}
