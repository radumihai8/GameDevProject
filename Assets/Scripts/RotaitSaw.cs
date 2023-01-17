using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RotaitSaw : MonoBehaviour
{

    [SerializeField] private float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 360 * Time.deltaTime);
    }
}
