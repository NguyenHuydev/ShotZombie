using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaytion : MonoBehaviour
{
    Vector3 taget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtCursor();
    }

    void LookAtCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        
        if(Physics.Raycast(ray, out hit))
        {
            taget = hit.point;
        }

        transform.LookAt(taget);
    }
}
