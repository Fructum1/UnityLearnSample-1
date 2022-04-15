using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : SampleScript
{
    [SerializeField]
    [Min(0f)]
    private float speed = 1;

    [SerializeField]
    private Vector3 point;

    public override void Use()
    {
        transform.position += point * speed * Time.deltaTime;
    }
    public void Update()
    {
        Use();
    }
}
