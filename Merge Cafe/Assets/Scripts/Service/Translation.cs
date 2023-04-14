using Enums;
using System.Collections.Generic;

namespace Service
{
    public static class Translation
    {
        private static Dictionary<Language, Dictionary<ItemType, Dictionary<int, ItemDescription>>> _itemDescriptions = new()
        {
            [Language.English] = new()
            {
                [ItemType.BakeryProduct] = new()
                {
                    [1] = new ItemDescription("Sugar", "The salt of life is that it is not sugar."),
                    [2] = new ItemDescription("Dough", "I will rake in the dough!"),
                    [3] = new ItemDescription("Pretzel", "Pretzels that I will share with you if you don't tell your mother."),
                    [4] = new ItemDescription("Cookie", "Made with love. And butter."),
                    [5] = new ItemDescription("Crumb Cookies", "With delightful chocolate pieces."),
                    [6] = new ItemDescription("Puff pastry", "With a surprise inside."),
                    [7] = new ItemDescription("Waffle", "Grandma had an extremely bad day: the waffles did not turn out, and the laptop was ruined in vain."),
                    [8] = new ItemDescription("Muffin", "The went well."),
                    [9] = new ItemDescription("Halva", "No matter how much you say �halva� - it will not become sweet in your mouth."),
                    [10] = new ItemDescription("Pie", "Life is a pie dominated by a layer of absurdity."),
                },
                [ItemType.BakeryProductWithCream] = new()
                {
                    [1] = new ItemDescription("Egg", "Not simple, but golden."),
                    [2] = new ItemDescription("Cream", "Like anti-aging, but also edible."),
                    [3] = new ItemDescription("Marshmallow", "Look, do not lose heart - eat marshmallows and relax!"),
                    [4] = new ItemDescription("Mousse", "For your beloved :)"),
                    [5] = new ItemDescription("Gingerbread", "A gingerbread is better than a cookie!"),
                    [6] = new ItemDescription("Cinnabon", "Included in the list of 50 pleasures of life."),
                    [7] = new ItemDescription("Donut", "Happiness is knowing that there are donuts."),
                    [8] = new ItemDescription("Macaroon", "As soon as it is not called - macaron, macaroon, macarons, macaroni ..."),
                    [9] = new ItemDescription("Roll", "Sweet sausage."),
                    [10] = new ItemDescription("Cake", "The dish that makes us wake up hungry at night."),
                },
                [ItemType.Box] = new()
                {
                    [1] = new ItemDescription("Paper", "Contract for the delivery of uh... goods. What? We don't even know ourselves."),
                    [2] = new ItemDescription("Box", "Maybe I'm lucky?"),
                    [3] = new ItemDescription("Gift box", "For you."),
                },
                [ItemType.Brilliant] = new()
                {
                    [1] = new ItemDescription("Crystal", "What is it that glitters there?"),
                    [2] = new ItemDescription("A couple of crystals", "Or maybe more?"),
                    [3] = new ItemDescription("A handful of crystals", "This is not the limit!"),
                    [4] = new ItemDescription("Pile of crystals", "Enough for a yacht."),
                    [5] = new ItemDescription("Mountain of crystals", "Yes, you are rich!"),
                },
                [ItemType.Coffee] = new()
                {
                    [1] = new ItemDescription("A grain of coffee", "And why was it useful to customers?"),
                    [2] = new ItemDescription("Instant coffee", "Selected."),
                    [3] = new ItemDescription("Glass of coffee", "In a disposable cup. Not environmentally friendly."),
                    [4] = new ItemDescription("A cup of coffee", "The easiest way to wake up a person in the morning. Poured and run!"),
                    [5] = new ItemDescription("Coffee with cookies", "What could be tastier?"),
                    [6] = new ItemDescription("Coffee cocktail", "Served in a vending machine. Already lost my salary into it."),
                    [7] = new ItemDescription("Cappuccino", "Coffee classic."),
                    [8] = new ItemDescription("Cappuccino v2.0", "Level 80!"),
                    [9] = new ItemDescription("Coffee pot", "Now 3 times more, for vital vigor."),
                    [10] = new ItemDescription("Turk", "Best coffee in the establishment."),
                },
                [ItemType.Energy] = new()
                {
                    [1] = new ItemDescription("Energy", "Food for kitchen appliances."),
                    [2] = new ItemDescription("Renewable energy", "Nature is very smart."),
                    [3] = new ItemDescription("Solar energy", "Very environmentally friendly."),
                    [4] = new ItemDescription("Atomic energy", "Let's delve into nuclear physics..."),
                    [5] = new ItemDescription("Powerful battery", "A battery has run out on the scales today. Only I, because I know for sure, have lost weight!"),
                },
                [ItemType.FastFood] = new()
                {
                    [1] = new ItemDescription("Bread", "A loaf, big and ruddy."),
                    [2] = new ItemDescription("A hunk of bread", "Actually, what's the benefit?"),
                    [3] = new ItemDescription("Bread and butter", "Buttered down again..."),
                    [4] = new ItemDescription("Sandwich", "Almost like a burger."),
                    [5] = new ItemDescription("Hot dog", "I'd like two hot dogs, please, one with mustard and one without."),
                    [6] = new ItemDescription("Tacos", "A little Mexico can't hurt."),
                    [7] = new ItemDescription("Shawarma", "Favorite dish of foreign students."),
                    [8] = new ItemDescription("Big sandwich", "Say goodbye to the figure..."),
                    [9] = new ItemDescription("French fries", "Melting in your mouth. And with mayonnaise, mmm ..."),
                    [10] = new ItemDescription("Pizza", "Don Pizzerrone"),
                },
                [ItemType.Key] = new()
                {
                    [1] = new ItemDescription("Key", "The usual ugly key for equally ugly locks."),
                    [2] = new ItemDescription("Golden Key", "Straight from Pinocchio."),
                    [3] = new ItemDescription("Silver Key", "For the first time, they did not forget to take care of the house, it remains only to remember the head."),
                    [4] = new ItemDescription("Techno-Key", "Does this even exist?"),
                    [5] = new ItemDescription("Key to the safe", "But also works for our super-strong safe-locks."),
                },
                [ItemType.Lock] = new()
                {
                    [1] = new ItemDescription("Flimsy lock", "In the name of the culinary god, I command you to disappear!"),
                    [2] = new ItemDescription("Golden lock", "Yes, it interferes, but look how it shines!"),
                    [3] = new ItemDescription("Silver lock", "More serious barrier..."),
                    [4] = new ItemDescription("Techno-lock", "You can't open it without a special tool. What technology has come to!"),
                    [5] = new ItemDescription("Safe lock", "Very strong. Has it been separated from the safe?"),
                },
                [ItemType.OpenPresent] = new()
                {
                    [1] = new ItemDescription("Blue Gift", "Well, what are you waiting for? Rather, look what's inside!"),
                    [2] = new ItemDescription("Red gift", "Well, what is there? We are also interested!"),
                    [3] = new ItemDescription("Golden Gift", "Right now you will become the richest culinary specialist on the planet."),
                },
                [ItemType.Oven] = new()
                {
                    [1] = new ItemDescription("Oven", "Do you keep frying pans in your oven?"),
                    [2] = new ItemDescription("Oven", "Do you keep frying pans in your oven?"),
                    [3] = new ItemDescription("Oven", "Do you keep frying pans in your oven?"),
                    [4] = new ItemDescription("Oven", "Do you keep frying pans in your oven?"),
                    [5] = new ItemDescription("Oven", "Do you keep frying pans in your oven?"),
                    [6] = new ItemDescription("Oven", "Do you keep frying pans in your oven?"),

                },
                [ItemType.Present] = new()
                {
                    [1] = new ItemDescription("Blue gift", "We must open it! Or maybe be patient and merge first? No, I'm opening it! Although ..."),
                    [2] = new ItemDescription("Red gift", "I wish I had one for my birthday."),
                    [3] = new ItemDescription("Golden gift", "To the best merger of the month."),
                },
                [ItemType.Star] = new()
                {
                    [1] = new ItemDescription("Star", "Your way to success."),
                    [2] = new ItemDescription("A couple of stars", "Need more stars. Even MORE!"),
                    [3] = new ItemDescription("A handful of Stars", "Why can't we just cut out new stars?"),
                    [4] = new ItemDescription("A bunch of stars", "They fall from the ceiling? Where is the logic?"),
                    [5] = new ItemDescription("Mountain of stars", "Well, now it's enough."),
                },
                [ItemType.Tea] = new()
                {
                    [1] = new ItemDescription("Tea leaf", "So tiny and defenseless."),
                    [2] = new ItemDescription("Tea bag", "Immerse it in boiling water."),
                    [3] = new ItemDescription("Black tea", "Just like my soul."),
                    [4] = new ItemDescription("Green tea", "Warms."),
                    [5] = new ItemDescription("Tea with lemon", "- Chivirzdnerkilmerk with lemon, please!\n- Chivirzdnerkilmerk with what?"),
                    [6] = new ItemDescription("Teapot", "Grab it for your friends."),
                    [7] = new ItemDescription("Cold tea", "You won't believe it, but it's not just tea that's cold!"),
                    [8] = new ItemDescription("Flower tea", "Calms and clouds the mind..."),
                    [9] = new ItemDescription("Tea with star anise", "Wonderful vitamin drink."),
                    [10] = new ItemDescription("Elite tea", "We reveal a terrible secret: this is the most ordinary tea in an elite wrapper!"),
                },
                [ItemType.Teapot] = new()
                {
                    [1] = new ItemDescription("Kettle with a whistle", "Do you also shout to the kettle with a whistle: �I'm coming, I'm coming!�?"),
                    [2] = new ItemDescription("Kettle with a whistle", "With a gold lid."),
                    [3] = new ItemDescription("Whistling kettle", "Traditional whistling kettle of the latest generation."),
                    [4] = new ItemDescription("Electric Kettle", "This electric kettle has a lot of volume, but it's not fast enough."),
                    [5] = new ItemDescription("Electric kettle", "Great option for lovers of hot drinks!"),
                    [6] = new ItemDescription("Thermal kettle", "Special thermal kettle. Holds a little, but what a fast one!"),
                    [7] = new ItemDescription("Thermo kettle", "Thermo kettle of the latest generation. Yes, you are cool!"),
                },
                [ItemType.Toaster] = new()
                {
                    [1] = new ItemDescription("Toaster", "Just an underpowered death ray."),
                    [2] = new ItemDescription("Toaster", "Don't look in there while it's on."),
                    [3] = new ItemDescription("Toaster", "It was like an electric shock when I realized that you can't put wet bread in the toaster..."),
                    [4] = new ItemDescription("Toaster", "Apparently, it does not work. Toast does not come out..."),
                    [5] = new ItemDescription("Toaster", "If you merge a rocking chair and a toaster, then the grandfather will jump out every two minutes."),
                    [6] = new ItemDescription("Toaster", "Ultimate bath bomb."),
                    [7] = new ItemDescription("Toaster", "Put it sideways and you can make toast with cheese. Mmm..."),
                },
                [ItemType.TrashCan] = new()
                {
                    [1] = new ItemDescription("Trash can", "No matter how hard you tamp, you still have to take it out."),
                    [2] = new ItemDescription("Trash can", "Throwing out the packaging from under the food... We climb back into the trash for packaging to read the instructions."),
                    [3] = new ItemDescription("Calculator", "If my calculator had a history, I would be more ashamed than my browser history."),
                    [4] = new ItemDescription("Terminal", "In cash? Or by credit card?"),
                    [5] = new ItemDescription("Terminal", "�I work part-time for you and therefore I ask you to shout at me in an undertone!�"),
                    [6] = new ItemDescription("The old checkout", "The convolutions of a person are like cash desks in supermarkets - despite the fact that a lot of them have been created, it is not a fact that everyone will work."),
                    [7] = new ItemDescription("Modern cash register", "- Oh, we forgot to take toilet paper.\n- Don't, we'll have a check of 60 meters."),
                    [8] = new ItemDescription("Self-service checkout", "Old-men don't belong here..."),
                },
                [ItemType.Trash] = new()
                {
                    [1] = new ItemDescription("Fish bone", "Ugh!")
                },
                [ItemType.Duplicator] = new()
                {
                    [1] = new ItemDescription("Duplicator", "Makes a copy of the item level below"),
                    [2] = new ItemDescription("Duplicator", "Makes a copy of the item"),
                    [3] = new ItemDescription("Duplicator", "Makes a copy of the item level above")
                }
            },
            [Language.Russian] = new()
            {
                [ItemType.BakeryProduct] = new()
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
                [ItemType.BakeryProductWithCream] = new()
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
                [ItemType.Box] = new()
                {
                    [1] = new ItemDescription("������", "�������� �� �������� ��... ������. ������? �� � ���� �� �����."),
                    [2] = new ItemDescription("�������", "� ����� ��� ������?"),
                    [3] = new ItemDescription("���������� �������", "��� ����."),
                },
                [ItemType.Brilliant] = new()
                {
                    [1] = new ItemDescription("��������", "��� ��� ��� �������?"),
                    [2] = new ItemDescription("������� ����������", "� ����� ������?"),
                    [3] = new ItemDescription("������ ����������", "��� ��� �� ������!"),
                    [4] = new ItemDescription("���� ����������", "������ �� ����."),
                    [5] = new ItemDescription("���� ����������", "�� �� ������!"),
                },
                [ItemType.Coffee] = new()
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
                [ItemType.Energy] = new()
                {
                    [1] = new ItemDescription("�������", "���� ��� �������� ��������."),
                    [2] = new ItemDescription("�������������� �������", "������� ����� ����."),
                    [3] = new ItemDescription("��������� �������", "����� ����������."),
                    [4] = new ItemDescription("������� �������", "��������� � ������� ������..."),
                    [5] = new ItemDescription("������ �������", "�� ����� ������� ���� ���������. ������ �, ���� ����� ���� � ��������!"),
                },
                [ItemType.FastFood] = new()
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
                [ItemType.Key] = new()
                {
                    [1] = new ItemDescription("����", "������� ��������� ���� ��� ����� �� ��������� ������."),
                    [2] = new ItemDescription("������� ����", "�������� �� ��������."),
                    [3] = new ItemDescription("���������� ����", "������� �� ������ ����� �� ����� �� ����, �������� ������ ������ �� ������."),
                    [4] = new ItemDescription("�����-����", "� ����� ������ ����������?"),
                    [5] = new ItemDescription("���� �� �����", "�� ����� ������� � ��� ����� �����-������� ����-������."),
                },
                [ItemType.Lock] = new()
                {
                    [1] = new ItemDescription("������� �����", "������ ����������� ���� � ���������� ���� � �������!"),
                    [2] = new ItemDescription("������� �����", "��, ������, ���� ��������, ��� �������!"),
                    [3] = new ItemDescription("���������� �����", "�������� �����������..."),
                    [4] = new ItemDescription("�����-�����", "��� ������� ����������� ��� �� �������. �� ���� ����� ����������!"),
                    [5] = new ItemDescription("����-�����", "����� �������. ��� �������� �� �����?"),
                },
                [ItemType.OpenPresent] = new()
                {
                    [1] = new ItemDescription("����� �������", "�� ���� �� ����? ������ ������, ��� ��� ������!"),
                    [2] = new ItemDescription("������� �������", "�� ��� ���? ��� ���� ���������!"),
                    [3] = new ItemDescription("������� �������", "����� ������ �� ������� ����� ������� ��������� �� �������."),
                },
                [ItemType.Oven] = new()
                {
                    [1] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                    [2] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                    [3] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                    [4] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                    [5] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                    [6] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                    [6] = new ItemDescription("������� ����", "� �� ������� � ����� ������� ����������?"),
                },
                [ItemType.Present] = new()
                {
                    [1] = new ItemDescription("����� �������", "���� �������! � ����� ��������� � ������� ����������? ���, ��������! ����..."),
                    [2] = new ItemDescription("������� �������", "��� �� ��� ����� �� ���� ��������."),
                    [3] = new ItemDescription("������� �������", "������� �������������� ������."),
                },
                [ItemType.Star] = new()
                {
                    [1] = new ItemDescription("������", "���� ���� � ������."),
                    [2] = new ItemDescription("���� ����", "����� ������ ����. ��� ������!"),
                    [3] = new ItemDescription("������� ����", "������ �� �� ����� ������ �������� ����� �����?"),
                    [4] = new ItemDescription("���� ����", "��� � ������� ������? ����, ��� ������?"),
                    [5] = new ItemDescription("���� ����", "�� ������-�� �������� �������."),
                },
                [ItemType.Tea] = new()
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
                [ItemType.Teapot] = new()
                {
                    [1] = new ItemDescription("������ �� ��������", "� �� ���� ������� ������� �� ��������: ��� ��� �, ���!�?"),
                    [2] = new ItemDescription("������ �� ��������", "� ������� ���������."),
                    [3] = new ItemDescription("������ �� ��������", "������������ ������ �� �������� ���������� ���������."),
                    [4] = new ItemDescription("�������������", "���� ������������� ������ ����� ������� �����, ������ ������������ �������."),
                    [5] = new ItemDescription("�������������", "���������� ������� ��� ��������� ������� ��������!"),
                    [6] = new ItemDescription("�����������", "����������� �����������. ������� �������, ���� ����� �������!"),
                    [7] = new ItemDescription("�����������", "����������� ���������� ���������. �� �� �����!"),
                },
                [ItemType.Toaster] = new()
                {
                    [1] = new ItemDescription("������", "����� ���� ��� ������ � ������������� ��������������."),
                    [2] = new ItemDescription("������", "�� ���������� ����, ���� �� �������."),
                    [3] = new ItemDescription("������", "���� ����� ����� �������, ����� � �����, ��� � ������ ������ ������ ������ ����..."),
                    [4] = new ItemDescription("������", "������, �� �� ��������. ����� �� ����������..."),
                    [5] = new ItemDescription("������", "���� ���������� ������-������� � ������, �� ������� ����� ����������� ��� � ��� ������."),
                    [6] = new ItemDescription("������", "������������� �������� ��� ������."),
                    [7] = new ItemDescription("������", "�������� ����� � ������� ������ ����� � �����. ���..."),
                },
                [ItemType.TrashCan] = new()
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
                [ItemType.Trash] = new()
                {
                    [1] = new ItemDescription("����� �����", "��!")
                },
                [ItemType.Duplicator] = new()
                {
                    [1] = new ItemDescription("����������", "������ ����� �������� ������ ����"),
                    [2] = new ItemDescription("����������", "������ ����� ��������"),
                    [3] = new ItemDescription("����������", "������ ����� �������� ������ ����")
                }
            }
        };

        private static Dictionary<Language, Dictionary<ItemType, string>> _itemNames = new()
        {
            [Language.English] = new()
            {
                [ItemType.Star] = "stars",
                [ItemType.Brilliant] = "crystals",
            },
            [Language.Russian] = new()
            {
                [ItemType.Star] = "�����",
                [ItemType.Brilliant] = "���������",
            }
        };

        private static Dictionary<Language, string> _itemTexts = new()
        {
            [Language.English] = "items",
            [Language.Russian] = "��������",
        };

        private static Dictionary<Language, string> _viewAddTexts = new()
        {
            [Language.English] = "View ads",
            [Language.Russian] = "���������� �������",
        };

        private static Dictionary<Language, string> _congratulateTexts = new()
        {
            [Language.English] = "CONGRATULATIONS!",
            [Language.Russian] = "�����������!",
        };

        private static Dictionary<Language, string> _greatTexts = new()
        {
            [Language.English] = "GREAT",
            [Language.Russian] = "�������",
        };

        private static Dictionary<Language, string[]> _newGeneratorTexts = new()
        {
            [Language.English] = new[] 
            { 
                "You have received new equipment",
                "Your menu has been updated!"
            },
            [Language.Russian] = new[]
            {
                "�� �������� ����� ������������",
                "���� ���� ���������!"
            },
        };

        private static Dictionary<Language, string[]> _upgradedGeneratorTexts = new()
        {
            [Language.English] = new[]
            {
                "You have improved",
                "Fulfill orders even more efficiently"
            },
            [Language.Russian] = new[]
            {
                "�� ��������",
                "���������� ������ ��� �����������"
            },
        };

        private static Dictionary<Language, string[]> _newLevelTexts = new()
        {
            [Language.English] = new[]
            {
                "You have reached level",
                ""
            },
            [Language.Russian] = new[]
            {
                "�� ��������",
                " ������"
            },
        };

        private static Dictionary<Language, string[]> _newItemTexts = new()
        {
            [Language.English] = new[]
            {
                "You have unlocked ",
                " with level ",
                " for the first time"
            },
            [Language.Russian] = new[]
            {
                "�� ������� ������� ",
                " ",
                "-�� ������"
            },
        };

        private static Dictionary<Language, string> _settingsTexts = new()
        {
            [Language.English] = "Settings",
            [Language.Russian] = "���������",
        };

        private static Dictionary<Language, string> _soundsTexts = new()
        {
            [Language.English] = "Sounds",
            [Language.Russian] = "�����",
        };

        private static Dictionary<Language, string> _musicTexts = new()
        {
            [Language.English] = "Music",
            [Language.Russian] = "������",
        };

        private static Dictionary<Language, string> _languageTexts = new()
        {
            [Language.English] = "Language",
            [Language.Russian] = "����",
        };

        private static Dictionary<Language, string> _resetTexts = new()
        {
            [Language.English] = "Reset progress",
            [Language.Russian] = "�������� ��������",
        };

        private static Dictionary<Language, string> _levelTexts = new()
        {
            [Language.English] = "Level",
            [Language.Russian] = "�������",
        };

        private static Dictionary<Language, Dictionary<MessageType, string>> _messageTexts = new()
        {
            [Language.English] = new()
            {
                [MessageType.MaxLevel] = "Max level",
                [MessageType.Upgraded] = "UPGRADED",
                [MessageType.NoOrderPoints] = "There are no available orders",
                [MessageType.NoEmptyCells] = "There are no free cells",
                [MessageType.DragItemToTrashCan] = "Drag an unnecessary item",
                [MessageType.CannotBeThrownAway] = "This item cannot be thrown away",
                [MessageType.NotEnougthBrilliants] = "Not enough crystals",
                [MessageType.WrongLevelForCombinating] = "Unsuitable item level",
            },
            [Language.Russian] = new()
            {
                [MessageType.MaxLevel] = "������������ �������",
                [MessageType.Upgraded] = "��������",
                [MessageType.NoOrderPoints] = "��� ��������� �������",
                [MessageType.NoEmptyCells] = "��� ��������� �����",
                [MessageType.DragItemToTrashCan] = "���������� �������� �������",
                [MessageType.CannotBeThrownAway] = "���� ������� ������ ���������",
                [MessageType.NotEnougthBrilliants] = "�� ������� ����������",
                [MessageType.WrongLevelForCombinating] = "������������ ������� ��������",
            }
        };

        private static Dictionary<Language, string> _cannotBeThrownTexts = new()
        {
            [Language.English] = "This item can't be thrown away",
            [Language.Russian] = "���� ������� ������ ���������",
        };

        private static Dictionary<Language, string> _getFromPresentInfo = new()
        {
            [Language.English] = "Click to get rewards",
            [Language.Russian] = "�����, ����� �������� �������",
        };

        private static Dictionary<Language, string[]> _dragEquipToUpgradeGeneratorInfo = new()
        {
            [Language.English] = new[]
            {
                "Drag it to the equipment ",
                " to upgrade it",
            },
            [Language.Russian] = new[]
            {
                "�������� �� ������������ ",
                ", ����� �������� ���"
            },
        };

        private static Dictionary<Language, string[]> _mergeGeneratorsInfo = new()
        {
            [Language.English] = new[]
            {
                "Merge to get ",
                " with level ",
                "",
                "Get ",
                " with level ",
                "",
                " to upgrade equipment "
            },
            [Language.Russian] = new[]
            {
                "��������, ����� �������� ",
                " ",
                "-�� ������",
                "������ ",
                " ",
                "-�� ������",
                ", ����� �������� ������������ "
            },
        };

        private static Dictionary<Language, string[]> _mergeOrGetCurrencyInfo = new()
        {
            [Language.English] = new[]
            {
                "Click to get ",
                " or merge to get more",
            },
            [Language.Russian] = new[]
            {
                "�����, ����� �������� ",
                ", ��� ��������, ����� �� ����� ������",
            },
        };

        private static Dictionary<Language, string[]> _mergeOrOpenPresentInfo = new()
        {
            [Language.English] = new[]
            {
                "Click to open",
                " or merge to get a more valuable gift",
            },
            [Language.Russian] = new[]
            {
                "�����, ����� �������",
                ", ��� ��������, ����� �������� ����� ������ �������",
            },
        };

        private static Dictionary<Language, string[]> _dragKeyToLockInfo = new()
        {
            [Language.English] = new[]
            {
                "Drag it to a lock with level ",
                " to unlock a cell",
                " or merge to open locks of higher levels",
            },
            [Language.Russian] = new[]
            {
                "�������� �� ����� ",
                "-�� ������, ����� �������������� ������",
                ", ��� ��������, ����� ��������� ����� ����� ������� �������",
            },
        };

        private static Dictionary<Language, string[]> _howRemoveLockInfo = new()
        {
            [Language.English] = new[]
            {
                "Drag a key with level ",
                " here to unlock this cell"
            },
            [Language.Russian] = new[]
            {
                "�������� ���� ���� ",
                "-�� ������, ����� �������������� ������"
            },
        };

        private static Dictionary<Language, Dictionary<int, string>> _boxInfo = new()
        {
            [Language.English] = new()
            {
                [1] = "Merge to get ",
                [2] = "Click to get a random item needed to complete the order, or merge to get ",
                [3] = "Click to get the maximum level item needed to complete the order"
            },
            [Language.Russian] = new()
            {
                [1] = "��������, ����� �������� ",
                [2] = "�����, ����� �������� ��������� �������, ����������� ��� ���������� ������, ��� ��������, ����� �������� ",
                [3] = "�����, ����� �������� ������� ������������� ������, ����������� ��� ���������� ������"
            },
        };

        private static Dictionary<Language, string[]> _energyInfo = new()
        {
            [Language.English] = new[]
            {
                "Drag on an equipment to speed it up (the charge is enough for ",
                " or merge to enhance the effect"
            },
            [Language.Russian] = new[]
            {
                "�������� �� ������������, ����� �������� ��� (������ ������ �� ",
                ", ��� ��������, ����� ������� ������"
            },
        };

        private static Dictionary<Language, string[]> _ordinaryItemInfo = new()
        {
            [Language.English] = new[]
            {
                "Drag to order to fulfill it if it contains ",
                " or merge to get "
            },
            [Language.Russian] = new[]
            {
                "�������� �� ���� ������, ����� ��������� ���, ���� �� �������� ",
                ", ��� ��������, ����� �������� "
            },
        };

        private static Dictionary<Language, string[]> _trashCanInfo = new()
        {
            [Language.English] = new[]
            {
                "Drag an item here to throw it away",
                "Upgrade it so you can sell items",
                "Upgrade it so you can get more crystals from the sale"
            },
            [Language.Russian] = new[]
            {
                "�������� ���� �������, ����� ��������� ���",
                "������, ����� ����� ���� ��������� ��������",
                "������, ����� ������� ��������� ������ ����������",
            },
        };

        private static Dictionary<Language, string[]> _upgradeGeneratorInfo = new()
        {
            [Language.English] = new[]
            {
                "Upgrade to increase the level of produced items",
                "Upgrade to produce items faster",
                "Produces"
            },
            [Language.Russian] = new[]
            {
                "������, ����� �������� ������� ������������ ���������",
                "������, ����� ������� ����������� ��������",
                "����������"
            },
        };

        public static string GetItemTitle(Language language, ItemType type) => _itemNames[language][type];

        public static ItemDescription GetItemDescription(Language language, ItemType type, int level)
        {
            if (_itemDescriptions.ContainsKey(language) && _itemDescriptions[language].ContainsKey(type) && _itemDescriptions[language][type].ContainsKey(level))
                return _itemDescriptions[language][type][level];
            return null;
        }

        public static string GetGreatText(Language language) => _greatTexts[language];

        public static string GetCongratulationsText(Language language) => _congratulateTexts[language];

        public static string GetViewAdsText(Language language) => _viewAddTexts[language];

        public static string[] GetNewGeneratorTextParts(Language language) => _newGeneratorTexts[language];

        public static string[] GetUpgradedGeneratorTextParts(Language language) => _upgradedGeneratorTexts[language];

        public static string[] GetNewLevelTextParts(Language language) => _newLevelTexts[language];

        public static string[] GetNewItemTextParts(Language language) => _newItemTexts[language];

        public static string GetSettingsText(Language language) => _settingsTexts[language];

        public static string GetSoundsText(Language language) => _soundsTexts[language];

        public static string GetMusicText(Language language) => _musicTexts[language];

        public static string GetLanguageText(Language language) => _languageTexts[language];

        public static string GetResetText(Language language) => _resetTexts[language];

        public static string GetMessageText(Language language, MessageType type) => _messageTexts[language][type];

        public static string GetCannotBeThrownText(Language language) => _cannotBeThrownTexts[language];

        public static string GetItemText(Language language) => _itemTexts[language];

        public static string[] GetDragEquipUpgradeGeneratorInfoParts(Language language) => _dragEquipToUpgradeGeneratorInfo[language];

        public static string[] GetMergeGeneratorInfoParts(Language language) => _mergeGeneratorsInfo[language];

        public static string[] GetMergeOrGetCurrencyInfoParts(Language language) => _mergeOrGetCurrencyInfo[language];

        public static string[] GetMergeOrOpenPresentInfoParts(Language language) => _mergeOrOpenPresentInfo[language];

        public static string GetFromPresentInfo(Language language) => _getFromPresentInfo[language];

        public static string[] GetDragKeyToLockInfoParts(Language language) => _dragKeyToLockInfo[language];

        public static string[] GetHowRemoveLockInfoParts(Language language) => _howRemoveLockInfo[language];

        public static string GetBoxInfoPart(Language language, int level) => _boxInfo[language][level];

        public static string[] GetEnergyInfoParts(Language language) => _energyInfo[language];

        public static string[] GetOrdinaryItemInfoParts(Language language) => _ordinaryItemInfo[language];

        public static string[] GetTrashCanInfoParts(Language language) => _trashCanInfo[language];

        public static string[] GetUpgradeGeneratorInfoParts(Language language) => _upgradeGeneratorInfo[language];

        public static string GetLevelText(Language language) => _levelTexts[language];


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