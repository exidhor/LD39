using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform ToFollow;

    public Vector3 Offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate()
	{
	    transform.position = ToFollow.position + Offset;

	}
}
