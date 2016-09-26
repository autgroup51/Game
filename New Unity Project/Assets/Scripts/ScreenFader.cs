using UnityEngine;
using System.Collections;

public class ScreenFader : MonoBehaviour {
    Animator anim;
    bool isFading = false;

    // Use this for initialization
    //Get the fader effect
    void Start () {
        anim = GetComponent<Animator>();

	}
    //Use IEnumerator for fader and when player process different level 
    //the screen will fade from black to colourless
    public IEnumerator FadeToClear()
    {
        isFading = true;
        anim.SetTrigger("Fadein");

        while (isFading)
            yield return null;
    }
    
    public IEnumerator FadeToBlack()
    {

        isFading = true;
        anim.SetTrigger("Fadeout");

        while (isFading)
            yield return null;
    }
    //If animation complete will be disable the fading effect.
	void AnimationComplete()
    {
        isFading = false;

    }
}
