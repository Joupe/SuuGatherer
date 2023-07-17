using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitScript : MonoBehaviour
{
    public float speed;
    public GameObject topRightLimitGameobject;
    public GameObject bottomLeftLimitGameobject;

    private Vector3 topRightLimit;
    private Vector3 bottomLeftLimit;

    void Start()
    {
        topRightLimit = topRightLimitGameobject.transform.position;
        bottomLeftLimit = bottomLeftLimitGameobject.transform.position;
    }

}
