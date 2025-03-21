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
            GameObject prefeb = Instantiate(Resources.Load<GameObject>(obstacleName[Random.Range(0, obstacleName.Count)]), gameObject.transform);

            prefeb.SetActive(false);

            obstacle.Add(prefeb);

            Debug.Log(obstacle.Capacity);
        }


    }

    public bool ExamineActive()
    {
        for (int i = 0; i<obstacle.Count; i++)
        {
            if(obstacle[i].activeSelf == false)
            {
                return false;
            }
        }
    
        return false;
    }

    public IEnumerator ActiveObstacle() {

        int count = 0;

        while (true)
        {
            yield return new WaitForSeconds(2.5f);

            // 현재 게임 오브젝트가 활성화되어 있는 지 확인합니다.
            while (obstacle[random].activeSelf == true)
            {
                // 현재 리스트에 있는 모든 게임 오브젝트가 활성화되어 있는 지 확인합니다.
                random = (random - 1) % obstacle.Count;

                if (ExamineActive())
                {
                    // 모든 게임 오브젝트가 활성화되어 있다면 게임 오브젝트를 새로 생성한 다음
                    // 
                    GameObject clone = Instantiate(Resources.Load<GameObject>(obstacleName[Random.Range(0, obstacleName.Count)]), gameObject.transform);
                
                    clone.SetActive(true);
                
                    obstacle.Add(clone);
                
                }
            }



            obstacle[random].SetActive(false);

            count++;

        }

    }
}
