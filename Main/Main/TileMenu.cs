using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TileMenu : GameObjectList
{
    private int radius;

    public TileMenu() : base("tileMenu")
    {
        this.Position = new Microsoft.Xna.Framework.Vector2(GameEnvironment.Screen.X / 2, GameEnvironment.Screen.Y / 2);
        this.radius = GameEnvironment.Screen.Y / 4;
    }

    public override void Add(GameObject obj)
    {
        base.Add(obj);
        Update();
    }

    public override void Remove(GameObject obj)
    {
        base.Remove(obj);
        Update();
    }

    private void Update()
    {
        double step = 2 * Math.PI / Objects.Count;
        for (int i = 0; i < Objects.Count; i++) {
            double a = step * i - Math.PI / 2;
            Objects[i].Position = new Microsoft.Xna.Framework.Vector2(Position.X + (float)(radius * Math.Cos(a)), Position.Y + (float)(radius * Math.Sin(a)));
        }
    }
}
