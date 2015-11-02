using System;
using ObjCRuntime;

namespace Xamarin {

	[Native]
	public enum IQAutoToolbarManageBehaviour : long
	{
		Subviews,
		Tag,
		Position
	}

	[Native]
	public enum IQLayoutGuidePosition : long
	{
		None,
		Top,
		Bottom
	}
}