using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
    public GameObject CoinPrefab; // 코인 프리펩을 사용하겠다.

    public bool isActivate = true; // RandomBox가 활성화 되어 있는 상태다.
        
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("충돌 지점에서 벗어났습니다.");

        Instantiate(CoinPrefab, transform.position, Quaternion.identity);

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("충돌 진행 중입니다.");
    }

}