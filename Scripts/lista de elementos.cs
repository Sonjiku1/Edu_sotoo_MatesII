using JetBrains.Annotations;
using System;
using UnityEngine;

public class listadeelementos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // encontrar una lista de elementos

        int[] numeros = { 8, 3, 10, 1, 5 };

        Array.Sort(numeros);

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
