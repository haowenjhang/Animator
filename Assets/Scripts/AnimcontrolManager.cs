using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimcontrolManager : MonoBehaviour
{

    Animator ModelAnimator;

    private float speed = 100;


    void Start()
    {
        ModelAnimator = this.GetComponent<Animator>();
    }

    void Update()
    {

        ModelAnimator.SetFloat(AnimEnum.BlendTree, Input.GetAxis("Vertical") * speed);


        if (Input.GetKeyUp(KeyCode.E))
            ChangeState(AnimEnum.StateType.Jump);


        else if (Input.GetKeyUp(KeyCode.Q))
            ChangeState(AnimEnum.StateType.Pose);


        else
            ChangeState(AnimEnum.StateType.Idel);
    }


    void ChangeState(AnimEnum.StateType StateChangeType)
    {

        if (ModelAnimator == null)
            return;

        ModelAnimator.SetInteger(AnimEnum.AnimatorState, (int)StateChangeType);
    }



}
