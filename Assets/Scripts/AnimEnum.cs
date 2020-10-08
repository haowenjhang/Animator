using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEnum : MonoBehaviour
{
    public static string AnimatorState = "State";

    public static string BlendTree = "Speed";


    public enum StateType : int
    {  
        Idel = 1,
        Pose = 2,
        Jump = 3,
    }
}
