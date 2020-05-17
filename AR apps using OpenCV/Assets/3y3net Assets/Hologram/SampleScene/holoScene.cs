using UnityEngine;
using System.Collections;

public class holoScene : MonoBehaviour {

    public GameObject theCar, theRobot, thePlane;
    public Transform carLookAt, robotLookAt, planeLookAt;

    private Transform from;
    private Transform to;
    public float speed = 0.1f;

    private bool isOn = false;

    public void ToCar()
    {
        from = Camera.main.transform;
        to = carLookAt;
    }

    public void ToRobot()
    {
        from = Camera.main.transform;
        to = robotLookAt;
    }

    public void ToPlane()
    {
        from = Camera.main.transform;
        to = planeLookAt;
    }

    void EffectOn()
    {
        theCar.GetComponent<HoloController>().ShowHologram();
        theRobot.GetComponent<HoloController>().ShowHologram();
        thePlane.GetComponent<HoloController>().ShowHologram();
    }

    void EffectOff()
    {
        theCar.GetComponent<HoloController>().HideHologram();
        theRobot.GetComponent<HoloController>().HideHologram();
        thePlane.GetComponent<HoloController>().HideHologram();
    }

    void Start()
    {
        from = Camera.main.transform;
        to = carLookAt;
    }

    void Update()
    {
        Camera.main.transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, Time.time * speed);
    }

    void OnGUI()
    {
        if (!isOn)
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "Holo Effect On"))
            {
                isOn = true;
                EffectOn();
            }
        }

        if (isOn)
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "Holo Effect Off"))
            {
                isOn = false;
                EffectOff();
            }
        }

        if (GUI.Button(new Rect(10, 50, 150, 30), "Car"))
        {
            ToCar();
        }
        if (GUI.Button(new Rect(10, 90, 150, 30), "Robot"))
        {
            ToRobot();
        }
        if (GUI.Button(new Rect(10, 130, 150, 30), "Plane"))
        {
            ToPlane();
        }


    }
}
