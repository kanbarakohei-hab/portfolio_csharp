using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portfolio_csharp_kanbara
{

    public partial class Form1 : Form
    {
        //クラス定義
        Koma koma2 = new Koma();
        MotigomaM motigomaM = new MotigomaM();
        Text_Name textname = new Text_Name();
        KomaColor color = new KomaColor();

        //テキスト用変数
        static int count = 0;
        //空白のインスタンス用
        public static int countZ = 0;
        //処理変換用フラグ
        public static int FlagA;

        public Form1()
        {
            //駒を生成するメソッド(修正必要)
            InitializeComponent();
        }
        //現在不要
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //現在不要(ページロード時に呼ばれる関数)
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        // 味方の持ち駒をクリックした際に呼ばれる関数
        private void 味方持ち駒_Click(object sender, EventArgs e)
        {
            KomaColor color = new KomaColor();

            //判定が「0」でないならreturn
            if ((FlagA != 0) && (FlagA != 5))
            {
                return;
            }

            //「桂X0」この形式で格納されているので駒の個数を調べる
            int i = 0;
            if (((Label)sender).Text.Length == 3)
            {
                i = Convert.ToInt32(((Label)sender).Text[2].ToString());
            }
            else if (((Label)sender).Text.Length == 4)
            {
                i = Convert.ToInt32(((Label)sender).Text[2].ToString() + ((Label)sender).Text[3].ToString());
            }
            else
            {
                return;
            }
            if (FlagA == 5)
            {
                if (Koma.文字 == "歩")
                {
                    komadai_Hu_Mikata.Text = komadai_Hu_Mikata.Text[0].ToString() + komadai_Hu_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Hu_Mikata.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "香")
                {
                    komadai_Kyou_Mikata.Text = komadai_Kyou_Mikata.Text[0].ToString() + komadai_Kyou_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kyou_Mikata.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "桂")
                {
                    komadai_Kei_Mikata.Text = komadai_Kei_Mikata.Text[0].ToString() + komadai_Kei_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kei_Mikata.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "銀")
                {
                    komadai_Gin_Mikata.Text = komadai_Gin_Mikata.Text[0].ToString() + komadai_Gin_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Gin_Mikata.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "金")
                {
                    komadai_Kin_Mikata.Text = komadai_Kin_Mikata.Text[0].ToString() + komadai_Kin_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kin_Mikata.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "角")
                {
                    komadai_Kaku_Mikata.Text = komadai_Kaku_Mikata.Text[0].ToString() + komadai_Kaku_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kaku_Mikata.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "飛")
                {
                    komadai_Hi_Mikata.Text = komadai_Hi_Mikata.Text[0].ToString() + komadai_Hi_Mikata.Text[1].ToString() + (i + 1).ToString();
                    komadai_Hi_Mikata.BackColor = color.持ち駒変化色;
                }
                FlagA = 0;
                return;
            }
            //個数「0」はreturn
            if (i == 0)
            {
                return;
            }

            if (((Label)sender).Text.IndexOf("歩") == 0)
            {
                koma2.駒情報A = MotigomaM.味歩[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味歩[i - 1].文字;
                //Koma.インデックス = MotigomaM.味歩[i].インデックス;
                Koma.色A = MotigomaM.味歩[i - 1].色A;
                Koma.色B = MotigomaM.味歩[i - 1].色B;
                Koma.名前 = (MotigomaM.味歩[i - 1].名前)[0].ToString() + (MotigomaM.味歩[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味歩[i - 1].名前)[2].ToString();
                komadai_Hu_Mikata.Text = komadai_Hu_Mikata.Text[0].ToString() + komadai_Hu_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Hu_Mikata.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("桂") == 0)
            {
                koma2.駒情報A = MotigomaM.味桂[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味桂[i - 1].文字;
                //Koma.インデックス = MotigomaM.味桂[i].インデックス;
                Koma.色A = MotigomaM.味桂[i - 1].色A;
                Koma.色B = MotigomaM.味桂[i - 1].色B;
                Koma.名前 = (MotigomaM.味桂[i - 1].名前)[0].ToString() + (MotigomaM.味桂[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味桂[i - 1].名前)[2].ToString();
                komadai_Kei_Mikata.Text = komadai_Kei_Mikata.Text[0].ToString() + komadai_Kei_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kei_Mikata.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("香") == 0)
            {
                koma2.駒情報A = MotigomaM.味香[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味香[i - 1].文字;
                //Koma.インデックス = MotigomaM.味香[i].インデックス;
                Koma.色A = MotigomaM.味香[i - 1].色A;
                Koma.色B = MotigomaM.味香[i - 1].色B;
                Koma.名前 = (MotigomaM.味香[i - 1].名前)[0].ToString() + (MotigomaM.味香[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味香[i - 1].名前)[2].ToString();
                komadai_Kyou_Mikata.Text = komadai_Kyou_Mikata.Text[0].ToString() + komadai_Kyou_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kyou_Mikata.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("銀") == 0)
            {
                koma2.駒情報A = MotigomaM.味銀[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味銀[i - 1].文字;
                //Koma.インデックス = MotigomaM.味銀[i].インデックス;
                Koma.色A = MotigomaM.味銀[i - 1].色A;
                Koma.色B = MotigomaM.味銀[i - 1].色B;
                Koma.名前 = (MotigomaM.味銀[i - 1].名前)[0].ToString() + (MotigomaM.味銀[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味銀[i - 1].名前)[2].ToString();
                komadai_Gin_Mikata.Text = komadai_Gin_Mikata.Text[0].ToString() + komadai_Gin_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Gin_Mikata.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("金") == 0)
            {
                koma2.駒情報A = MotigomaM.味金[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味金[i - 1].文字;
                //Koma.インデックス = MotigomaM.味金[i].インデックス;
                Koma.色A = MotigomaM.味金[i - 1].色A;
                Koma.色B = MotigomaM.味金[i - 1].色B;
                Koma.名前 = (MotigomaM.味金[i - 1].名前)[0].ToString() + (MotigomaM.味金[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味金[i - 1].名前)[2].ToString();
                komadai_Kin_Mikata.Text = komadai_Kin_Mikata.Text[0].ToString() + komadai_Kin_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kin_Mikata.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("角") == 0)
            {
                koma2.駒情報A = MotigomaM.味角[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味角[i - 1].文字;
                //Koma.インデックス = MotigomaM.味角[i].インデックス;
                Koma.色A = MotigomaM.味角[i - 1].色A;
                Koma.色B = MotigomaM.味角[i - 1].色B;
                Koma.名前 = (MotigomaM.味角[i - 1].名前)[0].ToString() + (MotigomaM.味角[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味角[i - 1].名前)[2].ToString();
                komadai_Kaku_Mikata.Text = komadai_Kaku_Mikata.Text[0].ToString() + komadai_Kaku_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kaku_Mikata.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("飛") == 0)
            {
                koma2.駒情報A = MotigomaM.味飛[i - 1].駒情報C;
                Koma.文字 = MotigomaM.味飛[i - 1].文字;
                //Koma.インデックス = MotigomaM.味飛[i].インデックス;
                Koma.色A = MotigomaM.味飛[i - 1].色A;
                Koma.色B = MotigomaM.味飛[i - 1].色B;
                Koma.名前 = (MotigomaM.味飛[i - 1].名前)[0].ToString() + (MotigomaM.味飛[i - 1].名前)[1].ToString() + "味" + (MotigomaM.味飛[i - 1].名前)[2].ToString();
                komadai_Hi_Mikata.Text = komadai_Hi_Mikata.Text[0].ToString() + komadai_Hi_Mikata.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Hi_Mikata.BackColor = Color.Transparent;
                }
            }

            //KomaColor color = new KomaColor();
            foreach (Label str in Koma.駒)
            {
                if (str.Name.IndexOf("空白") == 0)
                {
                    str.BackColor = color.移動可能場所色;
                }
            }
            FlagA = 5;
            return;
        }

        private void 敵持ち駒_Click(object sender, EventArgs e)
        {
            KomaColor color = new KomaColor();
            //判定が「2」でないならreturn
            if ((FlagA != 2) && (FlagA != 6))
            {
                return;
            }
            //「桂X0」この形式で格納されているので駒の個数を調べる
            int i = 0;
            if (((Label)sender).Text.Length == 3)
            {
                i = Convert.ToInt32(((Label)sender).Text[2].ToString());
            }
            else if (((Label)sender).Text.Length == 4)
            {
                i = Convert.ToInt32(((Label)sender).Text[2].ToString() + ((Label)sender).Text[3].ToString());
            }
            else
            {
                return;
            }
            if (FlagA == 6)
            {
                if (Koma.文字 == "歩")
                {
                    komadai_Hu_Teki.Text = komadai_Hu_Teki.Text[0].ToString() + komadai_Hu_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Hu_Teki.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "香")
                {
                    komadai_Kyou_Teki.Text = komadai_Kyou_Teki.Text[0].ToString() + komadai_Kyou_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kyou_Teki.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "桂")
                {
                    komadai_Kei_Teki.Text = komadai_Kei_Teki.Text[0].ToString() + komadai_Kei_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kei_Teki.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "銀")
                {
                    komadai_Gin_Teki.Text = komadai_Gin_Teki.Text[0].ToString() + komadai_Gin_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Gin_Teki.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "金")
                {
                    komadai_Kin_Teki.Text = komadai_Kin_Teki.Text[0].ToString() + komadai_Kin_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kin_Teki.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "角")
                {
                    komadai_Kaku_Teki.Text = komadai_Kaku_Teki.Text[0].ToString() + komadai_Kaku_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Kaku_Teki.BackColor = color.持ち駒変化色;
                }
                else if (Koma.文字 == "飛")
                {
                    komadai_Hi_Teki.Text = komadai_Hi_Teki.Text[0].ToString() + komadai_Hi_Teki.Text[1].ToString() + (i + 1).ToString();
                    komadai_Hi_Teki.BackColor = color.持ち駒変化色;
                }
                FlagA = 2;
                return;
            }

            //個数「0」は処理終了
            if (i == 0)
            {
                return;
            }
            if (((Label)sender).Text.IndexOf("歩") == 0)
            {
                koma2.駒情報A = MotigomaM.敵歩[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵歩[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵歩[i].インデックス;
                Koma.色A = MotigomaM.敵歩[i - 1].色A;
                Koma.色B = MotigomaM.敵歩[i - 1].色B;
                Koma.名前 = (MotigomaM.敵歩[i - 1].名前)[0].ToString() + (MotigomaM.敵歩[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵歩[i - 1].名前)[2].ToString();
                komadai_Hu_Teki.Text = komadai_Hu_Teki.Text[0].ToString() + komadai_Hu_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Hu_Teki.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("桂") == 0)
            {
                koma2.駒情報A = MotigomaM.敵桂[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵桂[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵桂[i].インデックス;
                Koma.色A = MotigomaM.敵桂[i - 1].色A;
                Koma.色B = MotigomaM.敵桂[i - 1].色B;
                Koma.名前 = (MotigomaM.敵桂[i - 1].名前)[0].ToString() + (MotigomaM.敵桂[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵桂[i - 1].名前)[2].ToString();
                komadai_Kei_Teki.Text = komadai_Kei_Teki.Text[0].ToString() + komadai_Kei_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kei_Teki.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("香") == 0)
            {
                koma2.駒情報A = MotigomaM.敵香[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵香[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵香[i].インデックス;
                Koma.色A = MotigomaM.敵香[i - 1].色A;
                Koma.色B = MotigomaM.敵香[i - 1].色B;
                Koma.名前 = (MotigomaM.敵香[i - 1].名前)[0].ToString() + (MotigomaM.敵香[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵香[i - 1].名前)[2].ToString();
                komadai_Kyou_Teki.Text = komadai_Kyou_Teki.Text[0].ToString() + komadai_Kyou_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kyou_Teki.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("銀") == 0)
            {
                koma2.駒情報A = MotigomaM.敵銀[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵銀[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵銀[i].インデックス;
                Koma.色A = MotigomaM.敵銀[i - 1].色A;
                Koma.色B = MotigomaM.敵銀[i - 1].色B;
                Koma.名前 = (MotigomaM.敵銀[i - 1].名前)[0].ToString() + (MotigomaM.敵銀[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵銀[i - 1].名前)[2].ToString();
                komadai_Gin_Teki.Text = komadai_Gin_Teki.Text[0].ToString() + komadai_Gin_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Gin_Teki.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("金") == 0)
            {
                koma2.駒情報A = MotigomaM.敵金[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵金[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵金[i].インデックス;
                Koma.色A = MotigomaM.敵金[i - 1].色A;
                Koma.色B = MotigomaM.敵金[i - 1].色B;
                Koma.名前 = (MotigomaM.敵金[i - 1].名前)[0].ToString() + (MotigomaM.敵金[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵金[i - 1].名前)[2].ToString();
                komadai_Kin_Teki.Text = komadai_Kin_Teki.Text[0].ToString() + komadai_Kin_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kin_Teki.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("角") == 0)
            {
                koma2.駒情報A = MotigomaM.敵角[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵角[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵角[i].インデックス;
                Koma.色A = MotigomaM.敵角[i - 1].色A;
                Koma.色B = MotigomaM.敵角[i - 1].色B;
                Koma.名前 = (MotigomaM.敵角[i - 1].名前)[0].ToString() + (MotigomaM.敵角[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵角[i - 1].名前)[2].ToString();
                komadai_Kaku_Teki.Text = komadai_Kaku_Teki.Text[0].ToString() + komadai_Kaku_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Kaku_Teki.BackColor = Color.Transparent;
                }
            }
            if (((Label)sender).Text.IndexOf("飛") == 0)
            {
                koma2.駒情報A = MotigomaM.敵飛[i - 1].駒情報C;
                Koma.文字 = MotigomaM.敵飛[i - 1].文字;
                //Koma.インデックス = MotigomaM.敵飛[i].インデックス;
                Koma.色A = MotigomaM.敵飛[i - 1].色A;
                Koma.色B = MotigomaM.敵飛[i - 1].色B;
                Koma.名前 = (MotigomaM.敵飛[i - 1].名前)[0].ToString() + (MotigomaM.敵飛[i - 1].名前)[1].ToString() + "敵" + (MotigomaM.敵飛[i - 1].名前)[2].ToString();
                komadai_Hi_Teki.Text = komadai_Hi_Teki.Text[0].ToString() + komadai_Hi_Teki.Text[1].ToString() + (i - 1).ToString();
                if ((i - 1) == 0)
                {
                    komadai_Hi_Teki.BackColor = Color.Transparent;
                }
            }
            foreach (Label str in Koma.駒)
            {
                if (str.Name.IndexOf("空白") == 0)
                {
                    str.BackColor = color.移動可能場所色;
                }
            }
            FlagA = 6;
            return;
        }

        //駒(空白を含む)をクリック時に呼ばれる関数
        private void 将棋_Click(object sender, EventArgs e)
        {
            try
            {
                //名前が味方か空白のとき
                #region 味方選択
                if (FlagA == 0)
                {
                    //情報を渡すために使う
                    koma2.駒情報A = ((Label)sender);
                    Koma.文字 = (((Label)sender).Text);
                    //Koma.インデックス = (((Label)sender).TabIndex);
                    Koma.色A = (((Label)sender).ForeColor);
                    Koma.色B = (((Label)sender).BackColor);
                    Koma.名前 = (((Label)sender).Name);

                    // 空白か敵の駒を押しても何もせずに返却する
                    if (((Label)sender).Name.IndexOf("空白") == 0 || (((Label)sender).Name.IndexOf("敵") == 2))
                    {
                        return;
                    }
                    #region 押したら色変更
                    foreach (Label str in Koma.駒)
                    {
                        //押した駒
                        if (str.Name == ((Label)sender).Name)
                        {
                            str.BackColor = color.変化後選択駒色;
                        }
                        //空白
                        else if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.変化後空白色;
                        }
                        //他の駒
                        else
                        {
                            str.BackColor = color.変化後無関係駒色;
                        }
                    }
                    #endregion

                    //名前が歩の場合、歩の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("歩") == 0)
                    {
                        Logic.hoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が香の場合、香の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("香") == 0)
                    {
                        Logic.kyoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が桂の場合、桂の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("桂") == 0)
                    {
                        Logic.keimaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が銀の場合、銀の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("銀") == 0)
                    {
                        Logic.ginLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が金の場合、金の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("金") == 0)
                    {
                        Logic.kinLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が王の場合、王の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("王") == 0)
                    {
                        Logic.ouLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が飛車の場合、飛車の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("飛") == 0)
                    {
                        Logic.hisyaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が角の場合、角の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("角") == 0)
                    {
                        Logic.kakuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が竜の場合、竜の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("竜") == 0)
                    {
                        Logic.ryuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が馬の場合、馬の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("馬") == 0)
                    {
                        Logic.umaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }

                    FlagA = 1;
                    return;
                }
                #endregion

                #region 移動
                if (FlagA == 1)
                {
                    //色が変化していないならreturn(移動できる場所以外かつ移動させる駒以外)
                    if (((Label)sender).BackColor != color.移動可能場所色
                        && ((Label)sender).BackColor != color.変化後選択駒色)
                    {
                        return;
                    }
                    //移動させる駒なら
                    if (((Label)sender).BackColor == color.変化後選択駒色)
                    {
                        //色を元に戻して、FlagAに0を入れてreturn
                        foreach (Label str in Koma.駒)
                        {
                            if (str.Name.IndexOf("空白") == 0)
                            {
                                str.BackColor = color.空白色;
                            }
                            //それ以外の場合
                            else
                            {
                                str.BackColor = color.通常駒色;
                            }
                        }
                        FlagA = 0;
                        return;
                    }

                    foreach (Label str in Koma.駒)
                    {
                        //ラベルの色を変化させる
                        //空白の場合
                        if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.空白色;
                        }
                        //それ以外の場合
                        else
                        {
                            str.BackColor = color.通常駒色;
                        }
                    }
                    foreach (Label str in Koma.駒)
                    {
                        //移動前→移動後で、には移動前には空白を入れる
                        if ((koma2.駒情報A.Location) == (str.Location))
                        {
                            str.BackColor = color.空白色;
                            str.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                            str.Margin = new System.Windows.Forms.Padding(1);
                            str.Name = "空白" + ((50 + countZ).ToString());
                            str.Text = "□";
                            //str.Click += new System.EventHandler(this.将棋_Click);
                            str.Visible = true;
                        }
                        //移動前→移動後で、には移動後には移動する駒を入れる
                        if (((Point)((Label)sender).Location) == ((Point)str.Location))
                        {
                            MotigomaM_info m_Info = new MotigomaM_info();
                            switch (str.Name[0])
                            {
                                case '歩':
                                    komadai_Hu_Mikata.Text = Logic.komaSyutoku(komadai_Hu_Mikata.Text);
                                    komadai_Hu_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "歩";
                                    MotigomaM.味歩.Add(m_Info);
                                    break;
                                case '香':
                                    komadai_Kyou_Mikata.Text = Logic.komaSyutoku(komadai_Kyou_Mikata.Text);
                                    komadai_Kyou_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "香";
                                    MotigomaM.味香.Add(m_Info);
                                    break;
                                case '桂':
                                    komadai_Kei_Mikata.Text = Logic.komaSyutoku(komadai_Kei_Mikata.Text);
                                    komadai_Kei_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "桂";
                                    MotigomaM.味桂.Add(m_Info);
                                    break;
                                case '銀':
                                    komadai_Gin_Mikata.Text = Logic.komaSyutoku(komadai_Gin_Mikata.Text);
                                    komadai_Gin_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "銀";
                                    MotigomaM.味銀.Add(m_Info);
                                    break;
                                case '金':
                                    komadai_Kin_Mikata.Text = Logic.komaSyutoku(komadai_Kin_Mikata.Text);
                                    komadai_Kin_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "金";
                                    MotigomaM.味金.Add(m_Info);
                                    break;
                                case '角':
                                    komadai_Kaku_Mikata.Text = Logic.komaSyutoku(komadai_Kaku_Mikata.Text);
                                    komadai_Kaku_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "角";
                                    MotigomaM.味角.Add(m_Info);
                                    break;
                                case '飛':
                                    komadai_Hi_Mikata.Text = Logic.komaSyutoku(komadai_Hi_Mikata.Text);
                                    komadai_Hi_Mikata.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "飛";
                                    MotigomaM.味飛.Add(m_Info);
                                    break;

                                default:
                                    break;
                            }


                            str.BackColor = Koma.色B;
                            str.ForeColor = Koma.色A;
                            //str.Margin = (Padding)Koma.駒情報B.Margin;
                            if (((Point)str.Location).Y <= 71)
                            {
                                if (Koma.文字.IndexOf("飛") == 0)
                                {
                                    DialogResult result = MessageBox.Show("成りますか？",
                                    "質問",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                                    //何が選択されたか調べる
                                    if (result == DialogResult.Yes)
                                    {
                                        //「はい」が選択された時
                                        str.Text = "竜";
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                        //「いいえ」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                        //「キャンセル」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                }
                                else if (Koma.文字.IndexOf("角") == 0)
                                {
                                    DialogResult result = MessageBox.Show("成りますか？",
                                    "質問",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                                    //何が選択されたか調べる
                                    if (result == DialogResult.Yes)
                                    {
                                        //「はい」が選択された時
                                        str.Text = "馬";
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                        //「いいえ」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                        //「キャンセル」が選択された時
                                        str.Text = Koma.文字;
                                    }

                                }
                                else if ((Koma.文字.IndexOf("香") == 0) || (Koma.文字.IndexOf("桂") == 0)
                                    || (Koma.文字.IndexOf("銀") == 0) || (Koma.文字.IndexOf("歩") == 0))
                                {
                                    DialogResult result = MessageBox.Show("成りますか？",
                                    "質問",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                                    //何が選択されたか調べる
                                    if (result == DialogResult.Yes)
                                    {
                                        //「はい」が選択された時
                                        str.Text = "金";
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                        //「いいえ」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                        //「キャンセル」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                }
                                else
                                {
                                    str.Text = Koma.文字;
                                }
                            }
                            else
                            {
                                str.Text = Koma.文字;
                            }
                            str.Name = Koma.名前;
                            str.Visible = true;
                            //str.Padding = (Padding)Koma.駒情報B.Padding;
                            //str.Size = (Size)Koma.駒情報B.Size;
                            //str.Click += new System.EventHandler(this.将棋_Click);
                        }
                    }

                    FlagA = 2;
                    if (textname.textWirte.Count() >= count)
                    {
                        textBox.Text = textname.textWirte[count];
                    }

                    count++;
                    return;
                }
                #endregion

                //名前が敵か空白のとき時
                #region 敵選択
                if (FlagA == 2)
                {
                    //情報を渡すために使う
                    koma2.駒情報A = ((Label)sender);
                    Koma.文字 = (((Label)sender).Text);
                    //Koma.インデックス = (((Label)sender).TabIndex);
                    Koma.色A = (((Label)sender).ForeColor);
                    Koma.色B = (((Label)sender).BackColor);
                    Koma.名前 = (((Label)sender).Name);
                    if (((Label)sender).Name.IndexOf("空白") == 0 || (((Label)sender).Name.IndexOf("味") == 2))
                    {
                        return;
                    }

                    #region 押したら色変更
                    //押したラベルが黒
                    //空白はチョコレート
                    //それ以外のラベルが深桃色になる
                    foreach (Label str in Koma.駒)
                    {
                        if (str.Name == ((Label)sender).Name)
                        {
                            str.BackColor = color.変化後選択駒色;
                        }
                        else if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.変化後空白色;
                        }
                        else
                        {
                            str.BackColor = color.変化後無関係駒色;
                        }
                    }
                    #endregion

                    //歩の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("歩") == 0)
                    {
                        Logic2.hoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //香の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("香") == 0)
                    {
                        Logic2.kyoLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //桂の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("桂") == 0)
                    {
                        Logic2.keimaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //銀の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("銀") == 0)
                    {
                        Logic2.ginLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //金の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("金") == 0)
                    {
                        Logic2.kinLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //王の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("玉") == 0)
                    {
                        Logic2.gyokuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //飛車の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("飛") == 0)
                    {
                        Logic2.hisyaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //角の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("角") == 0)
                    {
                        Logic2.kakuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が竜の場合、竜の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("竜") == 0)
                    {
                        Logic2.ryuLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    //名前が馬の場合、馬の移動できる場所を色変換
                    if (((Label)sender).Text.IndexOf("馬") == 0)
                    {
                        Logic2.umaLogic(((Label)sender).Location.X, ((Label)sender).Location.Y);
                    }
                    FlagA = 3;
                    return;
                }
                #endregion

                #region 移動
                if (FlagA == 3)
                {
                    //白黒じゃないならreturn
                    if (((Label)sender).BackColor != color.移動可能場所色 && ((Label)sender).BackColor != color.変化後選択駒色)
                    {
                        return;
                    }
                    //移動させる駒なら
                    if (((Label)sender).BackColor == color.変化後選択駒色)
                    {
                        //色を元に戻して、FlagAに2を入れてreturn
                        foreach (Label str in Koma.駒)
                        {
                            if (str.Name.IndexOf("空白") == 0)
                            {
                                str.BackColor = color.空白色;
                            }
                            //それ以外の場合
                            else
                            {
                                str.BackColor = color.通常駒色;
                            }
                        }
                        FlagA = 2;
                        return;
                    }
                    foreach (Label str in Koma.駒)
                    {
                        //ラベルの色を初期化する
                        if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.空白色;
                        }
                        else
                        {
                            str.BackColor = color.通常駒色;
                        }
                    }
                    foreach (Label str in Koma.駒)
                    {
                        if ((koma2.駒情報A.Location) == (str.Location))
                        {
                            str.BackColor = color.空白色;
                            str.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                            str.Margin = new System.Windows.Forms.Padding(1);
                            str.Name = "空白" + ((50 + countZ).ToString());
                            str.Text = "□";
                            //str.Click += new System.EventHandler(this.将棋_Click);
                            str.Visible = true;
                        }
                        if (((Point)((Label)sender).Location) == ((Point)str.Location))
                        {
                            MotigomaM_info m_Info = new MotigomaM_info();
                            switch (str.Name[0])
                            {
                                case '歩':
                                    komadai_Hu_Teki.Text = Logic.komaSyutoku(komadai_Hu_Teki.Text);
                                    komadai_Hu_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "歩";
                                    MotigomaM.敵歩.Add(m_Info);
                                    break;
                                case '香':
                                    komadai_Kyou_Teki.Text = Logic.komaSyutoku(komadai_Kyou_Teki.Text);
                                    komadai_Kyou_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "香";
                                    MotigomaM.敵香.Add(m_Info);
                                    break;
                                case '桂':
                                    komadai_Kei_Teki.Text = Logic.komaSyutoku(komadai_Kei_Teki.Text);
                                    komadai_Kei_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "桂";
                                    MotigomaM.敵桂.Add(m_Info);
                                    break;

                                case '銀':
                                    komadai_Gin_Teki.Text = Logic.komaSyutoku(komadai_Gin_Teki.Text);
                                    komadai_Gin_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "銀";
                                    MotigomaM.敵銀.Add(m_Info);
                                    break;

                                case '金':
                                    komadai_Kin_Teki.Text = Logic.komaSyutoku(komadai_Kin_Teki.Text);
                                    komadai_Kin_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "金";
                                    MotigomaM.敵金.Add(m_Info);
                                    break;
                                case '角':
                                    komadai_Kaku_Teki.Text = Logic.komaSyutoku(komadai_Kaku_Teki.Text);
                                    komadai_Kaku_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "角";
                                    MotigomaM.敵角.Add(m_Info);
                                    break;
                                case '飛':
                                    komadai_Hi_Teki.Text = Logic.komaSyutoku(komadai_Hi_Teki.Text);
                                    komadai_Hi_Teki.BackColor = color.持ち駒変化色;

                                    m_Info.駒情報C = str;
                                    m_Info.位置 = (Point)str.Location;
                                    m_Info.色A = System.Drawing.SystemColors.ButtonHighlight;
                                    m_Info.色B = color.通常駒色;
                                    //m_Info.マージン = new System.Windows.Forms.Padding(5, 5, 0, 0);
                                    m_Info.名前 = str.Name;
                                    //m_Info.パディング = str.Padding;
                                    //m_Info.サイズ = 
                                    //m_Info.インデックス = str;
                                    m_Info.文字 = "飛";
                                    MotigomaM.敵飛.Add(m_Info);
                                    break;

                                default:
                                    break;
                            }


                            int a = ((Point)str.Location).Y;
                            str.BackColor = Koma.色B;
                            str.ForeColor = Koma.色A;
                            //str.Margin = (Padding)Koma.駒情報B.Margin;
                            if (((Point)str.Location).Y >= 179)
                            {
                                if (Koma.文字.IndexOf("飛") == 0)
                                {
                                    DialogResult result = MessageBox.Show("成りますか？",
                                    "質問",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                                    //何が選択されたか調べる
                                    if (result == DialogResult.Yes)
                                    {
                                        //「はい」が選択された時
                                        str.Text = "竜";
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                        //「いいえ」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                        //「キャンセル」が選択された時
                                        str.Text = Koma.文字;
                                    }

                                }
                                else if (Koma.文字.IndexOf("角") == 0)
                                {
                                    DialogResult result = MessageBox.Show("成りますか？",
                                    "質問",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                                    //何が選択されたか調べる
                                    if (result == DialogResult.Yes)
                                    {
                                        //「はい」が選択された時
                                        str.Text = "馬";
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                        //「いいえ」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                        //「キャンセル」が選択された時
                                        str.Text = Koma.文字;
                                    }

                                }
                                else if ((Koma.文字.IndexOf("香") == 0) || (Koma.文字.IndexOf("桂") == 0)
                                    || (Koma.文字.IndexOf("銀") == 0) || (Koma.文字.IndexOf("歩") == 0))
                                {
                                    DialogResult result = MessageBox.Show("成りますか？",
                                    "質問",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                                    //何が選択されたか調べる
                                    if (result == DialogResult.Yes)
                                    {
                                        //「はい」が選択された時
                                        str.Text = "金";
                                    }
                                    else if (result == DialogResult.No)
                                    {
                                        //「いいえ」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                    else if (result == DialogResult.Cancel)
                                    {
                                        //「キャンセル」が選択された時
                                        str.Text = Koma.文字;
                                    }
                                }
                                else
                                {
                                    str.Text = Koma.文字;
                                }
                            }
                            else
                            {
                                str.Text = Koma.文字;
                            }
                            str.Name = Koma.名前;
                            str.Visible = true;
                            //str.Padding = (Padding)Koma.駒情報B.Padding;
                            //str.Size = (Size)Koma.駒情報B.Size;
                            //str.Click += new System.EventHandler(this.将棋_Click);
                        }
                    }
                    FlagA = 0;
                    if (textname.textWirte.Count() >= count)
                    {
                        textBox.Text = textname.textWirte[count];
                    }
                    count++;
                    return;
                }
                #endregion

                //持ち駒　味方

                if (FlagA == 5)
                {
                    //色が変化していないならreturn(移動できる場所以外かつ移動させる駒以外)
                    if (((Label)sender).BackColor != color.移動可能場所色
                        && ((Label)sender).BackColor != color.変化後選択駒色)
                    {
                        return;
                    }
                    foreach (Label str in Koma.駒)
                    {
                        //ラベルの色を変化させる
                        //空白の場合
                        if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.空白色;
                        }
                        //それ以外の場合
                        else
                        {
                            str.BackColor = color.通常駒色;
                        }
                    }
                    foreach (Label str in Koma.駒)
                    {
                        //移動前→移動後で、には移動前には空白を入れる
                        if ((koma2.駒情報A.Location) == (str.Location))
                        {

                        }
                        //移動前→移動後で、には移動後には移動する駒を入れる
                        if (((Point)((Label)sender).Location) == ((Point)str.Location))
                        {
                            str.BackColor = Koma.色B;
                            str.ForeColor = Koma.色A;
                            //str.Margin = (Padding)Koma.駒情報B.Margin;
                            str.Text = Koma.文字;
                            str.Name = Koma.名前;
                            str.Visible = true;
                            //str.Padding = (Padding)Koma.駒情報B.Padding;
                            //str.Size = (Size)Koma.駒情報B.Size;
                            //str.Click += new System.EventHandler(this.将棋_Click);
                        }
                    }

                    FlagA = 2;
                    if (textname.textWirte.Count() >= count)
                    {
                        textBox.Text = textname.textWirte[count];
                    }
                    count++;
                    return;
                }
                if (FlagA == 6)
                {
                    //色が変化していないならreturn(移動できる場所以外かつ移動させる駒以外)
                    if (((Label)sender).BackColor != color.移動可能場所色
                        && ((Label)sender).BackColor != color.変化後選択駒色)
                    {
                        return;
                    }

                    foreach (Label str in Koma.駒)
                    {
                        //ラベルの色を変化させる
                        //空白の場合
                        if (str.Name.IndexOf("空白") == 0)
                        {
                            str.BackColor = color.空白色;
                        }
                        //それ以外の場合
                        else
                        {
                            str.BackColor = color.通常駒色;
                        }
                    }
                    foreach (Label str in Koma.駒)
                    {
                        //移動前→移動後で、には移動前には空白を入れる
                        if ((koma2.駒情報A.Location) == (str.Location))
                        {

                        }
                        //移動前→移動後で、には移動後には移動する駒を入れる
                        if (((Point)((Label)sender).Location) == ((Point)str.Location))
                        {
                            str.BackColor = Koma.色B;
                            str.ForeColor = Koma.色A;
                            //str.Margin = (Padding)Koma.駒情報B.Margin;
                            str.Text = Koma.文字;
                            str.Name = Koma.名前;
                            str.Visible = true;
                            //str.Padding = (Padding)Koma.駒情報B.Padding;
                            //str.Size = (Size)Koma.駒情報B.Size;
                            //str.Click += new System.EventHandler(this.将棋_Click);
                        }
                    }
                    FlagA = 0;
                    if (textname.textWirte.Count() >= count)
                    {
                        textBox.Text = textname.textWirte[count];
                    }
                    count++;
                    return;
                }
            }
            catch { }
            finally { countZ++; }
        }
    }
}
