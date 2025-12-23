using UnityEngine;
using UnityEngine.UI;

public class RandomizeUISprite : MonoBehaviour
{
    [SerializeField] private Image uiImage;
    [SerializeField] private Sprite[] sprites;

    void Start()
    {
        if (sprites == null || sprites.Length == 0 || uiImage == null)
            return;

        uiImage.sprite = sprites[Random.Range(0, sprites.Length)];
    }
    public void RandomizeSprite()
    {
        uiImage.sprite = sprites[Random.Range(0, sprites.Length)];
    }
}
