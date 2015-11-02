using System;
using ObjCRuntime;

[Native]
public enum IQAutoToolbarManageBehaviour : nint
{
	Subviews,
	Tag,
	Position
}

[Native]
public enum IQLayoutGuidePosition : nint
{
	None,
	Top,
	Bottom
}
