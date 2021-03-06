using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace D2DMapEditor
{
    public enum ProgrammingLanguage
    {
        CPP = 1,
        CSharp = 2,
        ActionScript = 3,
        XML = 4,
        XMLLite = 5,
        Other = 6
    }

    class CodesGenerator
    {
        public static String GenerateCodes(int index, Map map, ImageFormat format, Tile[] tileLibrary, ProgrammingLanguage language)
        {
            if (!CodesDictionary.IsValidName(map.Layers[index].Name, language))
            {
                MessageBox.Show("\"" + map.Layers[index].Name + "\" is a reserved word!\nPlease change the layer name", "Update Layer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }

            string formatExtension = MapInfo.GetTileExtension(format);

            switch (language)
            {
                case ProgrammingLanguage.CPP:
                    return GenerateCPPCodes(index, map, tileLibrary, formatExtension);
                case ProgrammingLanguage.CSharp:
                    return GenerateCSharpCodes(index, map, tileLibrary, formatExtension);
                case ProgrammingLanguage.ActionScript:
                    return GenerateASCodes(index, map, tileLibrary, formatExtension);
                case ProgrammingLanguage.XML:
                    return GenerateXMLCodes(index, map, tileLibrary, formatExtension);
                case ProgrammingLanguage.XMLLite:
                    return GenerateXMLLiteCodes(index, map, tileLibrary, formatExtension);
                default:
                    return "";
            }
        }

        public static String GenerateCPPCodes(int index, Map map, Tile[] tileLibrary, string formatExtension)
        {
            StringWriter code = new StringWriter();
            code.Write("// This C++ code is generated by D2D Map Editor \r\n\r\n");

            code.Write("// Tile \r\n");
            code.Write("struct tile \r\n");
            code.Write("{ \r\n");
            code.Write("\tint id; \r\n");
            code.Write("\tstring name; \r\n");
            code.Write("\tbool walkable; \r\n");
            code.Write("\tstring path; \r\n");
            code.Write("}; \r\n\r\n");

            if (tileLibrary != null)
            {
                code.Write("tile myTiles[");
                code.Write(tileLibrary.Length);
                code.Write("]; \r\n\r\n");

                for (int i = 0; i < tileLibrary.Length; i++)
                {   // create tile structs
                    // tile id
                    code.Write("myTiles[");
                    code.Write(i);
                    code.Write("].id = ");
                    code.Write(tileLibrary[i].TileID);
                    code.Write("; \r\n");
                    // tile name
                    code.Write("myTiles[");
                    code.Write(i);
                    code.Write("].name = \"");
                    code.Write(tileLibrary[i].TileName);
                    code.Write("\"; \r\n");
                    // tile walkable
                    code.Write("myTiles[");
                    code.Write(i);
                    code.Write("].walkable = ");
                    code.Write(tileLibrary[i].TileWalkable.ToString().ToLower());
                    code.Write("; \r\n");
                    // tile bitmap
                    code.Write("myTiles[");
                    code.Write(i);
                    code.Write("].path = \"");
                    code.Write(Path.GetFileNameWithoutExtension(map.MapFileName));
                    if (Convert.ToInt32(tileLibrary[i].TileID) < 10)
                    {
                        code.Write("\\00");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else if (Convert.ToInt32(tileLibrary[i].TileID) < 100)
                    {
                        code.Write("\\0");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else
                    {
                        code.Write("\\");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    code.Write("\"; \r\n\r\n");
                }
            }

            code.Write("\r\n");
            code.Write("// Map size \r\n");
            code.Write("const int mapWidth = ");
            code.Write(map.Layers[index].Width);
            code.Write(";\r\n");
            code.Write("const int mapHeight = ");
            code.Write(map.Layers[index].Height);
            code.Write(";\r\n\r\n");
            code.Write("// Map alpha \r\n");
            code.Write("int mapAlpha = ");
            code.Write(map.Layers[index].Alpha);
            code.Write(";\r\n\r\n");
            
            code.Write("// Map Array \r\n");
            code.Write("int ");
            code.Write(map.Layers[index].Name);
            code.Write("[mapWidth][mapHeight] = {\r\n");

            for (int h = 0; h < map.Layers[index].Height; h++)
            {
                code.Write("\t{ ");
                for (int w = 0; w < map.Layers[index].Width; w++)
                {
                    code.Write(map.Layers[index].LayerData[w, h]);

                    if ((w + 1) != map.Layers[index].Width)
                        code.Write(", ");
                }
                code.Write("}");

                if ((h + 1) != map.Layers[index].Height)
                    code.Write(", ");

                code.Write("\r\n");
            }

            code.Write("};\r\n");

            return code.ToString();
        }

        public static String GenerateCSharpCodes(int index, Map map, Tile[] tileLibrary, string formatExtension)
        {
            StringWriter code = new StringWriter();
            code.Write("// This C# code is generated by D2D Map Editor \r\n\r\n");

            code.Write("// Tile \r\n");
            code.Write("struct tile \r\n");
            code.Write("{ \r\n");
            code.Write("\tint _id; \r\n");
            code.Write("\tString _name; \r\n");
            code.Write("\tBoolean _walkable; \r\n");
            code.Write("\tString _path; \r\n\r\n");

            code.Write("\tpublic tile(int id, String name, Boolean walkable, String path) \r\n");
            code.Write("\t{ \r\n");
            code.Write("\t\t_id = id; \r\n");
            code.Write("\t\t_name = name; \r\n");
            code.Write("\t\t_walkable = walkable; \r\n");
            code.Write("\t\t_path = path; \r\n");
            code.Write("\t} \r\n\r\n");

            code.Write("\tpublic int Id \r\n");
            code.Write("\t{ \r\n");
            code.Write("\t\tget \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\treturn _id; \r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t\tset \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\t_id = value;\r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t} \r\n\r\n");

            code.Write("\tpublic String Name \r\n");
            code.Write("\t{ \r\n");
            code.Write("\t\tget \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\treturn _name; \r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t\tset \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\t_name = value;\r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t} \r\n\r\n");

            code.Write("\tpublic Boolean Walkable \r\n");
            code.Write("\t{ \r\n");
            code.Write("\t\tget \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\treturn _walkable; \r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t\tset \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\t_walkable = value;\r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t} \r\n\r\n");

            code.Write("\tpublic String Path \r\n");
            code.Write("\t{ \r\n");
            code.Write("\t\tget \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\treturn _path; \r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t\tset \r\n");
            code.Write("\t\t{ \r\n");
            code.Write("\t\t\t_path = value;\r\n");
            code.Write("\t\t} \r\n");
            code.Write("\t} \r\n\r\n");

            code.Write("} \r\n\r\n");

            if (tileLibrary != null)
            {
                code.Write("tile[] myTiles = { \r\n");

                for (int i = 0; i < tileLibrary.Length; i++)
                {   // create tile structs

                    code.Write("\tnew tile(");
                    code.Write(tileLibrary[i].TileID);
                    code.Write(", \"");
                    code.Write(tileLibrary[i].TileName);
                    code.Write("\", ");
                    code.Write(tileLibrary[i].TileWalkable.ToString().ToLower());
                    code.Write(", \"");
                    code.Write(Path.GetFileNameWithoutExtension(map.MapFileName));
                    if (Convert.ToInt32(tileLibrary[i].TileID) < 10)
                    {
                        code.Write("\\00");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else if (Convert.ToInt32(tileLibrary[i].TileID) < 100)
                    {
                        code.Write("\\0");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else
                    {
                        code.Write("\\");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    code.Write("\")");

                    if (i < (tileLibrary.Length - 1))
                    {
                        code.Write(",");
                    }

                    code.Write("\r\n");
                }

                code.Write("}; \r\n\r\n");
            }

            code.Write("\r\n");
            code.Write("// Map size \r\n");
            code.Write("int mapWidth = ");
            code.Write(map.Layers[index].Width);
            code.Write(";\r\n");
            code.Write("int mapHeight = ");
            code.Write(map.Layers[index].Height);
            code.Write(";\r\n\r\n");
            code.Write("// Map alpha \r\n");
            code.Write("int mapAlpha = ");
            code.Write(map.Layers[index].Alpha);
            code.Write(";\r\n\r\n");

            code.Write("// Map Array \r\n");
            //code.Write("int[,] Map = new int[mapWidth, mapHeight]; \r\n\r\n");
            code.Write("int [,] ");
            code.Write(map.Layers[index].Name);
            code.Write(" = {\r\n");

            for (int h = 0; h < map.Layers[index].Height; h++)
            {
                code.Write("\t{ ");
                for (int w = 0; w < map.Layers[index].Width; w++)
                {
                    code.Write(map.Layers[index].LayerData[w, h]);

                    if ((w + 1) != map.Layers[index].Width)
                        code.Write(", ");
                }
                code.Write("}");

                if ((h + 1) != map.Layers[index].Height)
                    code.Write(", ");

                code.Write("\r\n");
            }

            code.Write("};\r\n");

            return code.ToString();
        }

        public static String GenerateASCodes(int index, Map map, Tile[] tileLibrary, string formatExtension)
        {
            StringWriter code = new StringWriter();
            code.Write("// This ActionScript code is generated by D2D Map Editor \r\n\r\n");

            code.Write("// Tile \r\n");
            code.Write("class tile \r\n");
            code.Write("{ \r\n");
            code.Write("\tvar _id:int; \r\n");
            code.Write("\tvar _name:String; \r\n");
            code.Write("\tvar _walkable:Boolean; \r\n");
            code.Write("\tvar _path:String; \r\n\r\n");

            code.Write("\tpublic function tile(id:int, name:String, walkable:Boolean, path:String) \r\n");
            code.Write("\t{ \r\n");
            code.Write("\t\t_id = id; \r\n");
            code.Write("\t\t_name = name; \r\n");
            code.Write("\t\t_walkable = walkable; \r\n");
            code.Write("\t\t_path = path; \r\n");
            code.Write("\t} \r\n");

            code.Write("} \r\n\r\n");

            if (tileLibrary != null)
            {
                code.Write("var myTiles:Array = new Array(); \r\n");

                for (int i = 0; i < tileLibrary.Length; i++)
                {   // create tile structs
                    code.Write("myTiles.push(new tile(");
                    code.Write(tileLibrary[i].TileID);
                    code.Write(", \"");
                    code.Write(tileLibrary[i].TileName);
                    code.Write("\", ");
                    code.Write(tileLibrary[i].TileWalkable.ToString().ToLower());
                    code.Write(", \"");
                    code.Write(Path.GetFileNameWithoutExtension(map.MapFileName));
                    if (Convert.ToInt32(tileLibrary[i].TileID) < 10)
                    {
                        code.Write("\\00");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else if (Convert.ToInt32(tileLibrary[i].TileID) < 100)
                    {
                        code.Write("\\0");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else
                    {
                        code.Write("\\");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    code.Write("\"));");
                    code.Write("\r\n");
                }
            }

            code.Write("\r\n");
            code.Write("// Map size \r\n");
            code.Write("var mapWidth:int = ");
            code.Write(map.Layers[index].Width);
            code.Write(";\r\n");
            code.Write("var mapHeight:int = ");
            code.Write(map.Layers[index].Height);
            code.Write(";\r\n\r\n");
            code.Write("// Map alpha \r\n");
            code.Write("var mapAlpha:int = ");
            code.Write(map.Layers[index].Alpha);
            code.Write(";\r\n\r\n");

            code.Write("// Map Array \r\n");
            code.Write("var ");
            code.Write(map.Layers[index].Name);
            code.Write(":Array = new Array(); \r\n");

            for (int h = 0; h < map.Layers[index].Height; h++)
            {
                code.Write(map.Layers[index].Name);
                code.Write("[");
                code.Write(h.ToString());
                code.Write("] = new Array(); \r\n");
                for (int w = 0; w < map.Layers[index].Width; w++)
                {
                    code.Write(map.Layers[index].Name);
                    code.Write("[");
                    code.Write(h.ToString());
                    code.Write("]");
                    code.Write("[");
                    code.Write(w.ToString());
                    code.Write("] = ");
                    code.Write(map.Layers[index].LayerData[w, h]);
                    code.Write("; \r\n");
                }
                code.Write("\r\n");
            }

            return code.ToString();
        }

        public static String GenerateXMLCodes(int index, Map map, Tile[] tileLibrary, string formatExtension)
        {
            StringWriter code = new StringWriter();
            code.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?> \r\n");
            //code.Write("<?xml version=\"1.0\" ?> \r\n");
            //code.Write("<!-- This XML map is generated by D2D Map Editor -->  \r\n");
            code.Write("<Tile");
            code.Write(" LayerWidth=\"");
            code.Write(map.Layers[index].Width);
            code.Write("\" LayerHeight=\"");
            code.Write(map.Layers[index].Height);
            code.Write("\" TileWidth=\"");
            code.Write(map.TileWidth);
            code.Write("\" TileHeight=\"");
            code.Write(map.TileHeight);
            code.Write("\" LayerAlpha=\"");
            code.Write(map.Layers[index].Alpha);
            code.Write("\" TileCount=\"");
            code.Write(tileLibrary.Length);
            code.Write("\">\r\n");

            for (int row = 0; row < map.Layers[index].Height; row++)
            {
                code.Write("\t<Row Position=\"");
                code.Write(row);
                code.Write("\">\r\n");

                for (int col = 0; col < map.Layers[index].Width; col++)
                {
                    code.Write("\t\t<Column Position=\"");
                    code.Write(col);
                    code.Write("\" Type=\"");
                    if (map.Layers[index].LayerData[col, row] == -1)
                    {
                        code.Write("-1\">");
                    }
                    else if (tileLibrary[map.Layers[index].LayerData[col, row]].Type != (int)TileType.Normal) 
                    {
                        code.Write(tileLibrary[map.Layers[index].LayerData[col, row]].Type);
                        code.Write("\">");
                    }
                    else if (tileLibrary[map.Layers[index].LayerData[col, row]].Type == (int)TileType.Normal)
                    {
                        if (tileLibrary[map.Layers[index].LayerData[col, row]].TileWalkable)
                        {
                            code.Write("-1\">");    // Type -1 means a walkable tile (or no tile)
                        }
                        else
                        {
                            code.Write(tileLibrary[map.Layers[index].LayerData[col, row]].Type);
                            code.Write("\">");
                        }

                    }

                    code.Write(map.Layers[index].LayerData[col, row]);
                    code.Write("</Column>\r\n");
                }

                code.Write("\t</Row>\r\n");
            }

            code.Write("</Tile>\r\n");
            //code.Write("</");
            //code.Write(map.Layers[index].Name);
            //code.Write(">\r\n\r\n");

            // tiles
            //if (tileLibrary != null)
            //{
            //    code.Write("<Tiles> \r\n");

            //    for (int i = 0; i < tileLibrary.Length; i++)
            //    {   // create tile structs

            //        code.Write("\t<Tile ID=\"");
            //        code.Write(tileLibrary[i].TileID);
            //        code.Write("\">\r\n");
            //        code.Write("\t\t<Name>");
            //        code.Write(tileLibrary[i].TileName);
            //        code.Write("</Name>\r\n");
            //        code.Write("\t\t<Walkable>");
            //        code.Write(tileLibrary[i].TileWalkable.ToString().ToLower());
            //        code.Write("</Walkable>\r\n");
            //        code.Write("\t\t<Path>");
            //        code.Write(Path.GetFileNameWithoutExtension(map.MapFileName));
            //        if (Convert.ToInt32(tileLibrary[i].TileID) < 10)
            //        {
 
            //            code.Write("\\00");
            //            code.Write(tileLibrary[i].TileID);
            //            code.Write(formatExtension);
            //        }
            //        else if (Convert.ToInt32(tileLibrary[i].TileID) < 100)
            //        {
            //            code.Write("\\0");
            //            code.Write(tileLibrary[i].TileID);
            //            code.Write(formatExtension);
            //        }
            //        else
            //        {
            //            code.Write("\\");
            //            code.Write(tileLibrary[i].TileID);
            //            code.Write(formatExtension);
            //        }
            //        code.Write("</Path>\r\n");
            //        code.Write("\t</Tile>\r\n");
            //    }

            //    code.Write("</Tiles>\r\n");
            //}

            return code.ToString();
        }

        public static String GenerateXMLLiteCodes(int index, Map map, Tile[] tileLibrary, string formatExtension)
        {
            StringWriter code = new StringWriter();
            code.Write("<Layer>\r\n");

            code.Write("\t<Properties>\r\n");
            code.Write("\t\t<Name>");
            code.Write(map.Layers[index].Name);
            code.Write("</Name>\r\n");
            code.Write("\t\t<LayerWidth>");
            code.Write(map.Layers[index].Width);
            code.Write("</LayerWidth>\r\n");
            code.Write("\t\t<LayerHeight>");
            code.Write(map.Layers[index].Height);
            code.Write("</LayerHeight>\r\n");
            code.Write("\t\t<TileWidth>");
            code.Write(map.TileWidth);
            code.Write("</TileWidth>\r\n");
            code.Write("\t\t<TileHeight>");
            code.Write(map.TileHeight);
            code.Write("</TileHeight>\r\n");
            code.Write("\t\t<Alpha>");
            code.Write(map.Layers[index].Alpha);
            code.Write("</Alpha>\r\n");
            code.Write("\t</Properties>\r\n\r\n");

            code.Write("\t<Layout>\r\n");
            for (int row = 0; row < map.Layers[index].Height; row++)
            {
                code.Write("\t\t");
                for (int col = 0; col < map.Layers[index].Width; col++)
                {
                    code.Write(map.Layers[index].LayerData[col, row]);
                    code.Write(" ");
                }
                code.Write("\r\n");
            }
            code.Write("\t</Layout>\r\n\r\n");

            // tiles
            if (tileLibrary != null)
            {
                code.Write("\t<Tiles> \r\n");
                for (int i = 0; i < tileLibrary.Length; i++)
                {   // create tile structs

                    code.Write("\t\t<Tile ID=\"");
                    code.Write(tileLibrary[i].TileID);
                    code.Write("\" Name=\"");
                    code.Write(tileLibrary[i].TileName);
                    code.Write("\" Walkable=\"");
                    code.Write(tileLibrary[i].TileWalkable);
                    code.Write("\" File=\"");
                    code.Write(Path.GetFileNameWithoutExtension(map.MapFileName));
                    if (Convert.ToInt32(tileLibrary[i].TileID) < 10)
                    {
                        code.Write("\\00");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else if (Convert.ToInt32(tileLibrary[i].TileID) < 100)
                    {
                        code.Write("\\0");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    else
                    {
                        code.Write("\\");
                        code.Write(tileLibrary[i].TileID);
                        code.Write(formatExtension);
                    }
                    code.Write("\" />\r\n");
                }
                code.Write("\t</Tiles>\r\n");
            }

            code.Write("</Layer>");

            return code.ToString();
        }
    }
}
