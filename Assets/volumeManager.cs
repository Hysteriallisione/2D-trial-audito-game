using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class volumeManager : MonoBehaviour
{
    public Renderer[] renderers;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Renderer material in renderers)
        {
            Material.Render();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
