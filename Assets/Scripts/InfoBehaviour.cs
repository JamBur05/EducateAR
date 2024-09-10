using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{

    const float SPEED = 6F;

    [SerializeField]
    Transform SecitonInfo;

    Vector3 desiredScale = Vector3.zero;

    void Update()
    {
        SecitonInfo.localScale = Vector3.Lerp(SecitonInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void OpenInfo()
    {
        desiredScale = Vector3.one;
        Debug.Log("Opening Info!");
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
        Debug.Log("Closing Info!");

    }
}
