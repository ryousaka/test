using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

[System.Serializable]
public class Player {

	private int hp = 0;

	public int Hp {
		get {
			return hp;
		}
		set {
			hp = value;
		}
	}
}
