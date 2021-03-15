using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform[] barrelEnd;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd[0].position, barrelEnd[0].rotation) as Rigidbody;
            projectile.AddForce(barrelEnd[0].forward * 10000*10000);
        }
    }
}
