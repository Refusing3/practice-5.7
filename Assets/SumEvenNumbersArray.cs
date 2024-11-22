using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class SumEvenNumbersArray : MonoBehaviour
{
  private void Start()
    {
        int[] array = { 54, 34, 87, 12, 56, 27, 66, 93, 10, 54 };
        int evenSum = CalculateEvenSum(array);
        Debug.Log($"массив: {string.Join(", ", array)}");
        Debug.Log($"Сумма четных чисел в массиве: {evenSum}");

    }
    private int CalculateEvenSum(int[] array)
    {
        int sum = 0; 

        foreach (int number in array) 
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }

        return sum; 
    }
}