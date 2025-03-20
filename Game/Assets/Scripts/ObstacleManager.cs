using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] List<GameObject> obstacle;
    [SerializeField] List<string> obstacleName;

    [SerializeField] int creatCount = 5;
    [SerializeField] int random;
    

    // Start is called before the first frame update
    void Start()
    {
        obstacle.Capacity = 10;

        Create();

        StartCoroutine(ActiveObstacle());
    }

    public void Create()
    {
        for(int i = 0; i < creatCount; i++)
        {
            GameObject prefeb = Instantiate(Resources.Load<GameObject>(obstacleName[Random.Range(0, obstacleName.Count)]));

            prefeb.SetActive(false);

            obstacle.Add(prefeb);

            Debug.Log(obstacle.Capacity);
        }


    }

    public IEnumerator ActiveObstacle() {

        int count = 0;

        while (true)
        {
            yield return new WaitForSeconds(2.5f);

            random = Random.Range(0, obstacle.Count);

            while (obstacle[random].activeSelf == true)
            {
                random = (random - 1) % obstacle.Count;
            }

            obstacle[random].SetActive(false);

            count++;

        }

    }
}
