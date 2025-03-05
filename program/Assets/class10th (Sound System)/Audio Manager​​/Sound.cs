using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] int random;
    [SerializeField] float time;
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
            yield return new WaitForSeconds(5.0f);

            AudioManager.Instance.Listener(audioClip);
        }



    }

}
