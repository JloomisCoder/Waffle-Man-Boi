using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSpawn : MonoBehaviour
{
    public Texture2D sourceImage;
    public GameObject bgTile;
    int rows, cols;
    Vector3 startPosition, shift;
    public GameObject[,] tiles;

    void Start()
    {
        rows = 300;
        cols = 300;
        tiles = new GameObject[rows, cols];
        startPosition = new Vector3(0.0f, 0.0f, 0.0f);
        shift = new Vector3(0.19f, 0.19f, 0.0f);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                float pX = (float)j / (float)cols;
                float pY = (float)i / (float)rows;
                Color pixelColor = sourceImage.GetPixelBilinear(pX, pY);
                GameObject newTile = GameObject.Instantiate(bgTile);
                newTile.name = "tile." + i + "." + j;
                newTile.transform.position = startPosition;
                newTile.transform.position += new Vector3(shift.x * j, shift.y * i, 0.0f);
                SpriteRenderer newTileSprite = newTile.GetComponent<SpriteRenderer>();
                newTileSprite.color = pixelColor;
                tiles[i, j] = newTile;
            }
        }
    }


    /*int textureWidth;
    int textureHeight;
    float polyRadius;
    float[] polyCenter;
    public int sides;

	// Use this for initialization
	void Start ()
    {
        textureWidth = 128;
        textureHeight = 128;
        polyCenter = new float[] { (float)textureHeight / 2.0f, (float)textureWidth / 2.0f };
        polyRadius = (float)(textureWidth < textureHeight ? textureWidth : textureHeight);
        generateMesh();
	}
	
    public void generateMesh()
    {
        Vector3[] verts = new Vector3[sides];
        float deltaAngle = (2.0f * Mathf.PI) / ((float)sides);
        for(int i = 0; i < sides; i++)
        {
            verts[i] = new Vector3(Mathf.Cos(deltaAngle * i), Mathf.Sin(deltaAngle * i), 0.0f);
        }

        float[,] texture = new float[textureHeight, textureWidth];
        for (int i = 0; i < textureHeight; i++)
        {
            for(int j = 0; j < textureWidth; j++)
            {
                Vector2 pixelDelta = new Vector2((float)i - polyCenter[0], (float)j - polyCenter[1]);
                if (pixelDelta.magnitude <= polyRadius)
            }
        }
    }
    */



	


}
