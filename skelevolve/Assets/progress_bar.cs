using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode()]
public class progress_bar : MonoBehaviour
{
    public int maximum;
    public int current;
    public image mask;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void GetCurrentFill()
    {
        if (maximum == 0)
        {
            mask.fillAmount = 0;
        }
        else
        {
            mask.fillAmount = (float)current / (float)maximum;
            mask.fillAmount = fillAmount;
        }
    }



}
