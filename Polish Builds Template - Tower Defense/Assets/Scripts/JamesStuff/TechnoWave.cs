using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class TechnoWave : MonoBehaviour
{
    public VolumeProfile profile;
    // Start is called before the first frame update
    void Start()
    {
        Volume volume = gameObject.GetComponent<Volume>();
        profile = volume.profile;
    }

    // Update is called once per frame
    void Update()
    {
        ColorAdjustments adjustments;
        if (profile.TryGet<ColorAdjustments>(out adjustments))
        {
            adjustments.hueShift.value += Time.deltaTime * 10;
        }
    }
}
