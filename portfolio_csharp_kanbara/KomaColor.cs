using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portfolio_csharp_kanbara
{
    /*色情報クラス*/
    public class KomaColor
    {
        // ベルランゴー / Berlingot
        public Color 通常駒色 = Color.FromArgb(189, 123, 68);

        //雄黄 / ション・ホワン
        public Color 空白色 = Color.FromArgb(255, 168, 34);

        //向日葵色 / ひまわりいろ / Himawariiro
        public Color 移動可能場所色 = Color.FromArgb(237, 185, 42);

        //マンダリンオレンジ / Mandarin Orange
        public Color 変化後選択駒色 = Color.FromArgb(218, 148, 54);

        //メローネ / Melone
        public Color 変化後空白色 = Color.FromArgb(228, 144, 104);

        //柿子色 / シー・ツ・スー
        public Color 変化後無関係駒色 = Color.FromArgb(203, 102, 50);

        //ジャッロ・マイオリカ / Giallo Maiolica	
        public Color 持ち駒色 = Color.Transparent; //Color.FromArgb(244, 215, 50);

        //黄赤 / きあか / Kiaka	
        public Color 持ち駒変化色 = Color.FromArgb(140, 30, 31);

        //マラカイトグリーン / Malachite Green
        public Color 持ち駒文字色 = Color.FromArgb(70, 125, 81);

        //黒紅梅 / くろこうばい / Kurokoubai
        public Color 持ち駒を置く台の色 = Color.FromArgb(59, 20, 24);

        //エムロード / Emeraude
        public Color 背景色 = Color.FromArgb(254, 254, 113);
    }
}
