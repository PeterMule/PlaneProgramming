﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(15.0f,0.0f,0.0f);

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 270, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
