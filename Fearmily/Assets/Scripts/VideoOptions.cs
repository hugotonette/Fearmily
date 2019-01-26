using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOptions : MonoBehaviour {
	public Dropdown ResolutionDropdown;
	public Toggle Fullscreen;
	public Toggle VSync;

	// Use this for initialization
	void Start () {
		Fullscreen.isOn = Screen.fullScreen;
		VSync.isOn = (QualitySettings.vSyncCount != 0);
		ResolutionDropdown.ClearOptions();
		List<string> options = new List<string>();

		foreach(Resolution res in Screen.resolutions){
			options.Add(res.ToString());
		}

		ResolutionDropdown.AddOptions(options);
		ResolutionDropdown.onValueChanged.AddListener(delegate {
			ApplySelectedResolution();
		});
	}
	
	public void ApplySelectedResolution(){
		int index = ResolutionDropdown.value;
		Resolution selectedRes = Screen.resolutions[index];
		Screen.SetResolution(selectedRes.width, selectedRes.height, Fullscreen.isOn, selectedRes.refreshRate);
	}

	public void Apply(){
		QualitySettings.vSyncCount = VSync.isOn ? 1 : 0;
		ApplySelectedResolution();
	}
}
