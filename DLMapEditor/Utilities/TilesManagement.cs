using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Drawing.Imaging;

namespace D2DMapEditor
{
    class TilesManagement
    {
        public static readonly int TileMargin = 5;

        public static void AddTiles(D2DMapEditor d2d, Map map, ref Tile[] tileLibrary, ListView lvTileLibrary, ImageList ilTileImages, string folderName)
        {   // add tiles to tile library
            ArrayList tilesArrayList = new ArrayList();

            Cursor.Current = Cursors.WaitCursor;

            foreach (string f in Directory.GetFiles(folderName))
            {   // load tiles
                if (Path.GetExtension(f) == ".bmp" || Path.GetExtension(f) == ".jpg" || Path.GetExtension(f) == ".gif" || Path.GetExtension(f) == ".png")
                    tilesArrayList.Add(f.ToString());
            }

            // delete all controls
            //lvTileLibrary.Controls.Clear();
            //lvTileLibrary.Refresh();

            int t = 0;

            // resize tileLibrary
            if (tileLibrary != null && tileLibrary.Length > 0)
            {   // add to the library
                t = tileLibrary.Length;
                Array.Resize(ref tileLibrary, tilesArrayList.Count + tileLibrary.Length);
            }
            else
            {   // load new library
                Array.Resize(ref tileLibrary, tilesArrayList.Count);
            }
            
            PictureBox pB = null;
            ListViewItem item = null;

            foreach (string i in tilesArrayList)
            {   // update tiles library
                Tile newTile = new Tile();
                pB = new PictureBox();
                pB.Width = map.TileWidth;
                pB.Height = map.TileHeight;
                pB.Name = t.ToString();
                pB.Load(i);
                newTile.TileID = t;
                newTile.TileName = t.ToString();
                newTile.TilePictureBox = pB;
                tileLibrary[t] = newTile;

                ilTileImages.Images.Add(pB.Image);

                item = new ListViewItem();
                item.ImageIndex = t;
                lvTileLibrary.Items.Add(item);

                t++;
            }

            if (pB != null)
            {
                ilTileImages.ImageSize = new Size(pB.Width, pB.Height);
                lvTileLibrary.TileSize = new Size(ilTileImages.ImageSize.Width + TileMargin, ilTileImages.ImageSize.Height + TileMargin);
            }

            lvTileLibrary.LargeImageList = ilTileImages;

            lvTileLibrary.MouseClick += new MouseEventHandler(d2d.tilePicBox_MouseClick);

            lvTileLibrary.Refresh();  
            //RenderTiles(map, ref tileLibrary, lvTileLibrary);

            Cursor.Current = Cursors.Default;
        }

        public static void LoadTiles(D2DMapEditor d2d, Map map, ref Tile[] tileLibrary, ListView lvTileLibrary, ImageList ilTileImages, string fileName)
        {   // load tiles from the saved tile library
            // clear tile library
            if (tileLibrary != null)
                Array.Clear(tileLibrary, 0, tileLibrary.Length);

            // load tiles
            ///////////////
            string pbDirName = Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName);

            ArrayList tilesArrayList = new ArrayList();

            // delete all controls
            lvTileLibrary.Controls.Clear();
            lvTileLibrary.Refresh();

            if (Directory.Exists(pbDirName))
            {
                foreach (string f in Directory.GetFiles(pbDirName))
                {   // load tiles
                    if (Path.GetExtension(f) == ".bmp" || Path.GetExtension(f) == ".jpg" || Path.GetExtension(f) == ".gif" || Path.GetExtension(f) == ".png")
                        tilesArrayList.Add(f.ToString());
                }

                int t = 0;

                // resize tileLibrary
                Array.Resize(ref tileLibrary, tilesArrayList.Count);

                PictureBox pB = null;
                ListViewItem item = null;

                foreach (string i in tilesArrayList)
                {   // update tiles library
                    Tile newTile = new Tile();
                    pB = new PictureBox();
                    pB.Width = map.TileWidth;
                    pB.Height = map.TileHeight;
                    pB.Name = t.ToString();
                    pB.Load(i);
                    newTile.TileID = t;
                    newTile.TileName = t.ToString();
                    newTile.TilePictureBox = pB;
                    tileLibrary[t] = newTile;

                    ilTileImages.Images.Add(pB.Image);

                    item = new ListViewItem();
                    item.ImageIndex = t;
                    lvTileLibrary.Items.Add(item);

                    t++;
                }

                if (pB != null)
                {
                    ilTileImages.ImageSize = new Size(pB.Width, pB.Height);
                    lvTileLibrary.TileSize = new Size(ilTileImages.ImageSize.Width + TileMargin, ilTileImages.ImageSize.Height + TileMargin);
                }

                lvTileLibrary.LargeImageList = ilTileImages;

                lvTileLibrary.MouseClick += new MouseEventHandler(d2d.tilePicBox_MouseClick);

                lvTileLibrary.Refresh();  
            }
            else
            {
                MessageBox.Show(pbDirName + " doesn't exist! This folder is needed for the Tiles Library.", "Cannot Find Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string tileLibraryFileName = Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + "-tile.xml";
            FileStream tfs = new FileStream(tileLibraryFileName, FileMode.Open);
            XmlDocument tr = new XmlDocument();
            tr.Load(tfs);

            XmlNodeList tileList = tr.GetElementsByTagName("Tile");

            foreach (XmlNode node in tileList)
            {
                XmlElement tileElement = (XmlElement)node;

                int tileID = Convert.ToInt32(tileElement.Attributes["ID"].InnerText);

                tileLibrary[tileID].TileName = tileElement.GetElementsByTagName("Name")[0].InnerText;
                tileLibrary[tileID].TileWidth = Convert.ToInt32(tileElement.GetElementsByTagName("Width")[0].InnerText);
                tileLibrary[tileID].TileHeight = Convert.ToInt32(tileElement.GetElementsByTagName("Height")[0].InnerText);
                tileLibrary[tileID].TileWalkable = Convert.ToBoolean(tileElement.GetElementsByTagName("Walkable")[0].InnerText);
                tileLibrary[tileID].Type = Convert.ToInt32(tileElement.GetElementsByTagName("Type")[0].InnerText);
            }

            tfs.Close();
        }

        public static void SaveTiles(ref Tile[] tileLibrary, string fileName)
        {   // save tiles to xml file
            string tileFileName = Path.GetFileNameWithoutExtension(fileName) + "-tile.xml";
            FileStream tfs = new FileStream(tileFileName, FileMode.Create);
            XmlTextWriter tw = new XmlTextWriter(tfs, null);

            string pbDirName = Path.GetFileNameWithoutExtension(fileName);
            Directory.CreateDirectory(pbDirName);

            tw.WriteStartDocument();
            tw.WriteStartElement("D2DMapTilesLibrary");
            tw.WriteAttributeString("TotalTiles", tileLibrary.Length.ToString());
            tw.WriteComment("This Tiles Library is generated by D2D Map Editor!");

            for (int i = 0; i < tileLibrary.Length; i++)
            {
                tw.WriteStartElement("Tile");
                tw.WriteAttributeString("ID", tileLibrary[i].TileID.ToString());

                tw.WriteStartElement("Name");
                tw.WriteString(tileLibrary[i].TileName);
                tw.WriteEndElement();
                tw.WriteStartElement("Width");
                tw.WriteString(tileLibrary[i].TileWidth.ToString());
                tw.WriteEndElement();
                tw.WriteStartElement("Height");
                tw.WriteString(tileLibrary[i].TileHeight.ToString());
                tw.WriteEndElement();
                tw.WriteStartElement("Walkable");
                tw.WriteString(tileLibrary[i].TileWalkable.ToString());
                tw.WriteEndElement();
                tw.WriteStartElement("Type");
                tw.WriteString(tileLibrary[i].Type.ToString());
                tw.WriteEndElement();

                tw.WriteEndElement();

                SaveTileImage(ref tileLibrary, i, pbDirName, ImageFormat.Png);
            }

            // close the root element
            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Close();
            tfs.Close();
        }

        public static void SaveTileImage(ref Tile[] tileLibrary, int i, string pbDirName, ImageFormat format)
        {
            PictureBox pb = tileLibrary[i].TilePictureBox;
            string formatExtension = MapInfo.GetTileExtension(format);

            if (Convert.ToInt32(pb.Name) >= 0)
            {
                Image img = pb.Image;
                Bitmap bmp = new Bitmap(img);

                string pbFileName = "";

                if (Convert.ToInt32(pb.Name) < 10)
                    pbFileName = pbDirName + "\\tile_00" + pb.Name.ToString() + formatExtension;
                else if (Convert.ToInt32(pb.Name) < 100)
                    pbFileName = pbDirName + "\\tile_0" + pb.Name.ToString() + formatExtension;
                else
                    pbFileName = pbDirName + "\\tile_" + pb.Name.ToString() + formatExtension;

                try
                {
                    bmp.Save(pbFileName, format);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Fail to Save Tiles\n" + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ClearTiles(D2DMapEditor d2d, Map map, ref Tile[] tileLibrary, ListView lvTileLibrary, ImageList ilTileImages)
        {   // clear all tiles in the tile library
            // delete all controls
            lvTileLibrary.Items.Clear();
            //ilTileImages.Images.Clear();

            if (tileLibrary != null)
            {
                Array.Clear(tileLibrary, 0, tileLibrary.Length);
                Array.Resize(ref tileLibrary, 0);
            }

            // initialized map
            foreach (Layer layer in map.Layers)
                for (int x = 0; x < layer.Width; x++)
                    for (int y = 0; y < layer.Height; y++)
                        layer.LayerData[x, y] = -1;

            lvTileLibrary.Refresh();
            d2d.ClearSelectedTile();
        }

        public static void DeleteSelectedTile(D2DMapEditor d2d, Map map, ref Tile[] tileLibrary, ListView lvTileLibrary, ImageList ilTileImages, int selectedTileID)
        {   // remove selected tile from tile library
            if (tileLibrary != null)
            {   // remove that tile
                int i = 0;
                for (i = selectedTileID; i < tileLibrary.Length - 1; i++)
                {
                    tileLibrary[i].TileWidth = tileLibrary[i + 1].TileWidth;
                    tileLibrary[i].TileHeight = tileLibrary[i + 1].TileHeight;
                    tileLibrary[i].TilePath = tileLibrary[i + 1].TilePath;
                    tileLibrary[i].TileWalkable = tileLibrary[i + 1].TileWalkable;
                    tileLibrary[i].TilePictureBox = tileLibrary[i + 1].TilePictureBox;
                    tileLibrary[i].TilePictureBox.Name = tileLibrary[i].TileName;

                    //if (tileLibrary[i + 1].TileName == tileLibrary[i + 1].TileID.ToString())
                    //    tileLibrary[i].TileName = tileLibrary[i].TileID.ToString();
                    //else
                    //    tileLibrary[i].TileName = tileLibrary[i + 1].TileName;

                    //tileLibrary[i].TileID = i;
                }
                Array.Clear(tileLibrary, i, 1);
                Array.Resize(ref tileLibrary, tileLibrary.Length - 1);

                //ilTileImages.Images.RemoveAt(selectedTileID);
                lvTileLibrary.Items.RemoveAt(selectedTileID);
            }

            // update map
            foreach (Layer layer in map.Layers)
            {
                for (int x = 0; x < layer.Width; x++)
                {
                    for (int y = 0; y < layer.Height; y++)
                    {
                        if (layer.LayerData[x, y] == selectedTileID)
                        {
                            layer.LayerData[x, y] = -1;
                        }
                        else if (layer.LayerData[x, y] > selectedTileID)
                        {
                            layer.LayerData[x, y] = layer.LayerData[x, y] - 1;
                        }
                    }
                }
            }

            //RenderTiles(map, ref tileLibrary, lvTileLibrary);
            lvTileLibrary.Refresh();
            d2d.RenderMap();
            d2d.ClearSelectedTile();
        }

        public static void RenderTiles(Map map, ref Tile[] tileLibrary, ListView lvTileLibrary)
        {   // render tiles in the tile library panel
            lvTileLibrary.Controls.Clear();
            ImageList ilTileImages = new ImageList();

            PictureBox pb = null;
            ListViewItem item = null;
            if (tileLibrary != null)
            {
                for (int i = 0; i < tileLibrary.Length; i++)
                {   // reload tiles panel
                    pb = tileLibrary[i].TilePictureBox;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (pb != null)
                    {
                        pb.Width = map.TileWidth;
                        pb.Height = map.TileHeight;
                        pb.Name = i.ToString();

                        ilTileImages.Images.Add(pb.Image);

                        item = new ListViewItem();
                        item.ImageIndex = i;
                        lvTileLibrary.Items.Add(item);
                    }
                }

                if (pb != null)
                {
                    ilTileImages.ImageSize = new Size(pb.Width, pb.Height);
                    lvTileLibrary.TileSize = new Size(ilTileImages.ImageSize.Width + TileMargin, ilTileImages.ImageSize.Height + TileMargin);
                }

                lvTileLibrary.LargeImageList = ilTileImages;
            }

            lvTileLibrary.Refresh();
        }
    }
}
