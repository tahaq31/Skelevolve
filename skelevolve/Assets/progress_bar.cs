using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class progress_bar : MonoBehaviour
{
    [SerializeField]
    private int maximum;
    [SerializeField]
    private int current;
    [SerializeField]
    private Image mask;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        {
            mask.fillAmount = (float)current / (float)maximum;
            mask.fillAmount = fillAmount;
        }
    }



}
