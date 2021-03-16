using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColSwitch : MonoBehaviour
{
    public Image colBlock;
    public Color[] col;
    public int currentCol = 0;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCol();
        }
    }

    public void SwitchCol()
    {
        colBlock.color = col[currentCol];
        if (currentCol == col.Length -1 )
        {
            currentCol = 0;
        }
        else
        {
            currentCol += 1;
        }
    }

}
