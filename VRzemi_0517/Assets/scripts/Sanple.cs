using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanple : MonoBehaviour
{
    private float holizontal;
    private float vartical;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
            }

    // Update is called once per frame
    void Update()
    {
        holizontal = Input.GetAxis("Horizontal");
        vartical = Input.GetAxis("Vertical");
        transform.position += new Vector3((holizontal*speed)*Time.deltaTime, 0, (vartical*speed)*Time.deltaTime);
    }
}
