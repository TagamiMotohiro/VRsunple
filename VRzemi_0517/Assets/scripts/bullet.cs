using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float power;
    GameObject rcon;
    // Start is called before the first frame update
    void Start()
    {
     rcon = GameObject.Find("Rcon");
     Rigidbody rb=this.gameObject.GetComponent<Rigidbody>();
     rb.AddForce(rcon.transform.forward * power, ForceMode.VelocityChange); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("��������");
        if(other.gameObject.tag =="field")
        {
            Debug.Log("�t�B�[���h�O");
            Destroy(this.gameObject);
        }
    }
}
