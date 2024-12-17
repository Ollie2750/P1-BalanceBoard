using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLvl8Script : MonoBehaviour
{ 
public void LoadLevels()
{
    SceneManager.LoadScene("LevelSelector");
}
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void LoadBiome1()
    {
        SceneManager.LoadScene("Biome 1");
    }
    public void LoadBiome2()
    {
        SceneManager.LoadScene("Biome 2");
    }
    public void LoadBiome3()
    {
        SceneManager.LoadScene("Biome 3");
    }
    public void LoadLavaLevel()
    {
        SceneManager.LoadScene("Lava Level");
    }

    }