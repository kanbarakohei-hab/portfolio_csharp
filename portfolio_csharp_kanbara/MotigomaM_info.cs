using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portfolio_csharp_kanbara
{
    /*駒情報*/
    class MotigomaM_info
    {
        public Label 駒情報C { get; set; }
        public Point 位置 { get; set; }
        public Color 色A { get; set; }
        public Color 色B { get; set; }
        public Label マージン { get; set; }
        public string 名前 { get; set; }
        public Label パディング { get; set; }
        public Label サイズ { get; set; }
        public int インデックス { get; set; }
        public string 文字 { get; set; }
    }
}
