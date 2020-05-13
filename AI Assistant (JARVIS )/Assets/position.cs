using UnityEngine;
using System.Collections;

public class position : MonoBehaviour
{
    public static int size;
    public GameObject[] obj = new GameObject[size];


    void Update()
    {
        StartCoroutine(integrate());
    }


    IEnumerator integrate()
    {
        int i = 0;

        while (i < obj.Length)
        {
            obj[i].transform.position = Vector3.MoveTowards(obj[i].transform.position, Vector3.zero, 3 * Time.deltaTime);
            i++;

            yield return new WaitForSeconds(1);
        }
    }

}