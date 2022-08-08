using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartComponent : MonoBehaviour
{
    [SerializeField] private int m_countDownTime = 3;

    public static event Action OnGameStart;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartTimeCount());
    }

    IEnumerator StartTimeCount()
    {
        for (int i = m_countDownTime; i > 0; i--)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1.0f);
            if (m_countDownTime == 0)
            {
                Debug.Log("开始");
                OnGameStart?.Invoke();
                this.gameObject.SetActive(false);
            }
        }
    }
}
