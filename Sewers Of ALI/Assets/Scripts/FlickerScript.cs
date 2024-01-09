using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerScript : MonoBehaviour
{
    int num;
    public Light light;
    public MeshRenderer mesh;
    bool initiated;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (initiated == false)
        {
            initiated = true;
            num = Random.Range(0, 10);
            StartCoroutine(flicker());
        }
    }
    IEnumerator flicker()
    {
        light.enabled = false;
        mesh.enabled = false;
        yield return new WaitForSeconds(0.06f);
        light.enabled = true;
        mesh.enabled = true;
        yield return new WaitForSeconds(num);
        initiated = false;
    }

}
