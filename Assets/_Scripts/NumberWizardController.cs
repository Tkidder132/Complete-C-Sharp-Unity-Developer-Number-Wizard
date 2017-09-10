using UnityEngine;

public class NumberWizardController : MonoBehaviour
{
    int min, max, guess;
	// Use this for initialization
	void Start ()
    {
        min = 1;
        max = 1001;
        guess = 500;

        print("Welcome to Number Wizard!");
        print("Pick a number in your head, but don't tell me!");
        
        print("The lowest number you can choose is: " + min);
        print("The highest number you can pick is : " + max);

        print("Is your number higher or lower than 500?");
        print("Up = higher, down = lower, return = equal.");
	}

	// Update is called once per frame
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            guess = (max + min) / 2;
            print("higher or lower than: " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            max = guess;
            guess = (max + min) / 2;
            print("higher or lower than: " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        }
    }
}