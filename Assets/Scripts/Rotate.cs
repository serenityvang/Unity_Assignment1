using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform sun;
    public float sunRotationSpeed = 10.0f;

    //Earth pivot and rotation
    public Transform earthPivot;
    public Transform earth;
    public float earthOrbitSpeed = 10.0f;
    public float earthRotationSpeed = 30.0f;

    //Moon pivot and rotation
    public Transform moonPivot;
    public Transform moon;
    public float moonOrbitSpeed = 20.0f;
    public float moonRotationSpeed = 40.0f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RotateSun();
        OrbitEarth();
        OrbitMoon();
    }

    void RotateSun()
    {
        sun.Rotate(Vector3.up, sunRotationSpeed * Time.deltaTime);
    }

    void OrbitEarth()
    {
        earthPivot.Rotate(Vector3.up, earthOrbitSpeed * Time.deltaTime);

        earth.Rotate(Vector3.up, earthRotationSpeed * Time.deltaTime);
    }

    void OrbitMoon()
    {
        moonPivot.Rotate(Vector3.up, moonOrbitSpeed * Time.deltaTime);
        moon.Rotate(Vector3.up, moonRotationSpeed * Time.deltaTime);
    }
}
