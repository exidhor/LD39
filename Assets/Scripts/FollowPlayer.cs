using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform ToFollow;

    public Vector3 Offset = new Vector3(0, 0, -10);
	// Use this for initialization
	void Awake ()
	{
	    ToFollow = GameObject.FindGameObjectWithTag("Player").transform;
	    if (ToFollow == null)
	    {
	        enabled = false;
	    }
	}
	
	// Update is called once per frame
	void LateUpdate()
	{
	    transform.position = ToFollow.position + Offset;
	}
}
