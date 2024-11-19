using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject[] Enemies;
    int enemiesNumber;
    int[] enemiesHealth;
    int arrayInd = 0;
    void Start()
    {
        int enemiesNumber = Enemies.Length;
        enemiesHealth = new int[enemiesNumber];
        GettingHP();
        BubbleSortArray(enemiesHealth);
        AssignEnemiesToHealth();
        Debug.Log(ArrayToString(enemiesHealth));
    }
    void GettingHP()
    {
        foreach (GameObject Enemy in Enemies)
        {
            int HP = Enemy.GetComponent<EnemyController>().health;
            enemiesHealth[arrayInd] = HP;
            arrayInd += 1;
        }
    }
    void AssignEnemiesToHealth()
    {
        foreach (GameObject Enemy in Enemies)
        {
            if (Enemy.GetComponent<EnemyController>().health == enemiesHealth[0])
            {
                Enemy.GetComponent<EnemyController>().Index = 4;
            }
            else if (Enemy.GetComponent<EnemyController>().health == enemiesHealth[1])
            {
                Enemy.GetComponent<EnemyController>().Index = 3;
            }
            else if (Enemy.GetComponent<EnemyController>().health == enemiesHealth[2])
            {
                Enemy.GetComponent<EnemyController>().Index = 2;
            }
            else
            {
                Enemy.GetComponent<EnemyController>().Index = 1;
            }
        }
    }
    string ArrayToString(int[] array)
    {
        return string.Join(", ", array);
    }
    void BubbleSortArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
