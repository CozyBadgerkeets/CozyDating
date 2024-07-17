using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public float Interest;
    [SerializeField] public float Favorability;
    // 9 endings broken down to roughly 9 CGs

    // Start is called before the first frame update

    void Start()
    {
        Interest = 50;
        Favorability = 50;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeInterest(float value)
    {
        Interest += value;
        Debug.Log(Interest);
    }

    public void changeFavorability(float value)
    {
        Favorability += value;
        Debug.Log(Favorability);
    }
}
