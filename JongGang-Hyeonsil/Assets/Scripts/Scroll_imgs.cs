using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scroll_imgs : MonoBehaviour
{
    public RawImage Img;
    public GameObject Scroll;
    public GameObject Clone_img;
    string[] FileName;

    // Start is called before the first frame update
    void Start()
    {
        FileName = Directory.GetFiles("/storage/emulated/0/DCIM/Imgs/", "*.jpg");
        for (int i = 0; i < FileName.Length; i++)
        {
            cp(i);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }


    void cp(int a)
    {
        string myFolderLocation = "/storage/emulated/0/DCIM/Imgs/";
        DirectoryInfo directory = new DirectoryInfo(myFolderLocation);
        FileInfo[] file = directory.GetFiles();
        string myFilename = file[a].Name;
        string myScreenshotLocation = myFolderLocation + myFilename;

        byte[] pt = File.ReadAllBytes(myScreenshotLocation);
        Texture2D texture = new Texture2D(Screen.width, Screen.height);
        texture.LoadImage(pt);
        Img.texture = texture;

        GameObject Clone_scroll = Instantiate(Clone_img);
        Clone_scroll.transform.SetParent(Scroll.transform, false);
    }
}
