using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Instantiate(projectile, transform);
    }
}
