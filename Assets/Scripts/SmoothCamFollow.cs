using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SmoothCamFollow : MonoBehaviour
{
    public Transform followTransform;
    float offset;
    private void Start()
    {
        offset = Vector3.Distance(followTransform.position, transform.position);
    }
    private void LateUpdate()
    {
        transform.DOMove(followTransform.position * -offset, 1);
    }
}
