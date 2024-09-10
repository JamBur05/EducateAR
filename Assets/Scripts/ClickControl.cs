using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ClickControl : MonoBehaviour
{

    [SerializeField]
    Material mymat;
    List<InfoBehaviour> infos = new List<InfoBehaviour>();

    string btnName;
    void Start()
    {
        infos = FindObjectsOfType<InfoBehaviour>().ToList();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                GameObject go = Hit.collider.gameObject;

                if (go.CompareTag("hasInfo"))
                {
                    //clickCount++;
                    OpenInfo(go.GetComponent<InfoBehaviour>());
                    
                }
            }
        }
     }

    void OpenInfo(InfoBehaviour desiredInfo)
    {
        foreach (InfoBehaviour info in infos)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBehaviour info in infos)
        {
            info.CloseInfo();
        }
    }
}
