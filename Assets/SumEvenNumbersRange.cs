using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Xml.Serialization;


public class SumEvenNumbers : MonoBehaviour
{
    private void Start()
    {
        int sum = CalculateSum (7, 21);
        Debug.Log($"Сумма четных чискл от 7 до 21: {sum}");
    }

    private int CalculateSum(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++) 
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
    
}
