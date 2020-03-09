using System.Collections;
using UnityEngine;



public class cameraShake : MonoBehaviour
{
    public IEnumerator Shake (float duration, float magniutude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magniutude;
            float y = Random.Range(-1f, 1f) * magniutude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;

    }



}
