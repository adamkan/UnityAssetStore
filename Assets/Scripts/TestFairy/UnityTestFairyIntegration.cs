using UnityEngine;
using System.Collections;
using TestFairyUnity;

public class UnityTestFairyIntegration : MonoBehaviour {
	public string tfAPIKey;

	// Use this for initialization
	void Start () {
		TestFairy.begin (tfAPIKey);
	}
}
