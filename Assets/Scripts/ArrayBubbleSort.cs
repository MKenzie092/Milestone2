using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayBubbleSort : MonoBehaviour
{

    int[] number_Array = { 5, 3, 8, 4, 2 };
    void Start()
    {
        Debug.Log("Original Array: " + ArrayToString(number_Array)); 
        Bubble_Sort_Array(number_Array); 
        Debug.Log("Sorted Array: " + ArrayToString(number_Array)); 

    }

  
    string ArrayToString(int[] array) 
    {
        return string.Join(", ", array); 
    }

    void Bubble_Sort_Array(int[] array) 
    {
        int n = array.Length; 
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i] < array[j]) 
                {
                    int temp = array[j]; 
                    array[j] = array[i]; 
                    array[i] = temp; 
                }
            }
        }
    }
}
