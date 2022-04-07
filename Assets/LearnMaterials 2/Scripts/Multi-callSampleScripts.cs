using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticallSampleScripts : MonoBehaviour
{
    private List<SampleScript> scripts = new List<SampleScript> ();
    public void ActivateMulticall()
    {
        foreach (SampleScript script in scripts) {
            script.Use();
        }
    }
}
