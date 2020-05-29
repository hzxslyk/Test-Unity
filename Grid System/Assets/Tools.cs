/****************************************************
    File Name:Tools.cs
    Function:Nothing
*****************************************************/

using UnityEngine;

namespace LYKFrameWork
{
    public class Tools
    {
        public static void Set3DTextInWorld(Vector3 pos,int fontSize,TextAnchor textAnchor,string text)
        {
            GameObject go=new GameObject("TXT");
            TextMesh tm=go.AddComponent<TextMesh>();
            tm.transform.position = pos;
            tm.fontSize = fontSize;
            tm.anchor = textAnchor;
            tm.text = text;
        }
    }
}

