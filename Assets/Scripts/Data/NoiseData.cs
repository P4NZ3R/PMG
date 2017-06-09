using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class NoiseData : UpdatableData {

    public Noise.NormalizeMode normalizeMode;

    [Range(0.01f, 100.00f)]
    public float noiseScale;
    [Range(1, 10)]
    public int octaves=4;
    [Range(0.00f, 1.00f)]
    public float persistance=2f;
    [Range(0.0f, 10.0f)]
    public float lacunarity=0.5f;

    public int seed;
    public Vector2 offset;

    protected override void OnValidate()
    {
        if (lacunarity < 1)
            lacunarity = 1;
        if (octaves < 0)
            octaves = 0;

        base.OnValidate();
    }
}
