using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] WaitForSeconds waitForSeconds;

    private void Start()
    {
        waitForSeconds = new WaitForSeconds(5.0f);

        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while (true) 
        {
            yield return waitForSeconds;

            AudioManager.Instance.Listener(audioClip);
        }
    }

}
