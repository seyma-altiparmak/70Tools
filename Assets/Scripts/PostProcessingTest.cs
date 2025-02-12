using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Post-Processing libraries:
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingTest : MonoBehaviour
{
    void Start()
    {
        PostProcessVolume volume = GetComponent<PostProcessVolume>();
        if (volume.profile.TryGetSettings<DepthOfField>(out var dof))
        {
            dof.focalLength.value = 10f;
        }
        if (volume.profile.TryGetSettings<Bloom>(out var bloom))
        {
            bloom.color.value = Color.red;
        }
        if (volume.profile.TryGetSettings<MotionBlur>(out var motionBlur))
        {
            motionBlur.shutterAngle.value = 180f;
        }
        //if (!volume.profile.TryGetSettings<Fog>(out var fog))
    }
}
