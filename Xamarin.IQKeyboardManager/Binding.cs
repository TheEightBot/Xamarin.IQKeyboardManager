using UIKit;
using Foundation;
using ObjCRuntime;
using System;
using CoreGraphics;

namespace Xamarin
{

	// @interface IQKeyboardManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IQKeyboardManager
	{

		// @property (assign, nonatomic, getter = isEnabled) BOOL enable;
		[Export ("enable", ArgumentSemantic.UnsafeUnretained)]
		bool Enable { [Bind ("isEnabled")] get; set; }

		// @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
		[Export ("keyboardDistanceFromTextField", ArgumentSemantic.UnsafeUnretained)]
		nfloat KeyboardDistanceFromTextField { get; set; }

		// @property (assign, nonatomic) BOOL preventShowingBottomBlankSpace;
		[Export ("preventShowingBottomBlankSpace", ArgumentSemantic.UnsafeUnretained)]
		bool PreventShowingBottomBlankSpace { get; set; }

		// @property (assign, nonatomic, getter = isEnableAutoToolbar) BOOL enableAutoToolbar;
		[Export ("enableAutoToolbar", ArgumentSemantic.UnsafeUnretained)]
		bool EnableAutoToolbar { [Bind ("isEnableAutoToolbar")] get; set; }

		// @property (assign, nonatomic) IQAutoToolbarManageBehaviour toolbarManageBehaviour;
		[Export ("toolbarManageBehaviour", ArgumentSemantic.UnsafeUnretained)]
		IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

		// @property (assign, nonatomic) BOOL shouldToolbarUsesTextFieldTintColor;
		[Export ("shouldToolbarUsesTextFieldTintColor", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldToolbarUsesTextFieldTintColor { get; set; }

		// @property (assign, nonatomic) BOOL shouldShowTextFieldPlaceholder;
		[Export ("shouldShowTextFieldPlaceholder", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldShowTextFieldPlaceholder { get; set; }

		// @property (nonatomic, strong) UIFont * placeholderFont;
		[Export ("placeholderFont", ArgumentSemantic.Retain)]
		UIFont PlaceholderFont { get; set; }

		// @property (assign, nonatomic) BOOL canAdjustTextView;
		[Export ("canAdjustTextView", ArgumentSemantic.UnsafeUnretained)]
		bool CanAdjustTextView { get; set; }

		// @property (assign, nonatomic) BOOL shouldFixTextViewClip;
		[Export ("shouldFixTextViewClip", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldFixTextViewClip { get; set; }

		// @property (assign, nonatomic) BOOL overrideKeyboardAppearance;
		[Export ("overrideKeyboardAppearance", ArgumentSemantic.UnsafeUnretained)]
		bool OverrideKeyboardAppearance { get; set; }

		// @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
		[Export ("keyboardAppearance", ArgumentSemantic.UnsafeUnretained)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (assign, nonatomic) BOOL shouldResignOnTouchOutside;
		[Export ("shouldResignOnTouchOutside", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldResignOnTouchOutside { get; set; }

		// @property (readonly, nonatomic) BOOL canGoPrevious;
		[Export ("canGoPrevious")]
		bool CanGoPrevious { get; }

		// @property (readonly, nonatomic) BOOL canGoNext;
		[Export ("canGoNext")]
		bool CanGoNext { get; }

		// @property (assign, nonatomic) BOOL shouldRestoreScrollViewContentOffset;
		[Export ("shouldRestoreScrollViewContentOffset", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldRestoreScrollViewContentOffset { get; set; }

		// @property (assign, nonatomic) BOOL shouldPlayInputClicks;
		[Export ("shouldPlayInputClicks", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldPlayInputClicks { get; set; }

		// @property (assign, nonatomic) BOOL shouldAdoptDefaultKeyboardAnimation;
		[Export ("shouldAdoptDefaultKeyboardAnimation", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldAdoptDefaultKeyboardAnimation { get; set; }

		// @property (assign, nonatomic) BOOL layoutIfNeededOnUpdate;
		[Export ("layoutIfNeededOnUpdate", ArgumentSemantic.UnsafeUnretained)]
		bool LayoutIfNeededOnUpdate { get; set; }

		// +(instancetype)sharedManager;
		[Static, Export ("sharedManager")]
		IQKeyboardManager SharedManager { get; }

		// -(void)resignFirstResponder;
		[Export ("resignFirstResponder")]
		void ResignFirstResponder ();

		// -(void)goPrevious;
		[Export ("goPrevious")]
		void GoPrevious ();

		// -(void)goNext;
		[Export ("goNext")]
		void GoNext ();

		// -(void)disableInViewControllerClass:(Class)disabledClass;
		[Export ("disableInViewControllerClass:")]
		void DisableInViewControllerClass (Class disabledClass);

		// -(void)removeDisableInViewControllerClass:(Class)disabledClass;
		[Export ("removeDisableInViewControllerClass:")]
		void RemoveDisableInViewControllerClass (Class disabledClass);

		// -(BOOL)isDisableInViewControllerClass:(Class)disabledClass;
		[Export ("isDisableInViewControllerClass:")]
		bool IsDisableInViewControllerClass (Class disabledClass);

		// -(void)disableToolbarInViewControllerClass:(Class)toolbarDisabledClass;
		[Export ("disableToolbarInViewControllerClass:")]
		void DisableToolbarInViewControllerClass (Class toolbarDisabledClass);

		// -(void)removeDisableToolbarInViewControllerClass:(Class)toolbarDisabledClass;
		[Export ("removeDisableToolbarInViewControllerClass:")]
		void RemoveDisableToolbarInViewControllerClass (Class toolbarDisabledClass);

		// -(BOOL)isDisableToolbarInViewControllerClass:(Class)toolbarDisabledClass;
		[Export ("isDisableToolbarInViewControllerClass:")]
		bool IsDisableToolbarInViewControllerClass (Class toolbarDisabledClass);

		// -(void)considerToolbarPreviousNextInViewClass:(Class)toolbarPreviousNextConsideredClass;
		[Export ("considerToolbarPreviousNextInViewClass:")]
		void ConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

		// -(void)removeConsiderToolbarPreviousNextInViewClass:(Class)toolbarPreviousNextConsideredClass;
		[Export ("removeConsiderToolbarPreviousNextInViewClass:")]
		void RemoveConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

		// -(BOOL)isConsiderToolbarPreviousNextInViewClass:(Class)toolbarPreviousNextConsideredClass;
		[Export ("isConsiderToolbarPreviousNextInViewClass:")]
		bool IsConsiderToolbarPreviousNextInViewClass (Class toolbarPreviousNextConsideredClass);

		// +(instancetype)new;
		[Availability (Unavailable = Platform.iOS_Version | Platform.Mac_Version)]
		[Static, Export ("new")]
		IQKeyboardManager New ();
	}
}
