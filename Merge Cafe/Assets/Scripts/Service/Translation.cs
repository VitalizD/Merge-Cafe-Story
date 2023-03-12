using Enums;
using System.Collections.Generic;

namespace Service
{
    public static class Translation
    {
        private static Dictionary<ItemType, Dictionary<int, ItemDescription>> _itemDescriptions = new Dictionary<ItemType, Dictionary<int, ItemDescription>>
        {
            [ItemType.BakeryProduct] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("�����", "���� ����� � ���, ��� ��� �� �����."),
                [2] = new ItemDescription("�����", "����-����-�����!"),
                [3] = new ItemDescription("��������", "�������, ������� � ����."),
                [4] = new ItemDescription("�������", "������� �� ����� � �����."),
                [5] = new ItemDescription("������� � �������", "� ��������������� ��������� ��������."),
                [6] = new ItemDescription("������", "� ��������� ������."),
                [7] = new ItemDescription("�����", "� ������� ��� ������ ��������� ����: � ����� �� ����������, � ������� ��� ���������."),
                [8] = new ItemDescription("������", "���� ������."),
                [9] = new ItemDescription("�����", "������� �� ������ ������ � �� ��� ������ �� ������."),
                [10] = new ItemDescription("�����", "����� � ��� �����, � ������� ����������� ���� ���������."),
            },
            [ItemType.BakeryProductWithCream] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("����", "�� �������, � �������."),
                [2] = new ItemDescription("����", "��� �������������, ������ ��� � ���������."),
                [3] = new ItemDescription("�����", "��, ������, �� ������ � ��� ����� � �������!"),
                [4] = new ItemDescription("����", "��� ���� ��������. ��� ������� :)"),
                [5] = new ItemDescription("������", "�� ���� ��� �������, � ���� ��� ��������!"),
                [6] = new ItemDescription("��������", "������� � ������ 50-�� ������������ �����."),
                [7] = new ItemDescription("������", "������� � ��� �����, ��� ���� �������."),
                [8] = new ItemDescription("�������", "��� ������ ��� �� �������� � �������, �������, ��������, ��������"),
                [9] = new ItemDescription("�����", "������� ��������."),
                [10] = new ItemDescription("����", "��, ��-�� ���� �� ����������� ����� ���������."),
            },
            [ItemType.Box] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������", "�������� �� �������� ��... ������. ������? �� � ���� �� �����."),
                [2] = new ItemDescription("�������", "� ����� ��� ������?"),
                [3] = new ItemDescription("���������� �������", "��� ����."),
            },
            [ItemType.Brilliant] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("��������", "��� ��� ��� �������?"),
                [2] = new ItemDescription("������� ����������", "� ����� ������?"),
                [3] = new ItemDescription("������ ����������", "��� ��� �� ������!"),
                [4] = new ItemDescription("���� ����������", "������ �� ����."),
                [5] = new ItemDescription("���� ����������", "�� �� ������!"),
            },
            [ItemType.Coffee] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("����� ����", "� ����� ��� ����������� ��������?"),
                [2] = new ItemDescription("����������� ����", "��������."),
                [3] = new ItemDescription("������ ����", "� ����������� ����������. ������������."),
                [4] = new ItemDescription("����� ����", "����� ����� ������ ������� � ���� ��������. ����� � ����!"),
                [5] = new ItemDescription("���� � ��������", "��� ����� ���� �������?"),
                [6] = new ItemDescription("�������� ��������", "������� � ��������. ��� �������� � ���� ��������."),
                [7] = new ItemDescription("��������", "�������� ��������."),
                [8] = new ItemDescription("�������� v2.0", "�������������� ������!"),
                [9] = new ItemDescription("��������", "������ � 3 ���� ������, ��� �������� ��������."),
                [10] = new ItemDescription("��������", "������ ���� � ���������."),
            },
            [ItemType.Energy] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("�������", "���� ��� �������� ��������."),
                [2] = new ItemDescription("�������������� �������", "������� ����� ����."),
                [3] = new ItemDescription("��������� �������", "����� ����������."),
                [4] = new ItemDescription("������� �������", "��������� � ������� ������..."),
                [5] = new ItemDescription("������ �������", "�� ����� ������� ���� ���������. ������ �, ���� ����� ���� � ��������!"),
            },
            [ItemType.FastFood] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("����", "����� �����, ������� � �������."),
                [2] = new ItemDescription("������ �����", "���������� ������, � � ��� ������?"),
                [3] = new ItemDescription("���������", "����� ������ ����..."),
                [4] = new ItemDescription("�������", "����� ��� ������."),
                [5] = new ItemDescription("���-���", "���, ����������, ��� ���-����, ���� � ��������, � ������ ���."),
                [6] = new ItemDescription("����", "������� ������� �� ��������."),
                [7] = new ItemDescription("�������", "������� ����� ���������."),
                [8] = new ItemDescription("������� ���������", "������������ � �������..."),
                [9] = new ItemDescription("�������� ���", "���� �� ���. � ��� � �����������, ���..."),
                [10] = new ItemDescription("�����", "���-���������"),
            },
            [ItemType.Key] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("����", "������� ��������� ���� ��� ����� �� ��������� ������."),
                [2] = new ItemDescription("������� ����", "�������� �� ��������."),
                [3] = new ItemDescription("���������� ����", "������� �� ������ ����� �� ����� �� ����, �������� ������ ������ �� ������."),
                [4] = new ItemDescription("�����-����", "� ����� ������ ����������?"),
                [5] = new ItemDescription("���� �� �����", "�� ����� ������� � ��� ����� �����-������� ����-������."),
            },
            [ItemType.Lock] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������� �����", "������ ����������� ���� � ���������� ���� � �������!"),
                [2] = new ItemDescription("������� �����", "��, ������, ���� ��������, ��� �������!"),
                [3] = new ItemDescription("���������� �����", "�������� �����������..."),
                [4] = new ItemDescription("�����-�����", "��� ������� ����������� ��� �� �������. �� ���� ����� ����������!"),
                [5] = new ItemDescription("����-�����", "����� �������. ��� �������� �� �����?"),
            },
            [ItemType.OpenPresent] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("����� �������", "�� ���� �� ����? ������ ������, ��� ��� ������!"),
                [2] = new ItemDescription("������� �������", "�� ��� ���? ��� ���� ���������!"),
                [3] = new ItemDescription("������� �������", "����� ������ �� ������� ����� ������� ��������� �� �������."),
            },
            [ItemType.Oven] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                [2] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                [3] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                [4] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                [5] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                [6] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                [6] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
            },
            [ItemType.Present] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("����� �������", "���� �������! � ����� ��������� � ������� ����������? ���, ��������! ����..."),
                [2] = new ItemDescription("������� �������", "��� �� ��� ����� �� ���� ��������."),
                [3] = new ItemDescription("������� �������", "������� �������������� ������."),
            },
            [ItemType.Star] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������", "���� ���� � ������."),
                [2] = new ItemDescription("���� ����", "����� ������ ����. ��� ������!"),
                [3] = new ItemDescription("������� ����", "������ �� �� ����� ������ �������� ����� �����?"),
                [4] = new ItemDescription("���� ����", "��� � ������� ������? ����, ��� ������?"),
                [5] = new ItemDescription("���� ����", "�� ������-�� �������� �������."),
            },
            [ItemType.Tea] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������ ����", "����� ��������� � �����������."),
                [2] = new ItemDescription("������ �������", "��������� ��� � �������."),
                [3] = new ItemDescription("׸���� ���", "����� ��� ��� ����."),
                [4] = new ItemDescription("������ ���", "���������."),
                [5] = new ItemDescription("��� � �������", "� ���, ����������, ������������������ � �������!\n� ������������������ � ���?"),
                [6] = new ItemDescription("��������", "������� ��� ����� ������."),
                [7] = new ItemDescription("�������� ���", "�� �� ��������, �� ��� �� ������ ���, ������� �����!"),
                [8] = new ItemDescription("��������� ���", "����������� � ������������ �����..."),
                [9] = new ItemDescription("��� � ��������", "�������� ���������� �������."),
                [10] = new ItemDescription("������� ���", "��������� �������� �����: ��� ����� ������� ��� � ������� ������!"),
            },
            [ItemType.Teapot] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������ �� ��������", "� �� ���� ������� ������� �� ��������: ��� ��� �, ���!�?"),
                [2] = new ItemDescription("������ �� ��������", "� ������� ���������."),
                [3] = new ItemDescription("������ �� ��������", "������������ ������ �� �������� ���������� ���������."),
                [4] = new ItemDescription("�������������", "���� ������������� ������ ����� ������� �����, ������ ������������ �������."),
                [5] = new ItemDescription("�������������", "���������� ������� ��� ��������� ������� ��������!"),
                [6] = new ItemDescription("�����������", "����������� �����������. ������� �������, ���� ����� �������!"),
                [7] = new ItemDescription("�����������", "����������� ���������� ���������. �� �� �����!"),
            },
            [ItemType.Toaster] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("������", "����� ���� ��� ������ � ������������� ��������������."),
                [2] = new ItemDescription("������", "�� ���������� ����, ���� �� �������."),
                [3] = new ItemDescription("������", "���� ����� ����� �������, ����� � �����, ��� � ������ ������ ������ ������ ����..."),
                [4] = new ItemDescription("������", "������, �� �� ��������. ����� �� ����������..."),
                [5] = new ItemDescription("������", "���� ���������� ������-������� � ������, �� ������� ����� ����������� ��� � ��� ������."),
                [6] = new ItemDescription("������", "������������� �������� ��� ������."),
                [7] = new ItemDescription("������", "�������� ����� � ������� ������ ����� � �����. ���..."),
            },
            [ItemType.TrashCan] = new Dictionary<int, ItemDescription>
            {
                [1] = new ItemDescription("�������� �������", "������� �� ������������ � �������� �� ����� �������."),
                [2] = new ItemDescription("�������� ���", "����������� �������� ��-��� ���... ����� ������� � ������� �� ���������, ����� ��������� ����������."),
                [3] = new ItemDescription("�����������", "���� �� � ����� ������������ ���� �������, ��� ���� �� ������ ������, ��� �� ������� ��������."),
                [4] = new ItemDescription("��������", "�� ���������? ��� ��������?"),
                [5] = new ItemDescription("��������", "�� ������� � ��� �� ��������� � ������� ����� ������� �� ���� ����������!�"),
                [6] = new ItemDescription("������ �����", "�������� � ��������, ��� ����� � ������������� � �������� �� ��, ��� �� ������� ����� �����, �� ����, ��� ����� �������� ���."),
                [7] = new ItemDescription("����������� �����", "� �� ������ ��������� ������ �����.\n� �� ����, � ��� ��� 60 ������ �����."),
                [8] = new ItemDescription("����� ����������������", "����������� ��� �� �����..."),
            },
        };

        private static Dictionary<ItemType, string> _itemNames = new Dictionary<ItemType, string>
        {
            [ItemType.Star] = "���������",
            [ItemType.Brilliant] = "����������",
        };

        public static string GetItemTitle(ItemType type) => _itemNames[type];

        public static ItemDescription GetItemDescription(ItemType type, int level)
        {
            if (_itemDescriptions.ContainsKey(type) && _itemDescriptions[type].ContainsKey(level))
                return _itemDescriptions[type][level];
            return null;
        }

        public static string PluralizeWord(int count, string one, string twoFour, string fiveTen)
        {
            var remains100 = count % 100;
            var remains10 = count % 10;
            if (((remains100 < 11) || (remains100 > 14)) && (remains10 >= 1) && (remains10 <= 4))
            {
                if (remains10 == 1)
                    return one;
                return twoFour;
            }
            return fiveTen;
        }

        public class ItemDescription
        {
            public string Title { get; }
            public string Description { get; }

            public ItemDescription(string title, string description)
            {
                Title = title;
                Description = description;
            }
        }
    }
}