using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridCenter : MonoBehaviour
{
    public int gridSize = 50;
    public int gridInterval = 10;
    public int colCount;
    public int rowCount;
    public GameObject gridModel;
    void Start()
    {
        for (int i = 0; i < colCount; i++)
        {
            for (int j = 0; j < rowCount; j++)
            {
                GameObject grid = Instantiate(gridModel) as GameObject;
                grid.transform.SetParent(this.transform);
                var x = (j - rowCount / 2) * (this.gridSize + this.gridInterval);
                var y = (i - rowCount / 2) * (this.gridSize + this.gridInterval);
                grid.transform.localPosition = new Vector3(x, y, 0);
            }
        }
    }

    void Update()
    {

    }
}
