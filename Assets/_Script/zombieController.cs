using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour
{
    // Start is called before the first frame update
    int healZombie;


    public void GetHit(int dame)
    {
        healZombie -= dame;
        if( healZombie <= 0)
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {
        healZombie = Random.Range(2, 4);
    }

    // Update is called once per frame
    void Update()
    {    
        
    }
}
