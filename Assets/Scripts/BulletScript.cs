using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{


    KillCounter killCounterScript;

private void Start() 
{
    killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
}
    

    private void OnCollisionEnter(Collision collision) 
{
    if(collision.transform.tag == "Enemy")
    {
        Destroy(collision.gameObject);
        killCounterScript.AddKill();
    }

}
}
