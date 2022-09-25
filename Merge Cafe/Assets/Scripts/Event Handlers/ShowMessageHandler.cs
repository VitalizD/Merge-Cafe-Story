using UnityEngine;
using UI;
using Gameplay.Field;

namespace EventHandlers
{
    [RequireComponent(typeof(Message))]
    public class ShowMessageHandler : MonoBehaviour
    {
        private const string _maxLevelText = "������������ �������";
        private const string _presentClickedLeftMouseButtonText = "������ ������ ���� ��� ��������";
        private const string _noEmptyCellsText = "��� ��������� �����";

        private Message _message;

        private void Awake()
        {
            _message = GetComponent<Message>();
        }

        private void OnEnable()
        {
            Item.JoiningItemsOfMaxLevelTried += ShowMaxLevel;
            Present.PresentClickedLeftMouseButton += ShowRightMouseButtonForPresent;
        }

        private void OnDisable()
        {
            Item.JoiningItemsOfMaxLevelTried -= ShowMaxLevel;
            Present.PresentClickedLeftMouseButton -= ShowRightMouseButtonForPresent;
        }

        private void ShowMaxLevel()
        {
            _message.Show(_maxLevelText);
        }

        private void ShowRightMouseButtonForPresent()
        {
            _message.Show(_presentClickedLeftMouseButtonText);
        }
    }
}
