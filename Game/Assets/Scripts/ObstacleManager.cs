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

            // ���� ���� ������Ʈ�� Ȱ��ȭ�Ǿ� �ִ� �� Ȯ���մϴ�.
            while (obstacle[random].activeSelf == true)
            {
                // ���� ����Ʈ�� �ִ� ��� ���� ������Ʈ�� Ȱ��ȭ�Ǿ� �ִ� �� Ȯ���մϴ�.
                random = (random - 1) % obstacle.Count;

                if (ExamineActive())
                {
                    // ��� ���� ������Ʈ�� Ȱ��ȭ�Ǿ� �ִٸ� ���� ������Ʈ�� ���� ������ ����
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
