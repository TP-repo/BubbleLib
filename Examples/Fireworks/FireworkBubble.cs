using BubbleLib.Core;

namespace Fireworks
{
    internal class FireworkBubble
    {
        private static Random random = new Random();

        public float X { get; set; }
        public float Y { get; set; }

        public float DX { get; set; }

        public float DY { get; set; }

        public float Size { get; set; }

        public Sprite Sprite { get; set; }

        public float Duration { get; set; }



        public FireworkBubble(float x, float y)
        {
            X = x;
            Y = y;
            DX = (float)(random.NextDouble() * 150 + 20);
            DY = (float)(random.NextDouble() * -50 - 0.5f);
            Size = (float)(random.NextDouble() * 0.1 + 0.2);
            Sprite = GetRandomSprite();
            Duration = random.Next(3, 15);
        }

        public void Update(float dt)
        {
            X += DX * dt;
            Y += DY * dt;
            DY -= 10f * dt;
            Duration -= dt;
        }

        public void Draw()
        {
            Sprite.Draw(X, Y, Size, Size);
        }

        public Sprite GetRandomSprite()
        {
            Sprite[] sprites = new Sprite[]
            {
                Sprite.BubbleBig,
                Sprite.BubbleBigStar,
                Sprite.BubbleBigSquare,
                Sprite.BubbleBigCritical,
                Sprite.BubbleBigSquareCritical,
                Sprite.BubbleBigStarCritical,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
                Sprite.BubbleRegular,
            };

            return sprites[random.Next(sprites.Length)];

        }


    }
}