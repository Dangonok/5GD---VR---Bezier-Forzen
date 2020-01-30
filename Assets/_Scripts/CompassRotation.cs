using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassRotation : MonoBehaviour
{

    float x, y, z;
    [SerializeField] float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += Random.Range(-0.1f, 0.1f);
        y += Random.Range(-0.1f, 0.1f);
        z += Random.Range(-0.1f, 0.1f);

        x = Mathf.Clamp(x, -maxSpeed, maxSpeed);
        y = Mathf.Clamp(y, -maxSpeed, maxSpeed);
        z = Mathf.Clamp(z, -maxSpeed, maxSpeed);

        this.transform.Rotate(x, y, z);
    }
}
