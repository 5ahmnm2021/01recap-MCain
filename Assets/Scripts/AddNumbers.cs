using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AddNumbers : MonoBehaviour
{
    public InputField textObj1;
    public InputField textObj2;
    public bool Result1;
    public int outInt1;
    public bool Result2;
    public int outInt2;

    public Text Placeholder1;
    public Text Placeholder2;
    public Text resultObj;

    public void CalculateResult()
    {
        Result1 = int.TryParse(textObj1.text, out outInt1);
        Result2 = int.TryParse(textObj2.text, out outInt2);

        if (Result1 && Result2)
        {
            textObj1.image.color = Color.white;
            textObj2.image.color = Color.white;
            resultObj.text = (outInt1 + outInt2).ToString();
        }

        else if (Result1 == false && Result2 == false)
        {
            textObj1.image.color = Color.red;
            textObj2.image.color = Color.red;
            Placeholder1.text = "please enter a valid number";
            Placeholder2.text = "please enter a valid number";
        }

        else if (Result1 == false)
        {
            textObj2.image.color = Color.white;
            textObj1.image.color = Color.red;
            Placeholder1.text = "please enter a valid number";
        }

        else if (Result2 == false)
        {
            textObj1.image.color = Color.white;
            textObj2.image.color = Color.red;
            Placeholder2.text = "please enter a valid number";
        }
    }

}
