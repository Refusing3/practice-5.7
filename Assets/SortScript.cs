using UnityEngine;
using System; // Для использования string.Join

public class SelectionSortScript : MonoBehaviour
{
    private int[] numbers = { 81, 22, 13, 34, 10, 15, 26, 71, 68 };

    void Start()
    {
       
        Debug.Log("Original Array: " + ArrayToString(numbers));
        
        SelectionSort(numbers);
        Debug.Log("Sorted Array: " + ArrayToString(numbers));
    }

    private void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    private string ArrayToString(int[] array)
    {
        return string.Join(", ", array);
    }
}