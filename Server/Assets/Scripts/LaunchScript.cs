using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Backend.Filters;
using System;

public class LaunchScript : MonoBehaviour {

    public void Start()
    {
        Debug.Log("Start");
        setObjects();
        filterLength = (int)sliderLength.value;
        filterParameter = sliderParameter.value;
    }

	public void StartScene()
    {
        Debug.Log("StartScene");

        DontDestroyOnLoad(this);

        Application.LoadLevel("MainScene");
    }

    public void QuitAll()
    {
        Debug.Log("QuitAll");

        Application.Quit();
    }

    public void OnSliderLengthChanged()
    {
        filterLength = (int)sliderLength.value;
        textFilterLength.text = filterLength.ToString();
        Debug.Log(filterLength.ToString());
    }

    public void OnSliderParameterChanged()
    {
        filterParameter = sliderParameter.value;
        textFilterParameter.text = String.Format("{0:0.000}", filterParameter);
        Debug.Log(filterParameter.ToString());
    }

    public void OnDropdownFilterTypeChange()
    {
        Debug.Log("OnDropdownFilterTypeChange");
        switch (dropDownFilterType.value)
        {
            case 0: filterType = FilterType.MovingAverage; break;
            case 1: filterType = FilterType.SignlePole; break;
            case 2: filterType = FilterType.Gaussian; break;
        }
    }


    public FilterType filterType;
    public int filterLength;
    public double filterParameter;


    private void setObjects()
    {
        Debug.Log("setObjects");
        textFilterLength = GameObject.Find("TextFilterLength").GetComponent<Text>();
        textFilterParameter = GameObject.Find("TextFilterParameter").GetComponent<Text>();
        sliderLength = GameObject.Find("SliderLength").GetComponent<Slider>();
        sliderParameter = GameObject.Find("SliderParameter").GetComponent<Slider>();
        dropDownFilterType = GameObject.Find("DropdownFilterType").GetComponent<Dropdown>();
    }



    private Slider sliderLength;
    private Slider sliderParameter;
    private InputField inputField;
    private Dropdown dropDownFilterType;
    private Text textFilterLength;
    private Text textFilterParameter;
}
