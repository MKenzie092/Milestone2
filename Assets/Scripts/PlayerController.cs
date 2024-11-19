using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] Enemies;
    public int currentIndex;
    public Vector3 enemyPosition;
    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentIndex < Enemies.Length)
            {
                currentIndex++;
                foreach (GameObject Enemy in Enemies)
                {
                    if (Enemy.GetComponent<EnemyController>().Index == currentIndex)
                    {
                        enemyPosition = Enemy.transform.position;
                    }
                }
                transform.LookAt(enemyPosition);
            }
            else
            {
                currentIndex = 0;
            }
            Debug.Log("Move");
        }
    }
}