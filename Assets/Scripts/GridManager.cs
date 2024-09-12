using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int rows = 6;
    public int columns = 6;
    public float tileSize = 1.0f;

    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        GameObject gridTile = new GameObject();
        gridTile.transform.position = new Vector3(0, 0, 0);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                GameObject tile = Instantiate(gridTile, transform);
                float posX = col * tileSize;
                float posY = row * tileSize;
                tile.transform.position = new Vector3(posX, posY, 0);
                tile.name = "Tile_" + row + "_" + col;
            }
        }
        Destroy(gridTile); // Remove the template object
    }
}
