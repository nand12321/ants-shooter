using System.Numerics;
using Raylib_cs;


namespace AntsShooter.Entities;

public class Bullet : Entity
{
    private Vector2 direction;
    private float speed = 1000.0f;

    public Bullet(Vector2 pos, Vector2 target) : base()
    {
        position = pos;
        direction = Vector2.Normalize(position - target);
    }

    public override void Update()
    {
        base.Update();
        
        position -= direction * speed * Raylib.GetFrameTime();
    }

    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle((int)Math.Round(position.X), (int)Math.Round(position.Y), 10, Color.Gold);
    }
}