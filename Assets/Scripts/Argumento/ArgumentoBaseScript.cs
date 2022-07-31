using System.Collections.Generic;
using System.Linq;

public class ArgumentoBaseScript : ArgumentOperationScript {

	bool IsInside = false;

	void ChangeOperationColors( ) {

		var args =
			FindObjectsOfType<ArgumentOperationScript>().
			ToList<ArgumentOperationScript>().
			Where(a => a.GetArgumentEnum() == ArgumentType);

		IsTrue = !IsTrue;
		foreach ( var item in args )
			item.ChangeTrue( IsTrue );

	}
	private void OnMouseDown( ) {

		if ( IsInside )
			ChangeOperationColors();

	}
	private void OnMouseEnter( ) {

		IsInside = true;

	}
	private void OnMouseExit( ) {

		IsInside = false;

	}
	protected override void Start( ) {

		base.Start();

	}
}

