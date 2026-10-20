using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text RedText;
    public Text BlueText;
    public Text GreenText;

    private int redCount = 0;
    private int blueCount = 0;
    private int greenCount = 0;

    private void Start()
    {
        RedText.text = "Red: 0";
        BlueText.text = "Blue: 0";
        GreenText.text = "Green: 0";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red"))
        {
            redCount++;
            RedText.text = "Red: " + redCount;
        }
        else if (other.gameObject.CompareTag("Blue"))
        {
            blueCount++;
            BlueText.text = "Blue: " + blueCount;
        }
        else if (other.gameObject.CompareTag("Green"))
        {
            greenCount++;
            GreenText.text = "Green: " + greenCount;
        }
    }
}