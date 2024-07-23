using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 9 endings broken down to roughly 9 CGs
    [SerializeField] public float Interest;
    [SerializeField] public float Favorability;

    // Start is called before the first frame update

    void Start()
    {
        Interest = 50;
        Favorability = 50;    
    }

    // Update is called once per frame
    void Update()
    {
        // will probably need as its in other scenes
    }
    
    public void ChangeInterest(float value)
    {
        // change this value in UNITY Inspector for whatever the option might be
        Interest += value;
        Debug.Log(Interest);
    }

    public void changeFavorability(float value)
    {
        // change this value in UNITY Inspector for whatever the option might be
        Favorability += value;
        Debug.Log(Favorability);
    }
}
