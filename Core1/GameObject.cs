using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

public class GameObject : Root
{
    protected GameObject parent;
    protected Vector2 velocity;
    protected Vector2 position;
    protected string id;

    public GameObject(string id = "")
    {
        this.velocity = Vector2.Zero;
        this.id = id;
    }

    public virtual void HandleInput(InputHelper inputHelper)
    {
    }

    public virtual void Update(GameTime gameTime)
    {
    }

    public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
    }

    public virtual Vector2 Position
    {
        get { return position; }
        set { position = value; }
    }

    public virtual Vector2 Velocity
    {
        get { return velocity; }
        set { velocity = value; }
    }

    public string ID
    {
        get { return id; }
    }

    public virtual GameObject Parent
    {
        get { return parent; }
        set { parent = value; }
    }
}
