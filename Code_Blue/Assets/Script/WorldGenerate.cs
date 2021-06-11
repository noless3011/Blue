using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerate : MonoBehaviour
{
    public int width = 256;
    public int height = 256;
    public GameObject[] asteroid ;
    void Start() {
        
    }
    Texture2D GenerateNoise(){
        Texture2D noise = new Texture2D(width, height);
        for(int x = 0; x < width; x ++){
            for(int y = 0; y < height; y++){
                noise.SetPixel(x, y, NoiseColor(x, y));
            }
        }
        return noise;
    }
    Color NoiseColor(int x, int y){
        float xCoord = (float)x / width;
        float yCoord = (float)y / height; 
        float alpha = Mathf.PerlinNoise(xCoord, yCoord);
        Color noiseColor = new Color(alpha, alpha, alpha);
        return noiseColor;
    }

}
