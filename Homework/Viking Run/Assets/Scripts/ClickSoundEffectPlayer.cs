using UnityEngine;
using UnityEngine.EventSystems;

public class ClickSoundEffectPlayer : MonoBehaviour,IPointerClickHandler
{
    public GameObject SoundEffect;
    public AudioSource audioSource;

    private void Awake()
    {
        SoundEffect = GameObject.Find("ClickSoundEffect");
        audioSource = SoundEffect.GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData e)
    {
        audioSource.Play();
    }
}
