using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorHoveredAnimationDOTween : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private const float _stepValue = 0.2f;
    private float _defaultScale;
    private Tween _currentTween;

    private void Awake()
    {
        _defaultScale = transform.localScale.x;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _currentTween?.Kill();
        _currentTween = transform.DOScale(_defaultScale + _stepValue, 0.25f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _currentTween?.Kill();
        _currentTween = transform.DOScale(_defaultScale, 0.25f);
    }
}
