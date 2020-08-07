using UnityEngine;
using System.Collections;

public class ExampleNeedyModule : MonoBehaviour
{


    void Awake()
    {
        GetComponent<KMNeedyModule>().OnNeedyActivation += OnNeedyActivation;
        GetComponent<KMNeedyModule>().OnNeedyDeactivation += OnNeedyDeactivation;
        GetComponent<KMNeedyModule>().OnTimerExpired += OnTimerExpired;
    }

    protected bool Solve()
    {
        GetComponent<KMNeedyModule>().OnPass();

        return false;
    }

    protected void OnNeedyActivation()
    {

    }

    protected void OnNeedyDeactivation()
    {

    }

    protected void OnTimerExpired()
    {

    }

}