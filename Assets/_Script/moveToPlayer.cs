using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class moveToPlayer : MonoBehaviour
{
    public float speed;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        if (player == null) return;
        if(transform.position != player.transform.position)
        {
            transform.LookAt(player.transform.position);
            transform.position = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime);

            
        }
        
    }
}
