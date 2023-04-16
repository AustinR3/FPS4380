using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Gun : MonoBehaviour
{

    private StarterAssetsInputs _input;
    // Start is called before the first frame update
    [SerializeField]
    public GameObject bulletPrefab;

    [SerializeField]
    public GameObject bulletPoint;


    float bulletSpeed = 1500;
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {

        //if(!PauseMenu.isPaused)
		//{
        if(_input.shoot)
        {
            Shoot();
            _input.shoot = false;

        }
        //}
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(bullet, 1);
       

    }



}