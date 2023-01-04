using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(-5 * Time.deltaTime, 0);

        if (transform.position.x < -21.5)
        {
            transform.position += new Vector3(21.5f, transform.position.y);
        }
    }
}
