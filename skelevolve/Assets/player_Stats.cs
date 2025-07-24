using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

public class player_Stats : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 100;
    [SerializeField]
    private int currentHP;
    [SerializeField]
    private int maxMP = 100;
    [SerializeField]
    private int currentMP;
    // Start is called before the first frame update
    void Start()
    {
        this.currentHP = maxHP;
        this.currentMP = maxMP;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
