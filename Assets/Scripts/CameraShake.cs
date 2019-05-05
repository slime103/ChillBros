using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 OriginalPos = new Vector3(0, 0, -10);

    public void GetInitialPos(Vector3 InitialPos)
    {
        OriginalPos = InitialPos;
    }

    public IEnumerator Shake(float ShakeDuration, float magnitude)
    {
        float elapsedTime = 0.0f;

        while(elapsedTime < ShakeDuration)
        {
            float x = Random.Range(-1, 1) * magnitude;
            float y = Random.Range(-1, 1) * magnitude;

            transform.localPosition = new Vector3(OriginalPos.x + x, OriginalPos.y + y, -10);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = OriginalPos;
        Debug.Log(transform.localPosition);
    }
}
