using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        cube.transform.Rotate(new Vector3(1, 0, 0), 45);
        cube.transform.Rotate(new Vector3(0, 1, 0), 45);
    }

    void Update() {
}
}