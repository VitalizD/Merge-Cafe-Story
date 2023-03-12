using Gameplay.Field;
using Service;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    [RequireComponent(typeof(Animation))]
    public class InformationWindow : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;
        [SerializeField] private TextMeshProUGUI _title;
        [SerializeField] private TextMeshProUGUI _level;
        [SerializeField] private TextMeshProUGUI _description;
        [SerializeField] private TextMeshProUGUI _instruction;
        [SerializeField] private Transform _producedItemsGroup;
        [SerializeField] private GameObject _producedItemPrefab;
        [SerializeField] private Transform _leftScreenPoint;
        [SerializeField] private Transform _rightScreenPoint;

        private Camera _mainCamera;
        private Animation _animation;
        private readonly List<GameObject> _producedItems = new();

        public void ShowItem(string title, int level, string description, string instruction)
        {
            ClearProducedItemsList();
            Show(title, level, description, instruction);
            //_producedItemsGroup.gameObject.SetActive(false);
        }

        public void ShowGenerator(string title, int level, string description, Sprite[] producedItemSprites,
            string instruction = null)
        {
            if (instruction == null || instruction == "")
            {
                instruction = "����� ��� ��������� ������������.\n\n";
                if (level == 1 || level == 4)
                    instruction += "������, ����� ������� ����������� ��������.";
                else
                    instruction += "������, ����� �������� ������� ������������ ���������.";
                instruction += "\n\n����������:";
            }
            ClearProducedItemsList();
            Show(title, level, description, instruction);
            //_producedItemsGroup.gameObject.SetActive(true);

            if (producedItemSprites == null)
                return;

            foreach (var sprite in producedItemSprites)
            {
                var newItem = Instantiate(_producedItemPrefab, _producedItemsGroup);
                if (newItem.TryGetComponent<Image>(out var image))
                    image.sprite = sprite;
                _producedItems.Add(newItem);
            }
        }

        public void Hide()
        {
            _panel.SetActive(false);
            _animation.Stop();
        }

        private void Awake()
        {
            _mainCamera = Camera.main;
            _animation = GetComponent<Animation>();
        }

        private void Show(string title, int level, string description, string instruction)
        {
            _panel.SetActive(true);

            _title.text = title;
            _level.text = $"������� {level}";
            _description.text = description;
            _instruction.text = instruction;

            SetWindowPosition();

            // ���������� ����� �������, ����� Content Size Filter ���������.
            StartCoroutine(UpdateWindow());

            _animation.Play();
        }

        private System.Collections.IEnumerator UpdateWindow()
        {
            yield return new WaitForSeconds(0.01f);
            _panel.SetActive(false);
            _panel.SetActive(true);
        }

        private void SetWindowPosition()
        {
            var mouseViewPosition = _mainCamera.ScreenToViewportPoint(Input.mousePosition);

            if (mouseViewPosition.x <= 0.5f)
                transform.position = _rightScreenPoint.position;
            else
                transform.position = _leftScreenPoint.position;
        }

        private void ClearProducedItemsList()
        {
            foreach (var producedItem in _producedItems)
                Destroy(producedItem);
            _producedItems.Clear();
        }
    }
}