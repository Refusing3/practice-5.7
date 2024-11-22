using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FristOccurence : MonoBehaviour
{
    private void Start()
    {
        //int[] numbers = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        //int index = Array.IndexOf(numbers, 34);
        int[] numbers = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int index = Array.IndexOf(numbers, 55);
        Debug.Log($"индекс первого вхождения = {index}");
    }
}
