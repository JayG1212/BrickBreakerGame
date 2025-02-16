using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
  //  [SerializeField] protected List<BreakableBrick> bricks;
    [SerializeField] protected GameObject canvasItem;
    // Methods

    private void Update()
    {
        EndRound();
    }
    private void Awake()
    {
        RoundManager[] gOs = FindObjectsOfType<RoundManager>();

        if(gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    protected void EndRound()
    {
        if(FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasItem.SetActive(true);
        }
    }
}
