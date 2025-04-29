using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senser : MonoBehaviour
{
    Battery battery;
    
    private void OnTriggerEnter(Collider other)
    {
        // 물리적이지 않은 충돌을 했을 때 호출되는 이벤트 함수
        if (other.CompareTag("Authorized"))
        {
            Debug.Log("OT Enter");
        }

    }

    private void OnTriggerStay(Collider other)
    {
        // 물리적이지 않은 충돌을 하고 있을 때 호출 되는 이벤트 함수

        battery = other.GetComponent<Battery>();

        if (battery != null)
        {
            battery.Increase();
        }

        Debug.Log("OnTrg Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        // 물리적이지 않은 충돌이 끝났을 때 호출되는 이벤트 함수
        Debug.Log("OnTrg Exit");
    }
}
