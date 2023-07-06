using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [SerializeField] Camera mainCam;
    [SerializeField] float giveDamageOf = 10f;
    float shootingRange = 100f;

    //variables for particle system
    [SerializeField] private ParticleSystem muzzle;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            muzzle.Play();
        }
    }



    private void Shoot()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hitInfo, shootingRange))
        {
            Debug.Log(hitInfo.transform.name);
        }
    }
}
