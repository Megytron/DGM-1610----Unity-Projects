using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Awake()
    {
        Debug.log("Example2.Awake() was called");
    }

    void Update()
    {
        if (activateGO == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("space key was pressed");
                GO.SetActive(true);
                activateGO = false;
            }
        }
    }
}
