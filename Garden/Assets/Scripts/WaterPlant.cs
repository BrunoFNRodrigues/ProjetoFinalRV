using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlant : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float limiteRotacao = 45f;

    // Update is called once per frame
    void Update()
    {
        float rotacaoY = transform.rotation.eulerAngles.y;
        bool ativaEmissor = Mathf.Abs(rotacaoY) <= limiteRotacao;
        var emission = particleSystem.emission;
        emission.enabled = ativaEmissor;
    }
}
