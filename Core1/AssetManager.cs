using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

public class AssetManager
{
    protected ContentManager contentmanager;

    public AssetManager(ContentManager Content)
    {
        this.contentmanager = Content;
    }

        public Texture2D GetSprite(string assetName)
    {
        if (assetName == "")
            return null;
        return contentmanager.Load<Texture2D>(assetName);
    }

        public ContentManager Content
        {
            get { return contentmanager; }
        }
}