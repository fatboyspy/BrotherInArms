using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerController : MonoBehaviour {
    [SerializeField]
    GameObject marker;
    [SerializeField]
    Animator animator;
    string previousName;
	// Use this for initialization
	void Start () {
        marker.SetActive(false);
        animator = marker.GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void PlayAnimation()
    {
        AnimatorStateInfo asi = animator.GetCurrentAnimatorStateInfo(0);

        if (asi.IsName("Idle"))
        {
            if (previousName == null || previousName == "interactive_02")
            {
                previousName = "interactive_01";
                animator.PlayInFixedTime(previousName);
            }
            else
            {
                previousName = "interactive_02";
                animator.PlayInFixedTime(previousName);
            }
        }
        
    }
}
