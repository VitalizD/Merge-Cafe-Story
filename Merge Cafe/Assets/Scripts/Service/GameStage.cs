using Enums;

namespace Service
{
    public static class GameStage
    {
        private static readonly Settings[] _storage;

        static GameStage()
        {
            _storage = new[]
            {
                new Settings(new[] // 1
                {
                    (ItemType.Tea, 1, 3, 1),
                }, null, new[]
                {
                    (ItemType.Teapot, 1, 4),
                    (ItemType.Key, 1, 4),
                }, 1),

                new Settings(new[] // 2
                {
                    (ItemType.Tea, 1, 3, 1),
                    (ItemType.Coffee, 1, 3, 2),
                }, new[]
                {
                    (ItemType.Tea, 4),
                    (ItemType.Coffee, 4),
                }, new[]
                {
                    (ItemType.TrashCan, 1, 9),
                    (ItemType.Teapot, 1, 7),
                    (ItemType.Energy, 1, 4),
                    (ItemType.Brilliant, 2, 6),
                    (ItemType.Key, 1, 5),
                }, 1),

                new Settings(new[] // 3
                {
                    (ItemType.Tea, 1, 4, 1),
                    (ItemType.Coffee, 1, 3, 2),
                }, new[]
                {
                    (ItemType.Tea, 5),
                }, new[]
                {
                    (ItemType.Oven, 1, 20),
                    (ItemType.Teapot, 1, 7),
                    (ItemType.TrashCan, 1, 9),
                    (ItemType.Present, 1, 10),
                    (ItemType.Box, 1, 8),
                    (ItemType.Key, 1, 6),
                    (ItemType.Key, 1, 6),
                    (ItemType.Brilliant, 2, 7),
                }, 1),

                new Settings(new[] // 4
                {
                    (ItemType.Tea, 1, 4, 1),
                    (ItemType.Coffee, 1, 4, 2),
                    (ItemType.BakeryProduct, 1, 3, 3),
                }, new[]
                {
                    (ItemType.Coffee, 5),
                    (ItemType.BakeryProduct, 4),
                }, new[]
                {
                    (ItemType.Oven, 1, 10),
                    (ItemType.Teapot, 1, 7),
                    (ItemType.Box, 1, 8),
                    (ItemType.Brilliant, 3, 10),
                    (ItemType.Energy, 2, 12),
                }, 2),

                new Settings(new[] // 5
                {
                    (ItemType.Tea, 2, 5, 1),
                    (ItemType.Coffee, 1, 4, 2),
                    (ItemType.BakeryProduct, 1, 3, 3),
                    (ItemType.BakeryProductWithCream, 1, 3, 4),
                }, new[]
                {
                    (ItemType.Tea, 6),
                    (ItemType.BakeryProductWithCream, 4),
                }, new[]
                {
                    (ItemType.Teapot, 2, 23),
                    (ItemType.Present, 1, 20),
                    (ItemType.TrashCan, 1, 15),
                    (ItemType.TrashCan, 2, 28),
                    (ItemType.Energy, 1, 8),
                    (ItemType.Brilliant, 2, 13),
                }, 2),

                new Settings(new[] // 6
                {
                    (ItemType.Tea, 2, 5, 1),
                    (ItemType.Coffee, 2, 5, 2),
                    (ItemType.BakeryProduct, 1, 4, 3),
                    (ItemType.BakeryProductWithCream, 1, 3, 4),
                }, new[]
                {
                    (ItemType.Coffee, 6),
                    (ItemType.BakeryProduct, 5),
                }, new[]
                {
                    (ItemType.TrashCan, 1, 25),
                    (ItemType.Energy, 2, 19),
                    (ItemType.Brilliant, 2, 19),
                    (ItemType.Key, 1, 20),
                    (ItemType.Oven, 1, 24),
                    (ItemType.Box, 1, 16),
                }, 2),

                new Settings(new[] // 7
                {
                    (ItemType.Tea, 2, 6, 1),
                    (ItemType.Coffee, 2, 5, 2),
                    (ItemType.BakeryProduct, 1, 4, 3),
                    (ItemType.BakeryProductWithCream, 1, 4, 4),
                }, new[]
                {
                    (ItemType.Tea, 7),
                    (ItemType.BakeryProductWithCream, 5),
                }, new[]
                {
                    (ItemType.TrashCan, 1, 27),
                    (ItemType.Teapot, 2, 28),
                    (ItemType.Brilliant, 3, 23),
                    (ItemType.Energy, 1, 10),
                    (ItemType.Present, 1, 30),
                }, 2),

                new Settings(new[] // 8
                {
                    (ItemType.Tea, 2, 6, 1),
                    (ItemType.Coffee, 2, 6, 2),
                    (ItemType.BakeryProduct, 2, 5, 3),
                    (ItemType.BakeryProductWithCream, 1, 4, 4),
                }, new[]
                {
                    (ItemType.Coffee, 7),
                    (ItemType.BakeryProduct, 6),
                }, new[]
                {
                    (ItemType.Toaster, 1, 60),
                    (ItemType.Teapot, 1, 30),
                    (ItemType.Brilliant, 1, 12),
                    (ItemType.Brilliant, 1, 12),
                    (ItemType.Key, 2, 34),
                    (ItemType.Oven, 1, 29),
                }),

                new Settings(new[] // 9
                {
                    (ItemType.Tea, 2, 7, 1),
                    (ItemType.Coffee, 2, 6, 2),
                    (ItemType.BakeryProduct, 2, 5, 3),
                    (ItemType.BakeryProductWithCream, 2, 5, 4),
                    (ItemType.FastFood, 1, 3, 5),
                }, new[]
                {
                    (ItemType.Tea, 8),
                    (ItemType.BakeryProductWithCream, 6),
                    (ItemType.FastFood, 4),
                }, new[]
                {
                    (ItemType.Teapot, 1, 33),
                    (ItemType.TrashCan, 1, 29),
                    (ItemType.Box, 2, 30),
                    (ItemType.Brilliant, 3, 26),
                    (ItemType.Energy, 3, 27),
                }),

                new Settings(new[] // 10
                {
                    (ItemType.Tea, 2, 7, 1),
                    (ItemType.Coffee, 2, 7, 2),
                    (ItemType.BakeryProduct, 2, 6, 3),
                    (ItemType.BakeryProductWithCream, 2, 5, 4),
                    (ItemType.FastFood, 1, 4, 5),
                }, new[]
                {
                    (ItemType.Coffee, 8),
                    (ItemType.BakeryProduct, 7),
                }, new[]
                {
                    (ItemType.Teapot, 1, 35),
                    (ItemType.Teapot, 2, 40),
                    (ItemType.Present, 2, 31),
                    (ItemType.Toaster, 1, 24),
                    (ItemType.Energy, 1, 18),
                    (ItemType.Brilliant, 2, 23),
                }),
            };
        }

        public static Settings GetSettingsByStage(int value)
        {
            if (value > _storage.Length)
                return null;
            return _storage[value - 1];
        }

        public static Settings GetSettingsByLastStage() => _storage[_storage.Length - 1];

        public class Settings
        {
            public (ItemType Type, int MinLevel, int MaxLevel, int RewardLevel)[] Items { get; }

            public (ItemType Type, int Level)[] RareItems { get; private set; }

            public (ItemType Type, int Level, int RequiredStars)[] Targets { get; private set; }

            public int MaxOrderPoints { get; }

            public Settings(
                (ItemType Type, int MinLevel, int MaxLevel, int RewardLevel)[] items, 
                (ItemType Type, int Level)[] rareItems, 
                (ItemType Type, int Level, int RequiredStars)[] targets, 
                int maxOrderPoints = 3)
            {
                Items = items;
                RareItems = rareItems;
                Targets = targets;
                MaxOrderPoints = maxOrderPoints;
            }

            public void ClearRareItems() => RareItems = null;
        }
    }
}