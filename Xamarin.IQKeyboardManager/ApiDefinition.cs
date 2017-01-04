using UIKit;
using Foundation;
using ObjCRuntime;
using System;
using CoreGraphics;

namespace Xamarin
{

    // @interface IQBarButtonItem : UIBarButtonItem
    [BaseType(typeof(UIBarButtonItem))]
    interface IQBarButtonItem
    {

    }

    // @interface IQKeyboardManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface IQKeyboardManager
    {

        // @property (assign, nonatomic, getter = isEnabled) BOOL enable;
        [Export("enable", ArgumentSemantic.UnsafeUnretained)]
        bool Enable { [Bind("isEnabled")] get; set; }

        // @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
        [Export("keyboardDistanceFromTextField", ArgumentSemantic.UnsafeUnretained)]
        nfloat KeyboardDistanceFromTextField { get; set; }

        // @property (assign, nonatomic) BOOL preventShowingBottomBlankSpace;
        [Export("preventShowingBottomBlankSpace", ArgumentSemantic.UnsafeUnretained)]
        bool PreventShowingBottomBlankSpace { get; set; }

        // @property (assign, nonatomic, getter = isEnableAutoToolbar) BOOL enableAutoToolbar;
        [Export("enableAutoToolbar", ArgumentSemantic.UnsafeUnretained)]
        bool EnableAutoToolbar { [Bind("isEnableAutoToolbar")] get; set; }

        // @property (assign, nonatomic) IQAutoToolbarManageBehaviour toolbarManageBehaviour;
        [Export("toolbarManageBehaviour", ArgumentSemantic.UnsafeUnretained)]
        IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

        // @property (assign, nonatomic) BOOL shouldToolbarUsesTextFieldTintColor;
        [Introduced(PlatformName.iOS, 7, 0)]
        [Export("shouldToolbarUsesTextFieldTintColor", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldToolbarUsesTextFieldTintColor { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowTextFieldPlaceholder;
        [Export("shouldShowTextFieldPlaceholder", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldShowTextFieldPlaceholder { get; set; }

        // @property (nonatomic, strong) UIFont * placeholderFont;
        [Export("placeholderFont", ArgumentSemantic.Retain)]
        UIFont PlaceholderFont { get; set; }

        // @property (assign, nonatomic) BOOL canAdjustTextView;
        [Export("canAdjustTextView", ArgumentSemantic.UnsafeUnretained)]
        bool CanAdjustTextView { get; set; }

        // @property (assign, nonatomic) BOOL shouldFixTextViewClip;
        [Export("shouldFixTextViewClip", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldFixTextViewClip { get; set; }

        // @property (assign, nonatomic) BOOL overrideKeyboardAppearance;
        [Export("overrideKeyboardAppearance", ArgumentSemantic.UnsafeUnretained)]
        bool OverrideKeyboardAppearance { get; set; }

        // @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
        [Export("keyboardAppearance", ArgumentSemantic.UnsafeUnretained)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (assign, nonatomic) BOOL shouldResignOnTouchOutside;
        [Export("shouldResignOnTouchOutside", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldResignOnTouchOutside { get; set; }

        // @property (assign, nonatomic) BOOL shouldPlayInputClicks;
        [Export("shouldPlayInputClicks", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldPlayInputClicks { get; set; }

        // @property (assign, nonatomic) BOOL shouldAdoptDefaultKeyboardAnimation;
        [Export("shouldAdoptDefaultKeyboardAnimation", ArgumentSemantic.UnsafeUnretained)]
        bool ShouldAdoptDefaultKeyboardAnimation { get; set; }

        // +(instancetype)sharedManager;
        [Static, Export("sharedManager")]
        IQKeyboardManager SharedManager { get; }

        // -(void)resignFirstResponder;
        [Export("resignFirstResponder")]
        void ResignFirstResponder();

        [Unavailable(PlatformName.iOS)]
        [Unavailable(PlatformName.MacOSX)]
        [Static, Export("new")]
        IQKeyboardManager New();
    }

    // @interface IQKeyboardReturnKeyHandler : NSObject
    [BaseType(typeof(NSObject))]
    interface IQKeyboardReturnKeyHandler
    {

        // -(instancetype)initWithViewController:(UIViewController *)controller;
        [Export("initWithViewController:")]
        IntPtr Constructor(UIViewController controller);

        // @property (nonatomic, weak) id<UITextFieldDelegate,UITextViewDelegate> delegate;
        [Export("delegate", ArgumentSemantic.Weak)]
        [NullAllowed]
        NSObject WeakDelegate { get; set; }

        //TODO: Implement
        //		// @property (nonatomic, weak) id<UITextFieldDelegate,UITextViewDelegate> delegate;
        //		[Wrap ("WeakDelegate")]
        //		NSObject<UITextFieldDelegate, UITextViewDelegate> Delegate { get; set; }
        //
        // @property (assign, nonatomic) IQAutoToolbarManageBehaviour toolbarManageBehaviour;
        [Export("toolbarManageBehaviour", ArgumentSemantic.UnsafeUnretained)]
        IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

        // @property (assign, nonatomic) UIReturnKeyType lastTextFieldReturnKeyType;
        [Export("lastTextFieldReturnKeyType", ArgumentSemantic.UnsafeUnretained)]
        UIReturnKeyType LastTextFieldReturnKeyType { get; set; }

        // -(void)addTextFieldView:(UIView *)textFieldView;
        [Export("addTextFieldView:")]
        void AddTextFieldView(UIView textFieldView);

        // -(void)removeTextFieldView:(UIView *)textFieldView;
        [Export("removeTextFieldView:")]
        void RemoveTextFieldView(UIView textFieldView);

        // -(void)addResponderFromView:(UIView *)view;
        [Export("addResponderFromView:")]
        void AddResponderFromView(UIView view);

        // -(void)removeResponderFromView:(UIView *)view;
        [Export("removeResponderFromView:")]
        void RemoveResponderFromView(UIView view);
    }

    // @interface IQSegmentedNextPrevious : UISegmentedControl
    [Deprecated(PlatformName.iOS, 7, 0)]
    [BaseType(typeof(UISegmentedControl))]
    [DisableDefaultCtor]
    interface IQSegmentedNextPrevious
    {

        // -(instancetype)initWithTarget:(id)target previousAction:(SEL)previousAction nextAction:(SEL)nextAction;
        [Export("initWithTarget:previousAction:nextAction:")]
        IntPtr Constructor(NSObject target, Selector previousAction, Selector nextAction);

        // +(instancetype)new;
        [Unavailable(PlatformName.iOS)]
        [Unavailable(PlatformName.MacOSX)]
        [Static, Export("new")]
        IQSegmentedNextPrevious New();
    }

    // @interface IQTextView : UITextView
    [BaseType(typeof(UITextView))]
    interface IQTextView
    {

        // @property (copy, nonatomic) NSString * placeholder;
        [Export("placeholder")]
        string Placeholder { get; set; }
    }

    // @interface IQTitleBarButtonItem : IQBarButtonItem
    [BaseType(typeof(IQBarButtonItem))]
    interface IQTitleBarButtonItem
    {

        // -(instancetype)initWithFrame:(CGRect)frame title:(NSString *)title;
        [Export("initWithFrame:title:")]
        IntPtr Constructor(CGRect frame, string title);

        // @property (nonatomic, strong) UIFont * font;
        [Export("font", ArgumentSemantic.Retain)]
        UIFont Font { get; set; }
    }

    // @interface IQToolbar : UIToolbar <UIInputViewAudioFeedback>
    [BaseType(typeof(UIToolbar))]
    interface IQToolbar : IUIInputViewAudioFeedback
    {

        // @property (nonatomic, strong) UIFont * titleFont;
        [Export("titleFont", ArgumentSemantic.Retain)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) NSString * title;
        [Export("title", ArgumentSemantic.Retain)]
        string Title { get; set; }
    }


	// @interface IQ_UIView_Hierarchy (UIView)
	[Category, BaseType (typeof (UIView))]
	interface IQ_UIView_Hierarchy {

        // @property (readonly, nonatomic) BOOL isAskingCanBecomeFirstResponder;
        [Export("isAskingCanBecomeFirstResponder")]
        bool IsAskingCanBecomeFirstResponder();

        // @property (readonly, nonatomic, strong) UIViewController * viewController;
        [Export("viewController", ArgumentSemantic.Retain)]
        UIViewController ViewController ();

		// @property (readonly, nonatomic, strong) UIViewController * topMostController;
		[Export ("topMostController", ArgumentSemantic.Retain)]
		UIViewController TopMostController ();

		// @property (readonly, nonatomic, strong) UIScrollView * superScrollView;
		[Export ("superScrollView", ArgumentSemantic.Retain)]
		UIScrollView SuperScrollView ();

		// @property (readonly, nonatomic, strong) UITableView * superTableView;
		[Export ("superTableView", ArgumentSemantic.Retain)]
		UITableView SuperTableView ();

		// @property (readonly, nonatomic, strong) UICollectionView * superCollectionView;
		[Introduced(PlatformName.iOS, 6, 0)]
		[Export ("superCollectionView", ArgumentSemantic.Retain)]
		UICollectionView SuperCollectionView ();

		// @property (readonly, copy, nonatomic) NSArray * responderSiblings;
		[Export ("responderSiblings", ArgumentSemantic.Copy)]
		NSObject [] ResponderSiblings ();

		// @property (readonly, copy, nonatomic) NSArray * deepResponderViews;
		[Export ("deepResponderViews", ArgumentSemantic.Copy)]
		NSObject [] DeepResponderViews ();

        // @property (readonly, nonatomic, getter = isSearchBarTextField) BOOL searchBarTextField;
        [Export("isSearchBarTextField")]
        bool IsSearchBarTextField ();

        // @property (readonly, nonatomic, getter = isAlertViewTextField) BOOL alertViewTextField;
        [Export("isAlertViewTextField")]
        bool IsAlertViewTextField ();

		// @property (readonly, copy, nonatomic) NSString * subHierarchy;
		[Export ("subHierarchy")]
		string SubHierarchy ();

		// @property (readonly, copy, nonatomic) NSString * superHierarchy;
		[Export ("superHierarchy")]
		string SuperHierarchy ();

		// @property (readonly, copy, nonatomic) NSString * debugHierarchy;
		[Export ("debugHierarchy")]
		string DebugHierarchy ();

		// -(CGAffineTransform)convertTransformToView:(UIView *)toView;
		[Export ("convertTransformToView:")]
		CGAffineTransform ConvertTransformToView (UIView toView);
	}

	// @interface IQ_UIView_Frame (UIView)
	[Protocol]
	[BaseType (typeof (UIView))]
	interface IQ_UIView_Frame {

		// @property (assign, nonatomic) CGPoint IQ_origin;
		[Export ("IQ_origin", ArgumentSemantic.UnsafeUnretained)]
		CGPoint IQ_origin { get; set; }

		// @property (assign, nonatomic) CGSize IQ_size;
		[Export ("IQ_size", ArgumentSemantic.UnsafeUnretained)]
		CGSize IQ_size { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_x;
		[Export ("IQ_x", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_x { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_y;
		[Export ("IQ_y", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_y { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_width;
		[Export ("IQ_width", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_width { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_height;
		[Export ("IQ_height", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_height { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_left;
		[Export ("IQ_left", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_left { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_right;
		[Export ("IQ_right", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_right { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_top;
		[Export ("IQ_top", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_top { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_bottom;
		[Export ("IQ_bottom", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_bottom { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_centerX;
		[Export ("IQ_centerX", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_centerX { get; set; }

		// @property (assign, nonatomic) CGFloat IQ_centerY;
		[Export ("IQ_centerY", ArgumentSemantic.UnsafeUnretained)]
		nfloat IQ_centerY { get; set; }

		// @property (readonly, nonatomic) CGPoint IQ_boundsCenter;
		[Export ("IQ_boundsCenter")]
		CGPoint IQ_boundsCenter { get; }
	}

	// @interface IQ_Logging (NSObject)
	[Category]
	[BaseType (typeof (NSObject))]
	[Preserve]
	interface IQ_Logging {

		// @property (readonly, copy, nonatomic) NSString * _IQDescription;
		[Export ("_IQDescription")]
		[Preserve]
		string GetIQDescription ();
	}

	// @interface IQToolbarAddition (UIView)
	[Protocol]
	[BaseType (typeof (UIView))]
	interface IQToolbarAddition {

		// @property (assign, nonatomic) BOOL shouldHideTitle;
		[Export ("shouldHideTitle", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldHideTitle { get; set; }

		// @property (nonatomic, strong) NSInvocation * previousInvocation;
		[Export ("previousInvocation", ArgumentSemantic.Retain)]
		NSInvocation PreviousInvocation { get; set; }

		// @property (nonatomic, strong) NSInvocation * nextInvocation;
		[Export ("nextInvocation", ArgumentSemantic.Retain)]
		NSInvocation NextInvocation { get; set; }

		// @property (nonatomic, strong) NSInvocation * doneInvocation;
		[Export ("doneInvocation", ArgumentSemantic.Retain)]
		NSInvocation DoneInvocation { get; set; }

		// -(void)setCustomPreviousTarget:(id)target action:(SEL)action;
		[Export ("setCustomPreviousTarget:action:")]
		void SetCustomPreviousTarget (NSObject target, Selector action);

		// -(void)setCustomNextTarget:(id)target action:(SEL)action;
		[Export ("setCustomNextTarget:action:")]
		void SetCustomNextTarget (NSObject target, Selector action);

		// -(void)setCustomDoneTarget:(id)target action:(SEL)action;
		[Export ("setCustomDoneTarget:action:")]
		void SetCustomDoneTarget (NSObject target, Selector action);

		// -(void)addRightButtonOnKeyboardWithText:(NSString *)text target:(id)target action:(SEL)action;
		[Export ("addRightButtonOnKeyboardWithText:target:action:")]
		void AddRightButtonOnKeyboardWithText (string text, NSObject target, Selector action);

		// -(void)addRightButtonOnKeyboardWithText:(NSString *)text target:(id)target action:(SEL)action shouldShowPlaceholder:(BOOL)showPlaceholder;
		[Export ("addRightButtonOnKeyboardWithText:target:action:shouldShowPlaceholder:")]
		void AddRightButtonOnKeyboardWithText (string text, NSObject target, Selector action, bool showPlaceholder);

		// -(void)addRightButtonOnKeyboardWithText:(NSString *)text target:(id)target action:(SEL)action titleText:(NSString *)titleText;
		[Export ("addRightButtonOnKeyboardWithText:target:action:titleText:")]
		void AddRightButtonOnKeyboardWithText (string text, NSObject target, Selector action, string titleText);

		// -(void)addDoneOnKeyboardWithTarget:(id)target action:(SEL)action;
		[Export ("addDoneOnKeyboardWithTarget:action:")]
		void AddDoneOnKeyboardWithTarget (NSObject target, Selector action);

		// -(void)addDoneOnKeyboardWithTarget:(id)target action:(SEL)action shouldShowPlaceholder:(BOOL)showPlaceholder;
		[Export ("addDoneOnKeyboardWithTarget:action:shouldShowPlaceholder:")]
		void AddDoneOnKeyboardWithTarget (NSObject target, Selector action, bool showPlaceholder);

		// -(void)addDoneOnKeyboardWithTarget:(id)target action:(SEL)action titleText:(NSString *)titleText;
		[Export ("addDoneOnKeyboardWithTarget:action:titleText:")]
		void AddDoneOnKeyboardWithTarget (NSObject target, Selector action, string titleText);

		// -(void)addRightLeftOnKeyboardWithTarget:(id)target leftButtonTitle:(NSString *)leftTitle rightButtonTitle:(NSString *)rightTitle rightButtonAction:(SEL)rightAction leftButtonAction:(SEL)leftAction;
		[Export ("addRightLeftOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:rightButtonAction:leftButtonAction:")]
		void AddRightLeftOnKeyboardWithTarget (NSObject target, string leftTitle, string rightTitle, Selector rightAction, Selector leftAction);

		// -(void)addRightLeftOnKeyboardWithTarget:(id)target leftButtonTitle:(NSString *)leftTitle rightButtonTitle:(NSString *)rightTitle rightButtonAction:(SEL)rightAction leftButtonAction:(SEL)leftAction shouldShowPlaceholder:(BOOL)showPlaceholder;
		[Export ("addRightLeftOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:rightButtonAction:leftButtonAction:shouldShowPlaceholder:")]
		void AddRightLeftOnKeyboardWithTarget (NSObject target, string leftTitle, string rightTitle, Selector rightAction, Selector leftAction, bool showPlaceholder);

		// -(void)addRightLeftOnKeyboardWithTarget:(id)target leftButtonTitle:(NSString *)leftTitle rightButtonTitle:(NSString *)rightTitle rightButtonAction:(SEL)rightAction leftButtonAction:(SEL)leftAction titleText:(NSString *)titleText;
		[Export ("addRightLeftOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:rightButtonAction:leftButtonAction:titleText:")]
		void AddRightLeftOnKeyboardWithTarget (NSObject target, string leftTitle, string rightTitle, Selector rightAction, Selector leftAction, string titleText);

		// -(void)addCancelDoneOnKeyboardWithTarget:(id)target cancelAction:(SEL)cancelAction doneAction:(SEL)doneAction;
		[Export ("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:")]
		void AddCancelDoneOnKeyboardWithTarget (NSObject target, Selector cancelAction, Selector doneAction);

		// -(void)addCancelDoneOnKeyboardWithTarget:(id)target cancelAction:(SEL)cancelAction doneAction:(SEL)doneAction shouldShowPlaceholder:(BOOL)showPlaceholder;
		[Export ("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:shouldShowPlaceholder:")]
		void AddCancelDoneOnKeyboardWithTarget (NSObject target, Selector cancelAction, Selector doneAction, bool showPlaceholder);

		// -(void)addCancelDoneOnKeyboardWithTarget:(id)target cancelAction:(SEL)cancelAction doneAction:(SEL)doneAction titleText:(NSString *)titleText;
		[Export ("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:titleText:")]
		void AddCancelDoneOnKeyboardWithTarget (NSObject target, Selector cancelAction, Selector doneAction, string titleText);

		// -(void)addPreviousNextDoneOnKeyboardWithTarget:(id)target previousAction:(SEL)previousAction nextAction:(SEL)nextAction doneAction:(SEL)doneAction;
		[Export ("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:")]
		void AddPreviousNextDoneOnKeyboardWithTarget (NSObject target, Selector previousAction, Selector nextAction, Selector doneAction);

		// -(void)addPreviousNextDoneOnKeyboardWithTarget:(id)target previousAction:(SEL)previousAction nextAction:(SEL)nextAction doneAction:(SEL)doneAction shouldShowPlaceholder:(BOOL)showPlaceholder;
		[Export ("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:shouldShowPlaceholder:")]
		void AddPreviousNextDoneOnKeyboardWithTarget (NSObject target, Selector previousAction, Selector nextAction, Selector doneAction, bool showPlaceholder);

		// -(void)addPreviousNextDoneOnKeyboardWithTarget:(id)target previousAction:(SEL)previousAction nextAction:(SEL)nextAction doneAction:(SEL)doneAction titleText:(NSString *)titleText;
		[Export ("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:titleText:")]
		void AddPreviousNextDoneOnKeyboardWithTarget (NSObject target, Selector previousAction, Selector nextAction, Selector doneAction, string titleText);

		// -(void)setEnablePrevious:(BOOL)isPreviousEnabled next:(BOOL)isNextEnabled;
		[Export ("setEnablePrevious:next:")]
		void SetEnablePrevious (bool isPreviousEnabled, bool isNextEnabled);
	}

	// @interface IQ_UIWindow_Hierarchy (UIWindow)
	[Category]
	[BaseType (typeof (UIWindow))]
	interface IQ_UIWindow_Hierarchy {

        // @property (readonly, nonatomic, strong) UIViewController * topMostController;
        [Export("topMostController", ArgumentSemantic.Retain)]
        UIViewController TopMostController ();

        // @property (readonly, nonatomic, strong) UIViewController * currentViewController;
        [Export("currentViewController", ArgumentSemantic.Retain)]
        UIViewController CurrentViewController ();
	}
}
