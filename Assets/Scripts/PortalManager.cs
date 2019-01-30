using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PortalManager : MonoBehaviour
{
    public GameObject MainCamera;

    public GameObject Sponza;

    // private Material PortalPlaneMaterial;
    // Start is called before the first frame update
    void Start()
    {
        // SponzaMaterials = Sponza.GetComponent<Renderer>().sharedMaterials;
    }

    // Update is called once per frame
    void OnTriggerStay(Collider collider)
    {
        Vector3 camPositionInPortalSpace = transform.InverseTransformPoint(MainCamera.transform.position);

        if(camPositionInPortalSpace.y < 0.5f)
        {
            // Disable Stencil test
            int numOfChildren = Sponza.transform.childCount;
            for (int i = 0; i < numOfChildren; ++i)
            {
                GameObject child = Sponza.transform.GetChild(i).gameObject;
                child.GetComponent<Renderer>().material.SetInt("_StencilComp", (int)CompareFunction.Always);
            }

        }
        else
        {
            //Enable stencil test

            int numOfChildren = Sponza.transform.childCount;
            for (int i = 0; i < numOfChildren; ++i)
            {
                GameObject child = Sponza.transform.GetChild(i).gameObject;
                child.GetComponent<Renderer>().material.SetInt("_StencilComp", (int)CompareFunction.Equal);
            }
        }
    }
}

