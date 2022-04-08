using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteDaughtersTarget : SampleScript
{
    [SerializeField]
    private Transform target;

    public override void Use()
    {
        //foreach(Transform child in target)
        //{
        //    while(child.localScale != Vector3.zero)
        //    {
        //        child.localScale += new Vector3(0.00000000000001F, 0.1F, 0.1F);
        //    }
        //    GameObject.Destroy(child.gameObject);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 s = new Vector3(0.01F, 0.01F);
        //float minimum = 0.01F;
        //float maximum = 0.01F;

        //foreach (Transform child in target)
        //{
        //    //while (child.localScale != s)
        //    //{
        //        child.localScale += new Vector3(Mathf.Lerp(minimum, maximum, Time.time), Mathf.Lerp(minimum, maximum, Time.time), Mathf.Lerp(minimum, maximum, Time.time));
        //    //}
        //    //GameObject.Destroy(child.gameObject);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        float minimum = 0.001F;
        float maximum = 0.0001F;

        foreach (Transform child in target)
        {
            while (child.localScale.x >= 0)
            {
                child.localScale -= new Vector3(Mathf.Lerp(minimum, maximum, Time.time), Mathf.Lerp(minimum, maximum, Time.time), Mathf.Lerp(minimum, maximum, Time.time));
            }        
        }
    }
}
