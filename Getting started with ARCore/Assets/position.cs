using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class position : MonoBehaviour
{
    public static int size;
    public GameObject[] obj = new GameObject[size];


    void Start()
    {
        //StartCoroutine(integrate());
        StartCoroutine(Parts());
    }


    //IEnumerator integrate()
    //{
    //    int i = 0;

    //    while (i < obj.Length)
    //    {
    //        obj[i].transform.position = Vector3.MoveTowards(obj[i].transform.position, Vector3.zero, 3 * Time.deltaTime);
    //        i++;

    //        yield return new WaitForSeconds(0.3f);
    //    }
    //}

    IEnumerator MoveTargetToDestinations(GameObject[] gameObjects, float speed)
    {
        foreach (var gameObject in gameObjects)
        {
            while (true)
            {
                if (Vector3.Distance(gameObject.transform.position, Vector3.zero) <= 0)
                    break;

                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, Vector3.zero, speed * Time.deltaTime);
                yield return null;
            }
        }
    }

    IEnumerator Parts()
    {
        yield return MoveTargetToDestinations(obj,4);
    }

}