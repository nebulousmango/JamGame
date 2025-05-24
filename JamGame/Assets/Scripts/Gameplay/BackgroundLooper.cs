using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform[] backgroundTiles;
    private float tileWidth;

    void Start()
    {
        // Get all child tiles
        int childCount = transform.childCount;
        backgroundTiles = new Transform[childCount];

        for (int i = 0; i < childCount; i++)
        {
            backgroundTiles[i] = transform.GetChild(i);
        }

        // Assumes all tiles are same width
        tileWidth = backgroundTiles[0].GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        foreach (Transform tile in backgroundTiles)
        {
            tile.Translate(Vector2.left * speed * Time.deltaTime);

            // If tile goes off-screen to the left, move it to the rightmost position
            if (tile.position.x < -tileWidth)
            {
                // Find the rightmost tile
                float maxX = float.MinValue;
                foreach (Transform t in backgroundTiles)
                {
                    if (t.position.x > maxX)
                        maxX = t.position.x;
                }

                // Move this tile to the right of the rightmost tile
                tile.position = new Vector2(maxX + tileWidth, tile.position.y);
            }
        }
    }
}
