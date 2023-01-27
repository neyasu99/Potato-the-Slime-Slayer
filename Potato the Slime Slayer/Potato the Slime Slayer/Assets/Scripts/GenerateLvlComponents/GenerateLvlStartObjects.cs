using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerateLvlStartObjects : MonoBehaviour
{
    public GameObject platform;
    public GameObject platformJoke;
    public GameObject NPC;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        platform.layer = LayerMask.NameToLayer("Foreground");
        platformJoke.layer = LayerMask.NameToLayer("Foreground");

        if (scene.name == "FirstLvl")
            Instantiate(platform, new Vector3(-1.8f, 1.5f, -1.82f), Quaternion.identity);
        else if(scene.name == "Lvl")
        {
            float tooHighPlatform = Random.Range(0f, 1f);
            if(tooHighPlatform < 1)
                Instantiate(platform, new Vector3(Random.Range(-1.8f, 1.8f), 1.5f, -1.82f), Quaternion.identity);
            else
                Instantiate(platformJoke, new Vector3(Random.Range(-1.8f, 1.8f), Random.Range(2, 2.3f), -1.82f), Quaternion.identity);
        }
        //NPC nie zawsze w sklepie
        //if(scene.name == "NPC")
        //{
        //    Instantiate(NPC, new Vector3(-1.8f, 1.5f, -1.82f), Quaternion.identity);
        //}
    }
}
