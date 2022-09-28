using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static System.Activator;

public class TextPrinter: MonoBehaviour
{

    public GameObject g;
    public Font font;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();



        /*
        TextGenerationSettings settings = new TextGenerationSettings();
        settings.textAnchor = TextAnchor.MiddleCenter;
        settings.color = Color.red;
        settings.generationExtents = new Vector2(500.0F, 200.0F);
        settings.pivot = Vector2.zero;
        settings.richText = true;
        settings.font = font;
        settings.fontSize = 32;
        settings.fontStyle = FontStyle.Normal;
        settings.verticalOverflow = VerticalWrapMode.Overflow;
        TextGenerator generator = new TextGenerator();

        generator.Populate("Test string", settings);
        Debug.Log("Verts generated: " + generator.vertexCount + " verts");

    */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
