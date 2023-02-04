using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] Level1Images; // icons array
    public Sprite[] Level2Images; // icons array
    public Sprite[] Level3Images; // icons array
    public Sprite[] Level4Images; // icons array
    public Sprite[] Level5Images; // icons array
    public Sprite[] FinalImages; // icons array

    // Start is called before the first frame update
    void Start()
    {
        LoadIcons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //populate all of the icon arrays
    void LoadIcons()
    {
        //level 1 icons
        object[] loadedIcons = Resources.LoadAll("level-1", typeof(Sprite));
        Level1Images = new Sprite[loadedIcons.Length];
        
        for (int x = 0; x < loadedIcons.Length; x++)
        {
            Level1Images[x] = (Sprite)loadedIcons[x];
        }

        //level 2 icons
        loadedIcons = Resources.LoadAll("level-2", typeof(Sprite));
        Level2Images = new Sprite[loadedIcons.Length];

        for (int x = 0; x < loadedIcons.Length; x++)
        {
            Level2Images[x] = (Sprite)loadedIcons[x];
        }

        //level 3 icons
        loadedIcons = Resources.LoadAll("level-3", typeof(Sprite));
        Level3Images = new Sprite[loadedIcons.Length];

        for (int x = 0; x < loadedIcons.Length; x++)
        {
            Level3Images[x] = (Sprite)loadedIcons[x];
        }

        //level 4 icons
        loadedIcons = Resources.LoadAll("level-4", typeof(Sprite));
        Level4Images = new Sprite[loadedIcons.Length];

        for (int x = 0; x < loadedIcons.Length; x++)
        {
            Level4Images[x] = (Sprite)loadedIcons[x];
        }

        //level 5 icons
        loadedIcons = Resources.LoadAll("level-5", typeof(Sprite));
        Level5Images = new Sprite[loadedIcons.Length];

        for (int x = 0; x < loadedIcons.Length; x++)
        {
            Level5Images[x] = (Sprite)loadedIcons[x];
        }

        //final icons
        loadedIcons = Resources.LoadAll("Final-Image", typeof(Sprite));
        FinalImages = new Sprite[loadedIcons.Length];

        for (int x = 0; x < loadedIcons.Length; x++)
        {
            FinalImages[x] = (Sprite)loadedIcons[x];
        }
    }
}