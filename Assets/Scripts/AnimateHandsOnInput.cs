using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandsOnInput : MonoBehaviour
{
    public Animator handAnimator;
    public InputActionProperty PinchAnimationAction;
    public InputActionProperty GripAnimationAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float TriggerValue =  PinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", TriggerValue);

        float gripValue = GripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
