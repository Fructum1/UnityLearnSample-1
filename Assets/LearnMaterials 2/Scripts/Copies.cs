using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copies : SampleScript
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private int number_of_copies;
    [SerializeField]
    private float step;

    public override void Use()
        {
            Copy();
        }

    private void Copy()
        {
            Vector3 shsh = new Vector3(0, 0, step);
            int i = 0;
                while (i < number_of_copies)
                {
                    Instantiate(target, target.transform.position + shsh, Quaternion.identity);
                    step += step;
                }
        }

    // Start is called before the first frame update
    private void Start()
    {
        Copy();
    }

    private void Update()
    {
        
    }  
}