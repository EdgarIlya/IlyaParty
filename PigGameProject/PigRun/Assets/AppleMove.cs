using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMove : MonoBehaviour
{
    public Vector2 startPosition;
    public Vector2 endPosition;
    public float step;
    private float progress;

    void Start()
    {
        transform.position = startPosition;
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition, progress);
        progress += step;
    }
}
