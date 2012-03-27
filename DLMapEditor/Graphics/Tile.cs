using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace D2DMapEditor
{
    public enum TileType
    {
        Normal = 0,
        Ladder = 1,
        Door = 2
    }

    class Tile
    {
        #region properties

        public static string[] TileTypeStr = { "Normal", "Ladder", "Door" };
        public int TileID;
        public string TileName;
        public bool TileWalkable;
        public int Type;
        public int TileWidth;
        public int TileHeight;
        public string TilePath;
        public PictureBox TilePictureBox;

        #endregion

        public Tile()
        {
            TileWalkable = true;
            TileWidth = 0;
            TileHeight = 0;
            TilePath = "";
            Type = (int)TileType.Normal;
        }
    }
}
