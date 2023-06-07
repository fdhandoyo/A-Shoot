using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOffBounds : MonoBehaviour
{
    public float topBounds = 20f;
    public float lowerBounds = -5f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
