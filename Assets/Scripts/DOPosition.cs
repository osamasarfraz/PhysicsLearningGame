using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class DOPosition : MonoBehaviour
{
    public Vector3 moveTo;
    public float delay;
    public float duration;
    public Ease setEase;
    public float finishCallbackDelay;
    public UnityEvent OnTweenCompleteCallbacks;
    public bool simulateOnEnable = true;
    private void OnEnable()
    {
        if (simulateOnEnable)
        {
            Invoke("Animate", delay);
        }
    }
    public void Animate()
    {
        transform.DOLocalMove(moveTo, duration).SetEase(setEase).OnComplete(() => FinishCallback());
        //Invoke("FinishCallback", finishCallbackDelay);
    }

    void FinishCallback()
    {
        OnTweenCompleteCallbacks?.Invoke();
    }
}