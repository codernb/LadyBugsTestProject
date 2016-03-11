using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    private Vector3 RotateVector = new Vector3(0, 1, 0);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateVector);
    }
}
