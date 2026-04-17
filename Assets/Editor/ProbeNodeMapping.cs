using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public static class ProbeNodeMapping
{
    public static void Execute()
    {
        // Walks all "Node(X,Y)" objects under Cover Ground Layer, parses the
        // two numbers out of the name, and prints a few rows plus computes
        // the simplest linear fit  world = A * name + B.
        var root = GameObject.Find("yunzhongzhen1_a/Persistent Layer/Cover Ground Layer");
        if (root == null)
        {
            Debug.LogError("[ProbeNode] Cover Ground Layer not found");
            return;
        }

        var re = new Regex(@"Node\((\d+),(\d+)\)");
        int count = 0, printed = 0;
        float minNX = float.MaxValue, maxNX = float.MinValue;
        float minNY = float.MaxValue, maxNY = float.MinValue;
        float minWX = float.MaxValue, maxWX = float.MinValue;
        float minWY = float.MaxValue, maxWY = float.MinValue;
        // arg-min/max of nameX, etc., so we can solve linear mapping:
        float nxMinWx = 0, nxMaxWx = 0, nxMinNX = 0, nxMaxNX = 0;
        float nyMinWy = 0, nyMaxWy = 0, nyMinNY = 0, nyMaxNY = 0;

        foreach (Transform t in root.transform)
        {
            var m = re.Match(t.name);
            if (!m.Success) continue;
            float nx = float.Parse(m.Groups[1].Value);
            float ny = float.Parse(m.Groups[2].Value);
            var p = t.position;
            count++;
            if (printed < 8)
            {
                Debug.Log($"[ProbeNode] {t.name}  world=({p.x:F3}, {p.y:F3})");
                printed++;
            }
            if (nx < minNX) { minNX = nx; nxMinWx = p.x; }
            if (nx > maxNX) { maxNX = nx; nxMaxWx = p.x; }
            if (ny < minNY) { minNY = ny; nyMinWy = p.y; }
            if (ny > maxNY) { maxNY = ny; nyMaxWy = p.y; }
            if (p.x < minWX) minWX = p.x;
            if (p.x > maxWX) maxWX = p.x;
            if (p.y < minWY) minWY = p.y;
            if (p.y > maxWY) maxWY = p.y;
        }

        Debug.Log($"[ProbeNode] parsed {count} nodes");
        Debug.Log($"[ProbeNode] nameX span [{minNX}, {maxNX}]  dx={maxNX - minNX}");
        Debug.Log($"[ProbeNode] nameY span [{minNY}, {maxNY}]  dy={maxNY - minNY}");
        Debug.Log($"[ProbeNode] worldX span [{minWX:F3}, {maxWX:F3}]");
        Debug.Log($"[ProbeNode] worldY span [{minWY:F3}, {maxWY:F3}]");

        // Linear fit: world = a*name + b   (x and y treated independently)
        // Use endpoints:
        //   minWX := fit(minNX) -> but min worldX may not occur at min nameX if axes rotated.
        // For a cleaner fit, regress on ALL points.
        float sumNX = 0, sumWX = 0, sumNXNX = 0, sumNXWX = 0;
        float sumNY = 0, sumWY = 0, sumNYNY = 0, sumNYWY = 0;
        int n = 0;
        foreach (Transform t in root.transform)
        {
            var m = re.Match(t.name);
            if (!m.Success) continue;
            float nx = float.Parse(m.Groups[1].Value);
            float ny = float.Parse(m.Groups[2].Value);
            var p = t.position;
            sumNX += nx; sumWX += p.x; sumNXNX += nx * nx; sumNXWX += nx * p.x;
            sumNY += ny; sumWY += p.y; sumNYNY += ny * ny; sumNYWY += ny * p.y;
            n++;
        }
        if (n >= 2)
        {
            float meanNX = sumNX / n, meanWX = sumWX / n;
            float meanNY = sumNY / n, meanWY = sumWY / n;
            float ax = (sumNXWX - n * meanNX * meanWX) / (sumNXNX - n * meanNX * meanNX);
            float bx = meanWX - ax * meanNX;
            float ay = (sumNYWY - n * meanNY * meanWY) / (sumNYNY - n * meanNY * meanNY);
            float by = meanWY - ay * meanNY;
            Debug.Log($"[ProbeNode] X fit:  worldX = {ax:F6} * nameX + {bx:F3}");
            Debug.Log($"[ProbeNode] Y fit:  worldY = {ay:F6} * nameY + {by:F3}");
            Debug.Log($"[ProbeNode]   => 1 nameX unit = {ax:F6} world   (cell size x)");
            Debug.Log($"[ProbeNode]   => 1 nameY unit = {ay:F6} world   (cell size y)");
            // Name ranges derive cell extents
            Debug.Log($"[ProbeNode]   nameX range [{minNX:F0}, {maxNX:F0}] => world range [{ax * minNX + bx:F3}, {ax * maxNX + bx:F3}]");
            Debug.Log($"[ProbeNode]   nameY range [{minNY:F0}, {maxNY:F0}] => world range [{ay * minNY + by:F3}, {ay * maxNY + by:F3}]");
        }

        // Also: does the map have a 'Runtime Layer/Buildin Layer' with SpriteRenderers?
        // Probe the overall Ground TileMap bounds for camera/calibration reference.
        var ground = GameObject.Find("yunzhongzhen1_a/Persistent Layer/Ground Layer/Ground TileMap");
        if (ground != null)
        {
            var gs = ground.GetComponent<UnityEngine.Tilemaps.Tilemap>();
            if (gs != null)
            {
                var b = gs.localBounds;
                Debug.Log($"[ProbeNode] Ground TileMap localBounds min={b.min} max={b.max} size={b.size}");
                var wb = gs.GetComponent<UnityEngine.Tilemaps.TilemapRenderer>()?.bounds;
                if (wb.HasValue)
                    Debug.Log($"[ProbeNode] Ground TileMap worldBounds {wb.Value.min} .. {wb.Value.max}");
            }
        }
    }
}
