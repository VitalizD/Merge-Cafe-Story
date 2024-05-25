using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

namespace UI
{
    public class UIBar : MonoBehaviour
    {
        [SerializeField] private bool _smooth;
        [SerializeField] private Image bar;
        [SerializeField] private TextMeshProUGUI valueText;
        [SerializeField] private TextMeshProUGUI title;

        private Tween _currentTween;

        public bool Filled { get => bar.fillAmount >= 0.99f; }

        /// <param name="value">От 0 до 100</param>
        public void SetValue(float value)
        {
            value = Mathf.Clamp(value, 0f, 100f);
            if (_smooth)
            {
                _currentTween?.Kill();
                _currentTween = bar.DOFillAmount(value / 100.0f, 0.2f);
            }
            else
            {
                bar.fillAmount = value / 100f;
            }
            if (valueText != null)
                valueText.text = $"{(int)value} %";
        }

        public void SetTitle(string value)
        {
            if (title == null)
                return;

            title.text = value;
        }
    }
}