using System.Collections.Generic;
using System.Linq;

public class OperationBaseScript : ArgumentScript {

	bool IsInside = false;


	private void ChangeArgumentValue( ) {

		IEnumerable<ArgumentScript> args =
			FindObjectsOfType<ArgumentScript>().
			ToList<ArgumentScript>().
			Where(a => a.GetArgumentEnum() == ArgumentType);

		foreach ( var item in args )
			item.ChangeValue( isTrue );

		CheckOperationValue();

	}
	private void CheckOperationValue( ) {
	
		var operators = FindObjectsOfType<ListenerOperator>().OrderBy(o => o.GetOrder());
		foreach ( var o in operators )
			o.CheckArguments();

	}
	private void OnMouseDown( ) {
		if ( IsInside ) {

			isTrue = !isTrue;
			ChangeArgumentValue();

		}
	}
	private void OnMouseEnter( ) {

		IsInside = true;

	}
	private void OnMouseExit( ) {

		IsInside = false;

	}
	protected override void Start( ) {

		base.Start();

		ChangeArgumentValue();

	}
}

