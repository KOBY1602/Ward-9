using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    public GameObject box;
    public Transform startPos;
    public Transform endPos;

    public float lerpDuration = 2f;

    private float timeElapsed;
    private bool isLerping = false;
    public float startDelay = 1f;

    private Coroutine lerpRoutine;

    // Start is called before the first frame update
    void Start()
    {
        StartLerp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartLerp()
    {
        if (lerpRoutine != null)
            StopCoroutine(lerpRoutine);

        lerpRoutine = StartCoroutine(LerpAfterDelay());
    }

    private IEnumerator LerpAfterDelay()
    {
        // Wait before starting
        yield return new WaitForSeconds(startDelay);

        float elapsedTime = 0f;

        while (elapsedTime < lerpDuration)
        {
            float t = elapsedTime / lerpDuration;
            transform.position = Vector3.Lerp(startPos.position, endPos.position, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure final position is exact
        transform.position = endPos.position;
    }
}
