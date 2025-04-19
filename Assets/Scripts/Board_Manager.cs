using UnityEngine;
using UnityEngine.Tilemaps;

public class Board_Manager : MonoBehaviour
{
    private Tilemap m_Tilemap;

    public int Width;
    public int Height;
    public Tile[] GroundTiles;

    // Start is called before the first frame update
    void Start()
    {
        m_Tilemap = GetComponentInChildren<Tilemap>();

        for (int y = 0; y < Height; ++y)
        {
            for (int x = 0; x < Width; ++x)
            {
                int tileNumber = Random.Range(0, GroundTiles.Length);
                m_Tilemap.SetTile(new Vector3Int(x >= Width / 2 ? Width / 2 - x - 1: x, y >= Height / 2 ? Height / 2 - y - 1: y, 0), GroundTiles[tileNumber]);
            }
        }
    }
}
