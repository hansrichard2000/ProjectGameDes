using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public float positionX, positionY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            positionX = Random.Range(0f, 8.5f);
            positionY = Random.Range(-3f, 1f);

            var newEnemy = Instantiate(enemy);
            newEnemy.transform.position = new Vector3(positionX, positionY, 0);
        }

    }
}
