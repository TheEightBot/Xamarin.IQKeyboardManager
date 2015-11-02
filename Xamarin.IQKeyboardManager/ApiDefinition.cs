using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin
{

	// @interface IQBarButtonItem : UIBarButtonItem
	[BaseType (typeof(UIBarButtonItem))]
	interface IQBarButtonItem
	{
	}

	//[Static]
	partial interface Constants
	{
		[Field ("kIQDoneButtonToolbarTag", "__Internal")]
		nint kIQDoneButtonToolbarTag { get; }

		[Field ("kIQPreviousNextButtonToolbarTag", "__Internal")]
		nint kIQPreviousNextButtonToolbarTag { get; }

	}

	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IQKeyboardManager
	{
		[Static]
		[Export ("sharedManager")]
		IQKeyboardManager SharedManager { get; }

		[Export ("enable")]
		bool Enable { [Bind ("isEnabled")] get; set; }

		[Export ("keyboardDistanceFromTextField")]
		nfloat KeyboardDistanceFromTextField { get; set; }

		[Export ("preventShowingBottomBlankSpace")]
		bool PreventShowingBottomBlankSpace { get; set; }

		[Export ("enableAutoToolbar")]
		bool EnableAutoToolbar { [Bind ("isEnableAutoToolbar")] get; set; }

		[Export ("toolbarManageBehaviour", ArgumentSemantic.Assign)]
		IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

		[Export ("shouldToolbarUsesTextFieldTintColor")]
		bool ShouldToolbarUsesTextFieldTintColor { get; set; }

		[Export ("shouldShowTextFieldPlaceholder")]
		bool ShouldShowTextFieldPlaceholder { get; set; }

		[NullAllowed, Export ("placeholderFont", ArgumentSemantic.Strong)]
		UIFont PlaceholderFont { get; set; }

		[Export ("canAdjustTextView")]
		bool CanAdjustTextView { get; set; }

		[Export ("shouldFixTextViewClip")]
		bool ShouldFixTextViewClip { get; set; }

		[Export ("overrideKeyboardAppearance")]
		bool OverrideKeyboardAppearance { get; set; }

		[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		[Export ("shouldResignOnTouchOutside")]
		bool ShouldResignOnTouchOutside { get; set; }

		[Export ("resignFirstResponder")]
		bool ResignFirstResponder ();

		[Export ("canGoPrevious")]
		bool CanGoPrevious { get; }

		[Export ("canGoNext")]
		bool CanGoNext { get; }

		[Export ("goPrevious")]
		bool GoPrevious ();

		[Export ("goNext")]
		bool GoNext ();

		[Export ("shouldRestoreScrollViewContentOffset")]
		bool ShouldRestoreScrollViewContentOffset { get; set; }

		[Export ("shouldPlayInputClicks")]
		bool ShouldPlayInputClicks { get; set; }

		[Export ("shouldAdoptDefaultKeyboardAnimation")]
		bool ShouldAdoptDefaultKeyboardAnimation { get; set; }

		[Export ("layoutIfNeededOnUpdate")]
		bool LayoutIfNeededOnUpdate { get; set; }

		[Export ("disableInViewControllerClass:")]
		void DisableInViewControllerClass (Class disabledClass);

		[Export ("removeDisableInViewControllerClass:")]
		void RemoveDisableInViewControllerClass (Class disabledClass);

		[Export ("isDisableInViewControllerClass:")]
		bool IsDisableInViewControllerClass (Class disabledClass);

		[Export ("disableToolbarInViewControllerClass:")]
		void DisableToolbarInViewControllerClass (Class toolbarDisabledClass);

		[Export ("removeDisableToolbarInViewControllerClass:")]
		void RemoveDisableToolbarInViewControllerClass (Class toolbarDisabledClass);

		[Export ("isDisableToolbarInViewControllerClass:")]
		bool IsDisableToolbarInViewControllerClass (Class toolbarDisabledClass);

		[Export ("considerToolbarPreviousNextInViewClass:")]
		void ConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

		[Export ("removeConsiderToolbarPreviousNextInViewClass:")]
		void RemoveConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

		[Export ("isConsiderToolbarPreviousNextInViewClass:")]
		bool IsConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

	}

	[BaseType (typeof(NSObject))]
	interface IQKeyboardReturnKeyHandler
	{
		[Export ("initWithViewController:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIViewController controller);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		NSObject/*<UITextFieldDelegate, UITextViewDelegate>*/ Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Export ("lastTextFieldReturnKeyType", ArgumentSemantic.Assign)]
		UIReturnKeyType LastTextFieldReturnKeyType { get; set; }

		[Export ("addTextFieldView:")]
		void AddTextFieldView (UIView textFieldView);

		[Export ("removeTextFieldView:")]
		void RemoveTextFieldView (UIView textFieldView);

		[Export ("addResponderFromView:")]
		void AddResponderFromView (UIView view);

		[Export ("removeResponderFromView:")]
		void RemoveResponderFromView (UIView view);

	}

	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_IQ_NSArray_Sort
	{
		[Export ("sortedArrayByTag")]
		NSObject[] SortedArrayByTag ();

		[Export ("sortedArrayByPosition")]
		NSObject[] SortedArrayByPosition ();

	}

	[BaseType (typeof(UISegmentedControl))]
	[DisableDefaultCtor]
	interface IQSegmentedNextPrevious
	{
		[Export ("initWithTarget:previousAction:nextAction:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction);

	}

	[BaseType (typeof(UITextView))]
	interface IQTextView
	{
		[NullAllowed, Export ("placeholder")]
		string Placeholder { get; set; }

	}

	[BaseType (typeof(IQBarButtonItem))]
	[DisableDefaultCtor]
	interface IQTitleBarButtonItem
	{
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		[Export ("initWithFrame:title:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame, [NullAllowed] string title);

	}

	[BaseType (typeof(UIToolbar))]
	interface IQToolbar : IUIInputViewAudioFeedback
	{
		[NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		[NullAllowed, Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

	}

	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_Additions
	{
//		[Export ("keyboardDistanceFromTextField")]
//		nfloat KeyboardDistanceFromTextField ();
//
//		[Export ("setKeyboardDistanceFromTextField:")]
//		void SetKeyboardDistanceFromTextField (nfloat keyboardDistanceFromTextField);
		// @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
		[Static, Export ("keyboardDistanceFromTextField")]
		nfloat KeyboardDistanceFromTextField { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern const CGFloat kIQUseDefaultKeyboardDistance;
		[Field ("kIQUseDefaultKeyboardDistance", "__Internal")]
		nfloat kIQUseDefaultKeyboardDistance { get; }
	}

	// @interface IQ_UIView_Hierarchy (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_IQ_UIView_Hierarchy
	{
		// @property (readonly, nonatomic) BOOL isAskingCanBecomeFirstResponder;
		[Static, Export ("isAskingCanBecomeFirstResponder")]
		bool IsAskingCanBecomeFirstResponder { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable viewController;
		[Static, NullAllowed, Export ("viewController", ArgumentSemantic.Strong)]
		UIViewController ViewController { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
		[Static, NullAllowed, Export ("topMostController", ArgumentSemantic.Strong)]
		UIViewController TopMostController { get; }

		// -(UIView * _Nullable)superviewOfClassType:(Class _Nonnull)classType;
		[Export ("superviewOfClassType:")]
		[return: NullAllowed]
		UIView SuperviewOfClassType (Class classType);

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull responderSiblings;
		[Static, Export ("responderSiblings", ArgumentSemantic.Copy)]
		NSObject[] ResponderSiblings { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull deepResponderViews;
		[Static, Export ("deepResponderViews", ArgumentSemantic.Copy)]
		NSObject[] DeepResponderViews { get; }

		// @property (readonly, getter = isSearchBarTextField, nonatomic) BOOL searchBarTextField;
		[Static, Export ("searchBarTextField")]
		bool SearchBarTextField { [Bind ("isSearchBarTextField")] get; }

		// @property (readonly, getter = isAlertViewTextField, nonatomic) BOOL alertViewTextField;
		[Static, Export ("alertViewTextField")]
		bool AlertViewTextField { [Bind ("isAlertViewTextField")] get; }

		// -(CGAffineTransform)convertTransformToView:(UIView * _Nullable)toView;
		[Export ("convertTransformToView:")]
		CGAffineTransform ConvertTransformToView ([NullAllowed] UIView toView);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subHierarchy;
		[Static, Export ("subHierarchy")]
		string SubHierarchy { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull superHierarchy;
		[Static, Export ("superHierarchy")]
		string SuperHierarchy { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugHierarchy;
		[Static, Export ("debugHierarchy")]
		string DebugHierarchy { get; }
	}

	// @interface IQ_Logging (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_IQ_Logging
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull _IQDescription;
		[Static, Export ("_IQDescription")]
		string IQDescription { get; }
	}

	// @interface IQToolbarAddition (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_IQToolbarAddition
	{
		// @property (assign, nonatomic) BOOL shouldHideTitle;
		[Static, Export ("shouldHideTitle")]
		bool ShouldHideTitle { get; set; }

		// -(void)setCustomPreviousTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export ("setCustomPreviousTarget:action:")]
		void SetCustomPreviousTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)setCustomNextTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export ("setCustomNextTarget:action:")]
		void SetCustomNextTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)setCustomDoneTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export ("setCustomDoneTarget:action:")]
		void SetCustomDoneTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// @property (nonatomic, strong) NSInvocation * _Nullable previousInvocation;
		[Static, NullAllowed, Export ("previousInvocation", ArgumentSemantic.Strong)]
		NSInvocation PreviousInvocation { get; set; }

		// @property (nonatomic, strong) NSInvocation * _Nullable nextInvocation;
		[Static, NullAllowed, Export ("nextInvocation", ArgumentSemantic.Strong)]
		NSInvocation NextInvocation { get; set; }

		// @property (nonatomic, strong) NSInvocation * _Nullable doneInvocation;
		[Static, NullAllowed, Export ("doneInvocation", ArgumentSemantic.Strong)]
		NSInvocation DoneInvocation { get; set; }

		// -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export ("addDoneOnKeyboardWithTarget:action:")]
		void AddDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
		[Export ("addDoneOnKeyboardWithTarget:action:titleText:")]
		void AddDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

		// -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
		[Export ("addDoneOnKeyboardWithTarget:action:shouldShowPlaceholder:")]
		void AddDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

		// -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action;
		[Export ("addRightButtonOnKeyboardWithText:target:action:")]
		void AddRightButtonOnKeyboardWithText ([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
		[Export ("addRightButtonOnKeyboardWithText:target:action:titleText:")]
		void AddRightButtonOnKeyboardWithText ([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

		// -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
		[Export ("addRightButtonOnKeyboardWithText:target:action:shouldShowPlaceholder:")]
		void AddRightButtonOnKeyboardWithText ([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

		// -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction;
		[Export ("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:")]
		void AddCancelDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction);

		// -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction titleText:(NSString * _Nullable)titleText;
		[Export ("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:titleText:")]
		void AddCancelDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction, [NullAllowed] string titleText);

		// -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
		[Export ("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:shouldShowPlaceholder:")]
		void AddCancelDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction, bool shouldShowPlaceholder);

		// -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction;
		[Export ("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:")]
		void AddLeftRightOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction);

		// -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
		[Export ("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:titleText:")]
		void AddLeftRightOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

		// -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
		[Export ("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:shouldShowPlaceholder:")]
		void AddLeftRightOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

		// -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction;
		[Export ("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:")]
		void AddPreviousNextDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction);

		// -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction titleText:(NSString * _Nullable)titleText;
		[Export ("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:titleText:")]
		void AddPreviousNextDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction, [NullAllowed] string titleText);

		// -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
		[Export ("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:shouldShowPlaceholder:")]
		void AddPreviousNextDoneOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction, bool shouldShowPlaceholder);

		// -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction;
		[Export ("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:")]
		void AddPreviousNextRightOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction);

		// -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
		[Export ("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:titleText:")]
		void AddPreviousNextRightOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

		// -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
		[Export ("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:shouldShowPlaceholder:")]
		void AddPreviousNextRightOnKeyboardWithTarget ([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

		// -(void)setEnablePrevious:(BOOL)isPreviousEnabled next:(BOOL)isNextEnabled;
		[Export ("setEnablePrevious:next:")]
		void SetEnablePrevious (bool isPreviousEnabled, bool isNextEnabled);
	}

	// @interface Additions (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_Additions
	{
		// @property (nonatomic, strong) NSLayoutConstraint * _Nullable IQLayoutGuideConstraint __attribute__((iboutlet));
		[Static, NullAllowed, Export ("IQLayoutGuideConstraint", ArgumentSemantic.Strong)]
		NSLayoutConstraint IQLayoutGuideConstraint { get; set; }
	}

	// @interface IQ_UIWindow_Hierarchy (UIWindow)
	[Category]
	[BaseType (typeof(UIWindow))]
	interface UIWindow_IQ_UIWindow_Hierarchy
	{
		// @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
		[Static, NullAllowed, Export ("topMostController", ArgumentSemantic.Strong)]
		UIViewController TopMostController { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable currentViewController;
		[Static, NullAllowed, Export ("currentViewController", ArgumentSemantic.Strong)]
		UIViewController CurrentViewController { get; }
	}
}