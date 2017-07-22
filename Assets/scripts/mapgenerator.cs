using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapgenerator : MonoBehaviour
{
    int width = 8;//heightも同じなのでメモリ節約
    int[,] map=new int[50,50];
    public GameObject tate,yoko;
    public float kiteix,kiteiy, haba,z;//規定はマップの左端のx座標またはy座標版、habaは、一ますごとの間隔
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            map[0,i] = 1;
            map[i,0] = 1;
        }
        int hairetusize = width * 2 - 1;
        //まずは横
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (map[i, j] == 1 && map[i + 1, j]==1) {
                    GameObject instanttate = (GameObject)Instantiate(tate);
                    instanttate.transform.position = new Vector3(kiteix+haba*j,kiteiy+haba*i,z);
                }
            }
        }
        //次は縦
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < width; i++)
            {
                if (map[i, j] == 1 && map[i + 1, j] == 1)
                {
                    GameObject instanttate = (GameObject)Instantiate(yoko);
                    instanttate.transform.position = new Vector3(kiteix + haba * i, kiteiy + haba * j, z);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
