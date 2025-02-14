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
        
    }
    private void Awake()
    {
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if(gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }
    public void RemoveBrick(BreakableBrick brick)
    {
    
        EndRound();
    }

    protected void EndRound()
    {
        if(FindObjectsOfType<BreakableBrick>().Length <= 0)
        {
            canvasItem.SetActive(true);
        }
    }
}
