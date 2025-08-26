using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Cube : MonoBehaviour
{
    public Action<int> UpdateCountdown;

    [SerializeField] private GameObject effect;
    [SerializeField] private GameObject target;
    public int countdown = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartCountdown());
    }


    IEnumerator StartCountdown()
    {
        while(countdown > 0)
        {
            yield return new WaitForSecondsRealtime(1);
            countdown--;
            UpdateCountdown?.Invoke(countdown);
        }

        ExplodeKitten();
    }

    void ExplodeKitten()
    {
        effect.SetActive(true);
        target.SetActive(false);
    }
}
