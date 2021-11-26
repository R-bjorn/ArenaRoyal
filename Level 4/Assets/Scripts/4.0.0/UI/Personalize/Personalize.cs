using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Personalize : MonoBehaviour
{

    public Renderer groundPrefab;
    public Renderer ground;
    public Material concrete;
    public Material grass;
    public Material gravel;
    public Material sand;

    // public Material currentMaterial;

    // private void Start()
    // {
    //     currentMaterial = ground.GetComponent<Material>();
    // }

    public void ApplyConcrete()
    {
        ground.sharedMaterial = concrete;
        groundPrefab.sharedMaterial = concrete;
    }

    public void ApplyGrass()
    {
        ground.sharedMaterial = grass;
        groundPrefab.sharedMaterial = grass;
    }

    public void ApplyGravel()
    {
        ground.sharedMaterial = gravel;
        groundPrefab.sharedMaterial = gravel;
    }

    public void ApplySand()
    {
        ground.sharedMaterial = sand;
        groundPrefab.sharedMaterial = sand;
    }

    public void Back()
    {
        Debug.Log("Back");
        SceneManager.LoadScene("Scenes/Menu");
    }
}
