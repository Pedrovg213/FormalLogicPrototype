using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArgumentOperationScript : MonoBehaviour {

	[SerializeField] protected ArgumentEnum ArgumentType = new ArgumentEnum();
	[SerializeField] TextMeshPro ArgumentText;
	[SerializeField] Light Light;
	public bool IsTrue;

	private void ChangeColor( ) {

		Light.color = IsTrue ? Color.green : Color.red;

	}
	public void ChangeTrue( bool _trueState ) {

		IsTrue = _trueState;
		ChangeColor();

	}
	public ArgumentEnum GetArgumentEnum( ) {

		return ( ArgumentType );

	}
	protected virtual void Start( ) {

		ArgumentText.text = ArgumentType == ArgumentEnum.Default ? " " : ArgumentType.ToString();

	}
}

public enum ArgumentEnum {

	Default, A, B, C, D, E, F, G, H

}
