using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Tile tilePrefab;

    [SerializeField] private Click clickPoint;
    
    void Start() {
        GenerateGrid();
    }

    void GenerateGrid() {
        for (int x = 0; x < width; x++) {
            for(int y = 0; y < height; y++ ) {
                float offsetX = x + 0.5f;
                float offsetY = y + 0.5f;

                var spawnedTile = Instantiate(
                    tilePrefab, 
                    new Vector3(offsetX,offsetY), 
                    Quaternion.identity
                );
                spawnedTile.name = $"Tile {x} {y}";

                
            }
        }

        for (int x = 0; x < width + 1; x++) {
            for(int y = 0; y < height + 1; y++ ) {
                var clickablePoint = Instantiate(
                                    clickPoint,
                                    new Vector3(x,y,-1),
                                    Quaternion.identity
                );  
                clickablePoint.name = $"Click {x} {y}";
            }
        }

         
    }
}
