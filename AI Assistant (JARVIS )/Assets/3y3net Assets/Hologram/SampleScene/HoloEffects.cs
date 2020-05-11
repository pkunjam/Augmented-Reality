using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoloEffects : MonoBehaviour {
    public GameObject car, plane;
    public GameObject HoloLine1, HoloLine2, HoloOrigin;
    public int drawSteps = 500;

    MeshFilter[] mfs;
    int totalVert, currentVert = 0, deltaVert, halfVert;
    LineRenderer lr1, lr2;

    Transform current;

    bool projecting = false;

    // Use this for initialization
    void Start () {
        projecting = false;
        ProjectCar();
    }

    public void ProjectCar()
    {
        if(plane.activeSelf)
            plane.GetComponent<HoloController>().HideHologram();
        projecting = false;
        current = car.transform;
        plane.SetActive(false);
        car.SetActive(true);
        car.GetComponent<HoloController>().ShowHologram();
        StartProjection(car);
        projecting = true;
    }

    public void ProjectPlane()
    {
        if(car.activeSelf)
            car.GetComponent<HoloController>().HideHologram();
        projecting = false;
        current = plane.transform;
        plane.SetActive(true);
        plane.GetComponent<HoloController>().ShowHologram();
        car.SetActive(false);
        StartProjection(plane);
        projecting = true;
    }

    public void StopProjecting()
    {
        plane.GetComponent<HoloController>().HideHologram();
        car.GetComponent<HoloController>().HideHologram();
        projecting = false;
        lr1.SetPosition(1, HoloOrigin.transform.position);
        lr2.SetPosition(1, HoloOrigin.transform.position);
    }

    void StartProjection(GameObject go)
    {
        currentVert = 0;
        totalVert = 0;
        mfs = go.GetComponentsInChildren<MeshFilter>();
        for (int i = 0; i < mfs.Length; i++)
            totalVert += mfs[i].mesh.vertexCount;
        lr1 = HoloLine1.GetComponent<LineRenderer>();
        lr1.SetPosition(0, HoloOrigin.transform.position);
        lr2 = HoloLine2.GetComponent<LineRenderer>();
        lr2.SetPosition(0, HoloOrigin.transform.position);
        halfVert = totalVert / 2;
        deltaVert = totalVert / drawSteps;
        if (deltaVert <= 0)
            deltaVert = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (!projecting)
            return;

        lr1.SetPosition(1, GetVertextAt(currentVert));
        int pos2 = (currentVert + halfVert) % totalVert;
        lr2.SetPosition(1, GetVertextAt(pos2));
        currentVert += deltaVert;
        if (currentVert > totalVert)
        {
            currentVert = 0;
        }
	}

    Vector3 GetVertextAt(int index)
    {
        int k = 0;
        for (int i = 0; i < mfs.Length; i++)
        {
            if (index < k + mfs[i].mesh.vertexCount)
                return current.TransformPoint(mfs[i].mesh.vertices[index - k]);
            k += mfs[i].mesh.vertexCount;
        }
        return Vector3.zero;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 30), "Project Car"))
        {
            ProjectCar();
        }

        if (GUI.Button(new Rect(10, 50, 150, 30), "Project Bust"))
        {
            ProjectPlane();
        }

        if (GUI.Button(new Rect(10, 90, 150, 30), "Stop projection"))
        {
            StopProjecting();
        }
    }
}
