﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portfolio_csharp_kanbara
{
    /*先手用ロジッククラス*/
    public class Logic
    {
        //数字変換
        #region 数字
        public static int tateNumberM(int a)
        {
            switch (a)
            {
                case Koma.nin:
                    return Koma.eig;
                case Koma.eig:
                    return Koma.sev;
                case Koma.sev:
                    return Koma.six;
                case Koma.six:
                    return Koma.fiv;
                case Koma.fiv:
                    return Koma.fou;
                case Koma.fou:
                    return Koma.thr;
                case Koma.thr:
                    return Koma.two;
                case Koma.two:
                    return Koma.one;
                default:
                    return 1;
            }

        }
        public static int tateNumberP(int a)
        {
            switch (a)
            {
                case Koma.one:
                    return Koma.two;
                case Koma.two:
                    return Koma.thr;
                case Koma.thr:
                    return Koma.fou;
                case Koma.fou:
                    return Koma.fiv;
                case Koma.fiv:
                    return Koma.six;
                case Koma.six:
                    return Koma.sev;
                case Koma.sev:
                    return Koma.eig;
                case Koma.eig:
                    return Koma.nin;
                default:
                    return 1;
            }

        }
        public static int yokoNumberM(int a)
        {
            switch (a)
            {
                case Koma.九:
                    return Koma.八;
                case Koma.八:
                    return Koma.七;
                case Koma.七:
                    return Koma.六;
                case Koma.六:
                    return Koma.伍;
                case Koma.伍:
                    return Koma.四;
                case Koma.四:
                    return Koma.参;
                case Koma.参:
                    return Koma.弐;
                case Koma.弐:
                    return Koma.壱;
                default:
                    return 1;
            }
        }
        public static int yokoNumberP(int a)
        {
            switch (a)
            {
                case Koma.壱:
                    return Koma.弐;
                case Koma.弐:
                    return Koma.参;
                case Koma.参:
                    return Koma.四;
                case Koma.四:
                    return Koma.伍;
                case Koma.伍:
                    return Koma.六;
                case Koma.六:
                    return Koma.七;
                case Koma.七:
                    return Koma.八;
                case Koma.八:
                    return Koma.九;
                default:
                    return 1;
            }
        }
        #endregion

        //歩の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 歩の移動範囲
        public static void hoLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(x, tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                    else if (str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }
        #endregion

        //香の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 香の移動範囲
        public static void kyoLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(x, tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0)
                    {
                        str.BackColor = color.移動可能場所色;
                        kyoLogic(x, tateNumberM(y));
                    }
                    else if (str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //桂馬の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 桂の移動範囲
        public static void keimaLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberM(tateNumberM(y))))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberM(tateNumberM(y))))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
            }
        }
        #endregion

        //銀の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 銀の移動範囲
        public static void ginLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(x, tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
            }
        }
        #endregion

        //金の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 金の移動範囲
        public static void kinLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(x, tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), y))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberM(x), y))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(x, tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
            }
        }
        #endregion

        //王の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 王の移動範囲
        public static void ouLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(x, tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), y))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberM(x), y))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(x, tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
                else if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                    }
                }
            }
        }
        #endregion

        //縦Pの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 縦Pの移動範囲
        public static void tatePLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(x, tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        tatePLogic(x, tateNumberP(y));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //横Pの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 横Pの移動範囲
        public static void yokoPLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberP(x), y))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        yokoPLogic(yokoNumberP(x), y);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //横Mの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 横Mの移動範囲
        public static void yokoMLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), y))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        yokoMLogic(yokoNumberM(x), y);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //飛車の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 飛車の移動範囲
        public static void hisyaLogic(int x, int y)
        {
            yokoMLogic(x, y);
            yokoPLogic(x, y);
            tatePLogic(x, y);
            kyoLogic(x, y);
        }
        #endregion

        //斜めPPの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 斜めPPの移動範囲
        public static void nanamePPLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        nanamePPLogic(yokoNumberP(x), tateNumberP(y));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //斜めPMの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 斜めPMの移動範囲
        public static void nanamePMLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberP(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        nanamePMLogic(yokoNumberP(x), tateNumberM(y));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //斜めMMの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 斜めMMの移動範囲
        public static void nanameMMLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberM(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        nanameMMLogic(yokoNumberM(x), tateNumberM(y));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //斜めMPの移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 斜めPMの移動範囲
        public static void nanameMPLogic(int x, int y)
        {
            KomaColor color = new KomaColor();

            foreach (Label str in Koma.駒)
            {
                if (str.Location == new System.Drawing.Point(yokoNumberM(x), tateNumberP(y)))
                {
                    if (str.Name.IndexOf("空白") == 0 || str.Name.IndexOf("敵") == 2)
                    {
                        str.BackColor = color.移動可能場所色;
                        if (str.Name.IndexOf("敵") == 2) { break; }
                        nanameMPLogic(yokoNumberM(x), tateNumberP(y));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        //角の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 角の移動範囲
        public static void kakuLogic(int x, int y)
        {
            nanamePMLogic(x, y);
            nanameMPLogic(x, y);
            nanamePPLogic(x, y);
            nanameMMLogic(x, y);
        }
        #endregion

        //竜の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 竜の移動範囲
        public static void ryuLogic(int x, int y)
        {
            yokoMLogic(x, y);
            yokoPLogic(x, y);
            tatePLogic(x, y);
            kyoLogic(x, y);
            ouLogic(x, y);
        }
        #endregion

        //馬の移動範囲の色を変更する「(((Label)sender).Location)のXYを入れる」
        #region 馬の移動範囲
        public static void umaLogic(int x, int y)
        {
            nanamePMLogic(x, y);
            nanameMPLogic(x, y);
            nanamePPLogic(x, y);
            nanameMMLogic(x, y);
            ouLogic(x, y);
        }
        #endregion

        //駒取得関数
        #region 駒取得
        public static string komaSyutoku(string str1)
        {
            int i = 0;
            if (str1.Length == 3)
            {
                i = Convert.ToInt32(str1[2].ToString());
            }
            else if (str1.Length == 4)
            {
                i = Convert.ToInt32(str1[2].ToString() + str1[3].ToString());
            }

            i++;
            string str2 = str1[0].ToString() + str1[1].ToString() + i.ToString();
            return str2;
        }
        #endregion
    }
}

