using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    [SerializeField, Range(1, 20)] protected int hitsToBreak;
    [SerializeField, Range(1, 20)] protected int pointValue;
    protected int curHitsToBreak = 0;


    [SerializeField] ParticleSystem HitpsPrefab;

    private void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }
    public void Break(int aDamage)
    {
        HitpsPrefab.Play();
        curHitsToBreak -= aDamage;

        if(curHitsToBreak <= 0)
        {
            BreakBrick();
        }
    }

    protected void BreakBrick()
    {
        GameManager.Instance.AddScore(pointValue);
       // Instantiate(HitpsPrefab).GetComponent<ParticleSystem>().Play();
        Destroy(gameObject);

    }
}
