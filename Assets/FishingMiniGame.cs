using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingMiniGame : MonoBehaviour
{
    //Make the Egg move
    [Header("Fishing Area")]
    [SerializeField] Transform topBounds;
    [SerializeField] Transform bottomBounds;

    [Header("Fish Settings")]
    [SerializeField] Transform Fish;
    [SerializeField] float smoothMotion = 3f;
    [SerializeField] float fishTimeRandomizer = 3f;
    float fishPosition;
    float fishSpeed;
    float fishTimer;
    float fishTargetPosition;

    [Header("Hook Settinds")]
    [SerializeField] Transform Hook;
    [SerializeField] float HookSize = .18f;
    [SerializeField] float HookSpeed = .1f;
    [SerializeField] float HookGravity = .05f;
    float hookPosition;
    float hookPullVelocity;

    private void FixedUpdate()
    {
        MoveFish();
        MoveHook();
    }

    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            //increase our pull velocity
            hookPullVelocity += HookSpeed * Time.deltaTime; //raises out hook
        } 
    }

    private void MoveHook()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     //increase our pull velocity
        //     hookPullVelocity += HookSpeed * Time.deltaTime; //raises out hook
        // }
        hookPullVelocity -= HookGravity * Time.deltaTime;

        hookPosition += hookPullVelocity;
        hookPosition = Mathf.Clamp(hookPosition, 0, 1); //keep the jook withon bounds
        Hook.position = Vector3.Lerp(bottomBounds.position, topBounds.position, hookPosition);
    }

    private void MoveFish()
    {
        //based on timer, pick random position
        //move fish to that position smoothly
        fishTimer -= Time.deltaTime;
        if(fishTimer < 0)
        {
            //pick a new target position
            //reset timer
            fishTimer = Random.value * fishTimeRandomizer;
            fishTargetPosition = Random.value;
        }

        fishPosition = Mathf.SmoothDamp(fishPosition, fishTargetPosition, ref fishSpeed, smoothMotion);
        Fish.position = Vector3.Lerp(bottomBounds.position, topBounds.position, fishPosition);

    }
}
