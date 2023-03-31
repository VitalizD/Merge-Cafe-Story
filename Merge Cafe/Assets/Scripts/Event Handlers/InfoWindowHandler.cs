using Enums;
using Gameplay;
using Gameplay.Field;
using Gameplay.ItemGenerators;
using Service;
using System;
using UnityEngine;

namespace EventHandlers
{
    [RequireComponent(typeof(InformationWindow))]
    public class InfoWindowHandler : MonoBehaviour
    {
        private const string _highlightColor = "white";

        private InformationWindow _informationWindow;

        public static event Func<ItemType, bool> IsGenerator;
        public static event Func<ItemType, int, bool> IsGeneratorMaxLevel;
        public static event Func<ItemType, int> GetGeneratorLevel;
        public static event Func<ItemType, Sprite[]> GetProducedItemSprites;

        private void Awake()
        {
            _informationWindow = GetComponent<InformationWindow>();
        }

        private void OnEnable()
        {
            Item.CursorHoveredMovableItem += OnCursorHoveredItem;
            Item.CursorHoveredNotMovableItem += OnCursorHoveredItem;
            Item.CursorLeftItem += _informationWindow.Hide;
            Upgradable.CursorHoveredGenerator += OnCursorHoveredGenerator;
            Upgradable.CursorLeftGenerator += _informationWindow.Hide;
        }

        private void OnDisable()
        {
            Item.CursorHoveredMovableItem -= OnCursorHoveredItem;
            Item.CursorHoveredNotMovableItem -= OnCursorHoveredItem;
            Item.CursorLeftItem -= _informationWindow.Hide;
            Upgradable.CursorHoveredGenerator -= OnCursorHoveredGenerator;
            Upgradable.CursorLeftGenerator -= _informationWindow.Hide;
        }

        private void OnCursorHoveredItem(ItemType type, int level)
        {
            var storage = GameStorage.Instance;
            var itemDescription = Translation.GetItemDescription(type, level);
            var instruction = "";
            var maxLevel = storage.IsItemMaxLevel(type, level);
            Translation.ItemDescription nextDescription = null;

            if (!maxLevel)
                nextDescription = Translation.GetItemDescription(type, level + 1);

            var isGenerator = IsGenerator?.Invoke(type);
            if (isGenerator.GetValueOrDefault())
            {
                var isGeneratorMaxLevel = IsGeneratorMaxLevel?.Invoke(type, level);
                if (isGeneratorMaxLevel.GetValueOrDefault())
                    instruction = $"�������� �� ������������ <color={_highlightColor}>�{itemDescription.Title}�</color>, ����� �������� ���.\n\n" +
                        $"���� ������� ������ ���������.";
                else
                {
                    var currentLevel = GetGeneratorLevel?.Invoke(type);
                    var titleNextLevel = Translation.GetItemDescription(type, level + 1).Title;
                    var titleNeedLevel = Translation.GetItemDescription(type, currentLevel.GetValueOrDefault()).Title;
                    instruction = $"��������, ����� �������� <color={_highlightColor}>�{titleNextLevel}� {level + 1}-�� ������</color>.\n\n" +
                        $"������ <color={_highlightColor}>�{titleNeedLevel}� {currentLevel.GetValueOrDefault()}-�� ������</color>, ����� �������� ������������ <color={_highlightColor}>�{titleNeedLevel}�</color>.\n\n" +
                        $"���� ������� ������ ���������.";
                }
            }
            else if (type == ItemType.Brilliant)
            {
                var currencyCount = storage.GetBrilliantsRewardByItemlevel(level);
                var brilliantWord = Translation.PluralizeWord(currencyCount, "��������", "���������", "����������");
                if (maxLevel)
                    instruction = $"�����, ����� �������� {currencyCount} {brilliantWord}.";
                else
                    instruction = $"�����, ����� �������� {currencyCount} {brilliantWord}, " +
                        $"��� ��������, ����� �� ����� ������.";
            }
            else if (type == ItemType.Star)
            {
                var currencyCount = storage.GetStarsRewardByItemLevel(level);
                var starWord = Translation.PluralizeWord(currencyCount, "������", "������", "����");
                if (maxLevel)
                    instruction = $"�����, ����� �������� {currencyCount} {starWord}.";
                else
                    instruction = $"�����, ����� �������� {currencyCount} {starWord}, " +
                        $"��� ��������, ����� �� ����� ������.";
            }
            else if (type == ItemType.Present)
            {
                if (maxLevel)
                    instruction = "�����, ����� �������.";
                else
                    instruction = "�����, ����� �������, ��� ��������, ����� �������� ����� ������ �������.";
            }
            else if (type == ItemType.OpenPresent)
                instruction = "�����, ����� �������� �������!";
            else if (type == ItemType.Key)
            {
                if (maxLevel)
                    instruction = $"�������� �� ����� {level}-�� ������, ����� �������������� ������.";
                else
                    instruction = $"�������� �� ����� {level}-�� ������, ����� �������������� ������, " +
                        $"��� ��������, ����� ��������� ����� ����� ������� �������.";
            }
            else if (type == ItemType.Lock)
                instruction = $"�������� ���� ���� {level}-�� ������, ����� �������������� ������.";
            else if (type == ItemType.Box)
            {
                if (maxLevel)
                    instruction = "�����, ����� �������� ������� ������������� ������, ����������� ��� ���������� ������.";
                else if (level == 2)
                    instruction = $"�����, ����� �������� ��������� �������, ����������� ��� ���������� ������, ��� ��������, ����� �������� �{nextDescription.Title}�.";
                else if (level == 1)
                    instruction = $"��������, ����� �������� �{nextDescription.Title}�.";
            }
            else if (type == ItemType.Energy)
            {
                var energyCount = GameStorage.Instance.GetEnergyRewardByItemlevel(level);
                if (maxLevel)
                    instruction = $"�������� �� ���������, ����� �������� ��� (������ ������ �� {energyCount} " +
                        $"{Translation.PluralizeWord(energyCount, "�������", "��������", "���������")}).";
                else
                instruction = $"�������� �� ���������, ����� �������� ��� (������ ������ �� {energyCount} " +
                    $"{Translation.PluralizeWord(energyCount, "�������", "��������", "���������")}), ��� ��������, " +
                    $"����� ������� ������.";


            }
            else
            {
                if (maxLevel)
                    instruction = $"�������� �� ���� ������, ����� ��������� ���, ���� �� �������� �{itemDescription.Title}�.";
                else
                    instruction = $"�������� �� ���� ������, ����� ��������� ���, ���� �� �������� �{itemDescription.Title}�, ��� ��������, ����� �������� �{nextDescription.Title}�.";
            }

            _informationWindow.ShowItem(itemDescription.Title, level, itemDescription.Description, instruction);
        }

        private void OnCursorHoveredGenerator(ItemType type, int level)
        {
            var itemDescription = Translation.GetItemDescription(type, level);

            if (type == ItemType.TrashCan)
            {
                var instruction = "�������� ���� �������, ����� ��������� ���.\n\n������, ����� ����� ���� ��������� ��������.";
                if (level > 2)
                    instruction = "�������� ���� �������, ����� ������� ���.\n\n������, ����� ������� ��������� ������ �����������.";
                _informationWindow.ShowGenerator(itemDescription.Title, level, itemDescription.Description, null, instruction);
            }
            else
            {
                _informationWindow.ShowGenerator(itemDescription.Title, level,
                    itemDescription.Description, GetProducedItemSprites?.Invoke(type));
            }
        }
    }
}
