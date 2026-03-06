using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonImprove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;
    [SerializeField] private float hoverScale = 1.15f;

    void Start() => originalScale = transform.localScale;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // El botón se agranda un poquito al pasar el mouse
        transform.localScale = originalScale * hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Vuelve a su tamaño normal
        transform.localScale = originalScale;
    }
}
