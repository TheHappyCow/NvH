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
    //Returns a font with given assetname.
    public SpriteFont GetFont(string assetName)
    {
        if (assetName == "")
            return null;

        return contentmanager.Load<SpriteFont>(assetName);
    }
    //Plays a sound with given assetname.
    public void PlaySound(string assetName)
    {
        if (assetName == "")
            return;
        SoundEffect snd = contentmanager.Load<SoundEffect>(assetName);
        snd.Play(1,0, 0);
    }
    //Plays music with given assetname and repeats.
    public void PlayMusic(string assetName)
    {
        if (assetName == "")
            return;

        Song song = contentmanager.Load<Song>(assetName);
        if (song == null) return;
        MediaPlayer.Stop();
        MediaPlayer.IsRepeating = true;
        MediaPlayer.Play(song);
    }
}