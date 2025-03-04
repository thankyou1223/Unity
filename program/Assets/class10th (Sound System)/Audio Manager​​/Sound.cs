using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] int random;
    [SerializeField] float time;
    [SerializeField] AudioClip audioClip;

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5.0f);

            random = Random.Range(1, 6);

            Debug.Log(random);
        }



    }

}
