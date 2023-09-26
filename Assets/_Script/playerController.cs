using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // public zombieController zombiecontrler;

    float fireTime = 0.3f;
    float lastFireTime = 0;

    void Start()
    {
        // zombiecontrler = FindObjectOfType<zombieController>();
        UpdateFireTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    private void UpdateFireTime()
    {
        lastFireTime = Time.time;
    }
    void Fire()
    {
        if(Time.time >=lastFireTime + fireTime)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag.Equals("Zombie"))
                {

                    //zombiecontrler.GetHit(2);
                    hit.transform.gameObject.GetComponent<zombieController>().GetHit(3);

                }

            }
            UpdateFireTime();
        }


    }
    // Start is called before the first frame update

}
