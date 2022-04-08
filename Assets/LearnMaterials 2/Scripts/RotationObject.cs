using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : SampleScript
{

    [SerializeField]
    [Range(0f, 100f)]
    private float changeSpeed;
    [SerializeField]
    [Range(0, 360)]
    private int rotation_angle;
    public override void Use()
    {
        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, rotation_angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, changeSpeed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

}

