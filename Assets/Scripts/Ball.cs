using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 2021.12.14
/// </summary>

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    private Vector3 startPos, endPos;
    private float toutchStart, toutchFinal;

    private Vector3 throwForce;

    //cache memory
    private Rigidbody rb;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
