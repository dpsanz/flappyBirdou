using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
    private int pontos;
    private Label textoPontuacao;

    public void adicionarPontos()
    {
        this.pontos++;
        this.textoPontuacao.texto = this.pontos.ToString();
    }
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
    }
}






