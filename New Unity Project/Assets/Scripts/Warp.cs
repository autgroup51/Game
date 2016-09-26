using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
    public Transform warpTarget;
	
    IEnumerator OnTriggerEnter2D (Collider2D other)
    {
        ScreenFader st = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
        yield return StartCoroutine(st.FadeToBlack());

        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;
        yield return StartCoroutine(st.FadeToClear());
    }
}
