using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Image image;
    [SerializeField] private Sprite texture;

    void Start()
    {
        image = GetComponent<Image>();

        image.sprite = texture;
    }
}
