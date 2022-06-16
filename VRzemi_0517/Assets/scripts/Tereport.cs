using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tereport : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public GameObject Rcon;
    public float player_Height;
    public float speed;
    public GameObject tereport_icon;
    public GameObject point;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {        
     lineRenderer.useWorldSpace = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Ray ray = new Ray(Rcon.transform.position,Rcon.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            lineRenderer.SetPosition(0, Rcon.transform.position);
            lineRenderer.SetPosition(1, hit.point);
            lineRenderer.startWidth = 0.1f;
            lineRenderer.endWidth = 0.1f;
        }
        Debug.DrawRay(Rcon.transform.position, Rcon.transform.forward);
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)&&Physics.Raycast(ray,out hit))
        {   
            if (hit.collider.gameObject.tag=="ground")
            {
                this.transform.position = new Vector3(hit.point.x,hit.point.y+player_Height,hit.point.z);
            }

        }

        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger) &&Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "ball")
            {
                lineRenderer.gameObject.SetActive(false);
                ball.transform.position = point.transform.position;
                if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
                { }
            }
        }
        else
        {
            lineRenderer.gameObject.SetActive(true);
        }
        this.transform.Rotate(0, horizontal*speed, 0);
    }
}
