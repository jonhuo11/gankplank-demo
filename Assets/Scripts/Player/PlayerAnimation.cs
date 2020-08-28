using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AnimationState
{
    RUNLEFT,
    RUNRIGHT,
    IDLELEFT,
    IDLERIGHT
}

// Player animation
public class PlayerAnimation : MonoBehaviour {
    // TODO: dict of {state : [material]}
    // conditions calculated inside Update, not animator itself
    public string animatorStateName = "State";
    public Vector2 distanceThreshold = new Vector2(0.001f, 0.2f); // 0.001 seems to work well
    public Material runRightMaterial;
    public Material runLeftMaterial;
    public Material idleRightMaterial;
    public Material idleLeftMaterial;
    Vector2 lastFramePos;

    Animator anim;
    Rigidbody2D rbody;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        rend = GetComponent<Renderer>();


        // default settings to avoid visual bug on first time
        ChangeState(AnimationState.IDLERIGHT, idleRightMaterial);
        lastFramePos = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // based on distance moved change animation
        Vector2 distMoved = (Vector2)transform.position - lastFramePos;
        int state = anim.GetInteger(animatorStateName);

        // falling 
        if (Mathf.Abs(distMoved.y) > distanceThreshold.y)
        {
            // TODO implement falling/jumping animation
        }
        else
        {
            // right
            if (distMoved.x > distanceThreshold.x && state != (int)AnimationState.RUNRIGHT)
            {
                ChangeState(AnimationState.RUNRIGHT, runRightMaterial);
            }
            //left
            else if (distMoved.x < -distanceThreshold.x && state != (int)AnimationState.RUNLEFT)
            {
                ChangeState(AnimationState.RUNLEFT, runLeftMaterial);
            }
            else if (System.Math.Abs(distMoved.x) <= distanceThreshold.x) 
            {
                // idle right
                if (state == (int)AnimationState.RUNRIGHT && state != (int)AnimationState.IDLERIGHT)
                {
                    ChangeState(AnimationState.IDLERIGHT, idleRightMaterial);
                }
                // idle left
                else if (state == (int)AnimationState.RUNLEFT && state != (int)AnimationState.IDLELEFT)
                {
                    ChangeState(AnimationState.IDLELEFT, idleLeftMaterial);
                }
            }
        }

        // update previous pos
        lastFramePos = transform.position;
    }

    void ChangeState(AnimationState state, Material mat)
    {
        anim.SetInteger(animatorStateName, (int)state);
        rend.material = mat;
    }
}
