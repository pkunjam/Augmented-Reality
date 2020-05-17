using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoloController : MonoBehaviour {

    public bool effectOn = false;

    public Color HologramColor = Color.cyan;
    [Range(0f,1f)]
    public float HologramAlpha = 0.5f;
    [Range(0f, 1f)]
    public float HologramSpeed = 0.3f;
    [Range(0f, 1f)]
    public float HologramNoise = 0.2f;
    [Range(0.1f, 10f)]
    public float LineSeparation = 1f;
    [Range(1f, 30f)]
    public float LineThickness = 2f;
    [Range(0.1f, 10f)]
    public float LineAlpha = 1f;
    [Range(0f, 180f)]
    public float LineRotation = 0f;

    private List<Shader> originalObjetShaders;
    private Shader holoShader = null;

    private Color _HologramColor=Color.black;
    private float _HologramAlpha = 0f;
    private float _HologramSpeed = 0f;
    private float _HologramNoise = 0f;
    private float _LineSeparation = 0f;
    private float _LineThickness = 0f;
    private float _LineAlpha = 0f;
    private float _LineRotation = 0f;

    private bool holoOn = false;

    // Use this for initialization
    void Awake () {
        holoShader = Shader.Find("3y3net/HoloShader");

        _HologramColor = HologramColor;
        _HologramAlpha = HologramAlpha;
        _HologramSpeed = HologramSpeed;
        _HologramNoise = HologramNoise;
        _LineSeparation = LineSeparation;
        _LineThickness = LineThickness;
        _LineAlpha = LineAlpha;
        _LineRotation = LineRotation;

        if (holoShader == null)
            Debug.LogError("HoloShader not found!");
        else
        {
            if (effectOn)
                ShowHologram();
        }
        Debug.Log("Start");
    }
	
    public void ShowHologram()
    {
        Debug.Log("ShowHologram");
        effectOn =holoOn = true;
        originalObjetShaders = new List<Shader>();
        foreach (Renderer singleRenderer in GetComponentsInChildren<Renderer>())
            foreach (Material singleMaterial in singleRenderer.materials)
            {
                originalObjetShaders.Add(singleMaterial.shader);
                singleMaterial.shader = holoShader;
                SetAllMaterialProperties(singleMaterial);
            }
    }

    public void HideHologram()
    {
        effectOn=holoOn = false;
        int i = 0;
        foreach (Renderer singleRenderer in GetComponentsInChildren<Renderer>())
            foreach (Material singleMaterial in singleRenderer.materials)
            {
                singleMaterial.shader = originalObjetShaders[i++];
            }
    }

    void Update()
    {
        if(!effectOn && holoOn)
        {
            HideHologram();
        }

        if (effectOn && !holoOn)
        {
            ShowHologram();
        }

        if (!holoOn)
            return;
        if( _HologramColor != HologramColor || _HologramAlpha != HologramAlpha ||
            _HologramSpeed != HologramSpeed || _HologramNoise != HologramNoise ||
            _LineSeparation != LineSeparation || _LineThickness != LineThickness ||
            _LineAlpha != LineAlpha || _LineRotation != LineRotation)
        {
            foreach (Renderer singleRenderer in GetComponentsInChildren<Renderer>())
                foreach (Material singleMaterial in singleRenderer.materials)
                {
                    SetAllMaterialProperties(singleMaterial);
                }
        }
    }

    private void SetAllMaterialProperties(Material mat)
    {
        mat.SetColor("_HoloColor", HologramColor);
        mat.SetFloat("_HoloAlpha", HologramAlpha);
        mat.SetFloat("_HoloSpeed", HologramSpeed);
        mat.SetFloat("_HoloNoise", HologramNoise);
        mat.SetFloat("_HoloLineSeparation", LineSeparation);
        mat.SetFloat("_HoloLineThickness", LineThickness);
        mat.SetFloat("_HoloLineAlpha", LineAlpha);
        mat.SetFloat("_HoloLineRotation", LineRotation);

        _HologramColor = HologramColor;
        _HologramAlpha = HologramAlpha;
        _HologramSpeed = HologramSpeed;
        _HologramNoise = HologramNoise;
        _LineSeparation = LineSeparation;
        _LineThickness = LineThickness;
        _LineAlpha = LineAlpha;
        _LineRotation = LineRotation;
    }

}
