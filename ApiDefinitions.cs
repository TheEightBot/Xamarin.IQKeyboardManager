using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface IQBarButtonItem : UIBarButtonItem
[BaseType (typeof(UIBarButtonItem))]
interface IQBarButtonItem
{
}

[Static]
partial interface Constants
{
	// extern const NSInteger kIQDoneButtonToolbarTag;
	[Field ("kIQDoneButtonToolbarTag", "__Internal")]
	nint kIQDoneButtonToolbarTag { get; }

	// extern const NSInteger kIQPreviousNextButtonToolbarTag;
	[Field ("kIQPreviousNextButtonToolbarTag", "__Internal")]
	nint kIQPreviousNextButtonToolbarTag { get; }
}

// @interface IQKeyboardManager : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface IQKeyboardManager
{
	// +(instancetype _Nonnull)sharedManager;
	[Static]
	[Export ("sharedManager")]
	IQKeyboardManager SharedManager ();

	// @property (getter = isEnabled, assign, nonatomic) BOOL enable;
	[Export ("enable")]
	bool Enable { [Bind ("isEnabled")] get; set; }

	// @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
	[Export ("keyboardDistanceFromTextField")]
	nfloat KeyboardDistanceFromTextField { get; set; }

	// @property (assign, nonatomic) BOOL preventShowingBottomBlankSpace;
	[Export ("preventShowingBottomBlankSpace")]
	bool PreventShowingBottomBlankSpace { get; set; }

	// @property (getter = isEnableAutoToolbar, assign, nonatomic) BOOL enableAutoToolbar;
	[Export ("enableAutoToolbar")]
	bool EnableAutoToolbar { [Bind ("isEnableAutoToolbar")] get; set; }

	// @property (assign, nonatomic) IQAutoToolbarManageBehaviour toolbarManageBehaviour;
	[Export ("toolbarManageBehaviour", ArgumentSemantic.Assign)]
	IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

	// @property (assign, nonatomic) BOOL shouldToolbarUsesTextFieldTintColor;
	[Export ("shouldToolbarUsesTextFieldTintColor")]
	bool ShouldToolbarUsesTextFieldTintColor { get; set; }

	// @property (assign, nonatomic) BOOL shouldShowTextFieldPlaceholder;
	[Export ("shouldShowTextFieldPlaceholder")]
	bool ShouldShowTextFieldPlaceholder { get; set; }

	// @property (nonatomic, strong) UIFont * _Nullable placeholderFont;
	[NullAllowed, Export ("placeholderFont", ArgumentSemantic.Strong)]
	UIFont PlaceholderFont { get; set; }

	// @property (assign, nonatomic) BOOL canAdjustTextView;
	[Export ("canAdjustTextView")]
	bool CanAdjustTextView { get; set; }

	// @property (assign, nonatomic) BOOL shouldFixTextViewClip;
	[Export ("shouldFixTextViewClip")]
	bool ShouldFixTextViewClip { get; set; }

	// @property (assign, nonatomic) BOOL overrideKeyboardAppearance;
	[Export ("overrideKeyboardAppearance")]
	bool OverrideKeyboardAppearance { get; set; }

	// @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
	[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
	UIKeyboardAppearance KeyboardAppearance { get; set; }

	// @property (assign, nonatomic) BOOL shouldResignOnTouchOutside;
	[Export ("shouldResignOnTouchOutside")]
	bool ShouldResignOnTouchOutside { get; set; }

	// -(BOOL)resignFirstResponder;
	[Export ("resignFirstResponder")]
	bool ResignFirstResponder ();

	// @property (readonly, nonatomic) BOOL canGoPrevious;
	[Export ("canGoPrevious")]
	bool CanGoPrevious { get; }

	// @property (readonly, nonatomic) BOOL canGoNext;
	[Export ("canGoNext")]
	bool CanGoNext { get; }

	// -(BOOL)goPrevious;
	[Export ("goPrevious")]
	bool GoPrevious ();

	// -(BOOL)goNext;
	[Export ("goNext")]
	bool GoNext ();

	// @property (assign, nonatomic) BOOL shouldRestoreScrollViewContentOffset;
	[Export ("shouldRestoreScrollViewContentOffset")]
	bool ShouldRestoreScrollViewContentOffset { get; set; }

	// @property (assign, nonatomic) BOOL shouldPlayInputClicks;
	[Export ("shouldPlayInputClicks")]
	bool ShouldPlayInputClicks { get; set; }

	// @property (assign, nonatomic) BOOL shouldAdoptDefaultKeyboardAnimation;
	[Export ("shouldAdoptDefaultKeyboardAnimation")]
	bool ShouldAdoptDefaultKeyboardAnimation { get; set; }

	// @property (assign, nonatomic) BOOL layoutIfNeededOnUpdate;
	[Export ("layoutIfNeededOnUpdate")]
	bool LayoutIfNeededOnUpdate { get; set; }

	// -(void)disableInViewControllerClass:(Class _Nonnull)disabledClass;
	[Export ("disableInViewControllerClass:")]
	void DisableInViewControllerClass (Class disabledClass);

	// -(void)removeDisableInViewControllerClass:(Class _Nonnull)disabledClass;
	[Export ("removeDisableInViewControllerClass:")]
	void RemoveDisableInViewControllerClass (Class disabledClass);

	// -(BOOL)isDisableInViewControllerClass:(Class _Nonnull)disabledClass;
	[Export ("isDisableInViewControllerClass:")]
	bool IsDisableInViewControllerClass (Class disabledClass);

	// -(void)disableToolbarInViewControllerClass:(Class _Nonnull)toolbarDisabledClass;
	[Export ("disableToolbarInViewControllerClass:")]
	void DisableToolbarInViewControllerClass (Class toolbarDisabledClass);

	// -(void)removeDisableToolbarInViewControllerClass:(Class _Nonnull)toolbarDisabledClass;
	[Export ("removeDisableToolbarInViewControllerClass:")]
	void RemoveDisableToolbarInViewControllerClass (Class toolbarDisabledClass);

	// -(BOOL)isDisableToolbarInViewControllerClass:(Class _Nonnull)toolbarDisabledClass;
	[Export ("isDisableToolbarInViewControllerClass:")]
	bool IsDisableToolbarInViewControllerClass (Class toolbarDisabledClass);

	// -(void)considerToolbarPreviousNextInViewClass:(Class _Nonnull)toolbarPreviousNextConsideredClass;
	[Export ("considerToolbarPreviousNextInViewClass:")]
	void ConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

	// -(void)removeConsiderToolbarPreviousNextInViewClass:(Class _Nonnull)toolbarPreviousNextConsideredClass;
	[Export ("removeConsiderToolbarPreviousNextInViewClass:")]
	void RemoveConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

	// -(BOOL)isConsiderToolbarPreviousNextInViewClass:(Class _Nonnull)toolbarPreviousNextConsideredClass;
	[Export ("isConsiderToolbarPreviousNextInViewClass:")]
	bool IsConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);
}

// @interface IQKeyboardReturnKeyHandler : NSObject
[BaseType (typeof(NSObject))]
interface IQKeyboardReturnKeyHandler
{
	// -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nullable)controller __attribute__((objc_designated_initializer));
	[Export ("initWithViewController:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] UIViewController controller);

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	NSObject<UITextFieldDelegate, UITextViewDelegate> Delegate { get; set; }

	// @property (nonatomic, weak) id<UITextFieldDelegate,UITextViewDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) UIReturnKeyType lastTextFieldReturnKeyType;
	[Export ("lastTextFieldReturnKeyType", ArgumentSemantic.Assign)]
	UIReturnKeyType LastTextFieldReturnKeyType { get; set; }

	// -(void)addTextFieldView:(UIView * _Nonnull)textFieldView;
	[Export ("addTextFieldView:")]
	void AddTextFieldView (UIView textFieldView);

	// -(void)removeTextFieldView:(UIView * _Nonnull)textFieldView;
	[Export ("removeTextFieldView:")]
	void RemoveTextFieldView (UIView textFieldView);

	// -(void)addResponderFromView:(UIView * _Nonnull)view;
	[Export ("addResponderFromView:")]
	void AddResponderFromView (UIView view);

	// -(void)removeResponderFromView:(UIView * _Nonnull)view;
	[Export ("removeResponderFromView:")]
	void RemoveResponderFromView (UIView view);
}

// @interface IQ_NSArray_Sort (NSArray)
[Category]
[BaseType (typeof(NSArray))]
interface NSArray_IQ_NSArray_Sort
{
	// -(NSArray * _Nonnull)sortedArrayByTag;
	[Export ("sortedArrayByTag")]
	NSObject[] SortedArrayByTag { get; }

	// -(NSArray * _Nonnull)sortedArrayByPosition;
	[Export ("sortedArrayByPosition")]
	NSObject[] SortedArrayByPosition { get; }
}

// @interface IQSegmentedNextPrevious : UISegmentedControl
[BaseType (typeof(UISegmentedControl))]
[DisableDefaultCtor]
interface IQSegmentedNextPrevious
{
	// -(instancetype _Nonnull)initWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction __attribute__((objc_designated_initializer));
	[Export ("initWithTarget:previousAction:nextAction:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction);
}

// @interface IQTextView : UITextView
[BaseType (typeof(UITextView))]
interface IQTextView
{
	// @property (copy, nonatomic) NSString * _Nullable placeholder;
	[NullAllowed, Export ("placeholder")]
	string Placeholder { get; set; }
}

// @interface IQTitleBarButtonItem : IQBarButtonItem
[BaseType (typeof(IQBarButtonItem))]
[DisableDefaultCtor]
interface IQTitleBarButtonItem
{
	// @property (nonatomic, strong) UIFont * _Nullable font;
	[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
	UIFont Font { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame title:(NSString * _Nullable)title __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:title:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame, [NullAllowed] string title);
}

// @interface IQToolbar : UIToolbar <UIInputViewAudioFeedback>
[BaseType (typeof(UIToolbar))]
interface IQToolbar : IUIInputViewAudioFeedback
{
	// @property (nonatomic, strong) UIFont * _Nullable titleFont;
	[NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
	UIFont TitleFont { get; set; }

	// @property (nonatomic, strong) NSString * _Nullable title;
	[NullAllowed, Export ("title", ArgumentSemantic.Strong)]
	string Title { get; set; }
}

// @interface Additions (UIView)
[Category]
[BaseType (typeof(UIView))]
interface UIView_Additions
{
	// @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
	[Export ("keyboardDistanceFromTextField")]
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
	[Export ("isAskingCanBecomeFirstResponder")]
	bool IsAskingCanBecomeFirstResponder { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable viewController;
	[NullAllowed, Export ("viewController", ArgumentSemantic.Strong)]
	UIViewController ViewController { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
	[NullAllowed, Export ("topMostController", ArgumentSemantic.Strong)]
	UIViewController TopMostController { get; }

	// -(UIView * _Nullable)superviewOfClassType:(Class _Nonnull)classType;
	[Export ("superviewOfClassType:")]
	[return: NullAllowed]
	UIView SuperviewOfClassType (Class classType);

	// @property (readonly, copy, nonatomic) NSArray * _Nonnull responderSiblings;
	[Export ("responderSiblings", ArgumentSemantic.Copy)]
	NSObject[] ResponderSiblings { get; }

	// @property (readonly, copy, nonatomic) NSArray * _Nonnull deepResponderViews;
	[Export ("deepResponderViews", ArgumentSemantic.Copy)]
	NSObject[] DeepResponderViews { get; }

	// @property (readonly, getter = isSearchBarTextField, nonatomic) BOOL searchBarTextField;
	[Export ("searchBarTextField")]
	bool SearchBarTextField { [Bind ("isSearchBarTextField")] get; }

	// @property (readonly, getter = isAlertViewTextField, nonatomic) BOOL alertViewTextField;
	[Export ("alertViewTextField")]
	bool AlertViewTextField { [Bind ("isAlertViewTextField")] get; }

	// -(CGAffineTransform)convertTransformToView:(UIView * _Nullable)toView;
	[Export ("convertTransformToView:")]
	CGAffineTransform ConvertTransformToView ([NullAllowed] UIView toView);

	// @property (readonly, copy, nonatomic) NSString * _Nonnull subHierarchy;
	[Export ("subHierarchy")]
	string SubHierarchy { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull superHierarchy;
	[Export ("superHierarchy")]
	string SuperHierarchy { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugHierarchy;
	[Export ("debugHierarchy")]
	string DebugHierarchy { get; }
}

// @interface IQ_Logging (NSObject)
[Category]
[BaseType (typeof(NSObject))]
interface NSObject_IQ_Logging
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull _IQDescription;
	[Export ("_IQDescription")]
	string _IQDescription ();
}

// @interface IQToolbarAddition (UIView)
[Category]
[BaseType (typeof(UIView))]
interface UIView_IQToolbarAddition
{
	// @property (assign, nonatomic) BOOL shouldHideTitle;
	[Export ("shouldHideTitle")]
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
	[NullAllowed, Export ("previousInvocation", ArgumentSemantic.Strong)]
	NSInvocation PreviousInvocation { get; set; }

	// @property (nonatomic, strong) NSInvocation * _Nullable nextInvocation;
	[NullAllowed, Export ("nextInvocation", ArgumentSemantic.Strong)]
	NSInvocation NextInvocation { get; set; }

	// @property (nonatomic, strong) NSInvocation * _Nullable doneInvocation;
	[NullAllowed, Export ("doneInvocation", ArgumentSemantic.Strong)]
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
	[NullAllowed, Export ("IQLayoutGuideConstraint", ArgumentSemantic.Strong)]
	NSLayoutConstraint IQLayoutGuideConstraint { get; set; }
}

// @interface IQ_UIWindow_Hierarchy (UIWindow)
[Category]
[BaseType (typeof(UIWindow))]
interface UIWindow_IQ_UIWindow_Hierarchy
{
	// @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
	[NullAllowed, Export ("topMostController", ArgumentSemantic.Strong)]
	UIViewController TopMostController { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable currentViewController;
	[NullAllowed, Export ("currentViewController", ArgumentSemantic.Strong)]
	UIViewController CurrentViewController { get; }
}
