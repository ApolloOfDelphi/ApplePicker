using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float boundary = -20f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < boundary)
        {
            Destroy(this.gameObject);
            BasketInstantiation apScript = Camera.main.GetComponent<BasketInstantiation>();
            apScript.AppleMissed();
        }
    }
}