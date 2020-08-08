using System.Collections;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public float AnimationRate = 0.024f;
    public Sprite[] EffectSprites;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if(EffectSprites == null || EffectSprites.Length == 0)
        {
            return;
        }

        StartCoroutine(IPlayAnimation());
    }

    private IEnumerator IPlayAnimation()
    {
        spriteRenderer.sprite = EffectSprites[0];

        while(gameObject.activeSelf)
        {
            for(int i = 0; i < EffectSprites.Length; i++)
            {
                spriteRenderer.sprite = EffectSprites[i];
                yield return new WaitForSeconds(AnimationRate);
            }
        }
    }
}
