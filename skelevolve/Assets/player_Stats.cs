using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

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
    public TextMeshProUGUI hP;
    public TextMeshProUGUI mP;
    // Start is called before the first frame update
    void Start()
    {
        this.currentHP = maxHP;
        this.currentMP = maxMP;

    }

    // Update is called once per frame
    void Update()
    {
        hP.text = "Health : " + currentHP + "/" + maxMP;
        mP.text = "Mana : " + currentMP + "/" + maxMP;

        //del later
        if (Input.GetKeyUp(KeyCode.Space))
        {
            currentHP--;
        }
    }
    
    public int getHP()
    {
        return this.currentHP;
    }
}
