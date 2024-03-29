
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent repeatEvent;
    
    public int counterNum = 3;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        while (counterNum > 0)
        {
            Debug.Log(counterNum);
            yield return wfsObj;
            repeatEvent.Invoke();
            counterNum--;
        }
    }
}
