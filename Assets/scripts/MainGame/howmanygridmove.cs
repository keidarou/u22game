using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howmanygridmove : MonoBehaviour
{

    //このスクリプトはあとで他のスクリプトの中に関数だけをいれます。仮です
    //内容としては、玉が動き終わって、スマホの方向、位置が与えられたとき、どの方向に何マス動くかというのを返します。
    //返すといっても変数の中に格納しておくだけです。返り値はないです。
    int[,] map = new int[50, 50];//これは本来のマップです。
    int down, up;//downは重力に従って落ちるボールが何マス落ちるか、upはその逆

    int Selectrange(int x, int y, int genzaix, int genzaiy)//このx,yはx方向にどれだけ、y方向も同様なので、通常x,y=1,0・0,1・-1,0・0,-1
    {
        int count = 0;
        while (true)
        {
            if (map[genzaix + x, genzaiy + y] == 1)
            {
                return count;
            }
            genzaix += x; genzaiy += y; count++;
        }
    }

    void selectDirectionandrange(int Direction, int x, int y)//このx,yはgenzaix,genzaiyの意味です。すみません
    {
        //方向を把握していないので、適当に0を上、1を右、2を下、3を左にします
        if (Direction == 0)//上向きの重力
        {
            up = Selectrange(0, -1, x, y);
            down = Selectrange(0, 1, x, y);
        }
        else if (Direction == 1)//右
        {
            up = Selectrange(-1, 0, x, y);
            down = Selectrange(1, 0, x, y);
        }
        else if (Direction == 2)//下
        {
            up = Selectrange(0, 1, x, y);
            down = Selectrange(0, -1, x, y);
        }
        else//左
        {
            up = Selectrange(1, 0, x, y);
            down = Selectrange(-1, 0, x, y);
        }
        //これで代入おーわり。あとはこれに従っていどうして
    }
}
