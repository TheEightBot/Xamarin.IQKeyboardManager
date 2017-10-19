using UIKit;
using Foundation;
using ObjCRuntime;
using System;
using CoreGraphics;

namespace Xamarin
{
    // @interface IQKeyboardManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface IQKeyboardManager
    {
        // +(instancetype _Nonnull)sharedManager;
        [Static]
        [Export("sharedManager")]
        IQKeyboardManager SharedManager { get; }

        // @property (getter = isEnabled, assign, nonatomic) BOOL enable;
        [Export("enable")]
        bool Enable { [Bind("isEnabled")] get; set; }

        // @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
        [Export("keyboardDistanceFromTextField")]
        nfloat KeyboardDistanceFromTextField { get; set; }

        // @property (assign, nonatomic) BOOL preventShowingBottomBlankSpace;
        [Export("preventShowingBottomBlankSpace")]
        bool PreventShowingBottomBlankSpace { get; set; }

        // -(void)reloadLayoutIfNeeded;
        [Export("reloadLayoutIfNeeded")]
        void ReloadLayoutIfNeeded();

        // @property (readonly, getter = isKeyboardShowing, assign, nonatomic) BOOL keyboardShowing;
        [Export("keyboardShowing")]
        bool KeyboardShowing { [Bind("isKeyboardShowing")] get; }

        // @property (readonly, assign, nonatomic) CGFloat movedDistance;
        [Export("movedDistance")]
        nfloat MovedDistance { get; }

        // @property (getter = isEnableAutoToolbar, assign, nonatomic) BOOL enableAutoToolbar;
        [Export("enableAutoToolbar")]
        bool EnableAutoToolbar { [Bind("isEnableAutoToolbar")] get; set; }

        // @property (assign, nonatomic) IQAutoToolbarManageBehaviour toolbarManageBehaviour;
        [Export("toolbarManageBehaviour", ArgumentSemantic.Assign)]
        IQAutoToolbarManageBehaviour ToolbarManageBehaviour { get; set; }

        // @property (assign, nonatomic) BOOL shouldToolbarUsesTextFieldTintColor;
        [Export("shouldToolbarUsesTextFieldTintColor")]
        bool ShouldToolbarUsesTextFieldTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolbarTintColor;
        [NullAllowed, Export("toolbarTintColor", ArgumentSemantic.Strong)]
        UIColor ToolbarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolbarBarTintColor;
        [NullAllowed, Export("toolbarBarTintColor", ArgumentSemantic.Strong)]
        UIColor ToolbarBarTintColor { get; set; }

        // @property (assign, nonatomic) IQPreviousNextDisplayMode previousNextDisplayMode;
        [Export("previousNextDisplayMode", ArgumentSemantic.Assign)]
        IQPreviousNextDisplayMode PreviousNextDisplayMode { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable toolbarDoneBarButtonItemImage;
        [NullAllowed, Export("toolbarDoneBarButtonItemImage", ArgumentSemantic.Strong)]
        UIImage ToolbarDoneBarButtonItemImage { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable toolbarDoneBarButtonItemText;
        [NullAllowed, Export("toolbarDoneBarButtonItemText", ArgumentSemantic.Strong)]
        string ToolbarDoneBarButtonItemText { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowTextFieldPlaceholder;
        [Export("shouldShowTextFieldPlaceholder")]
        bool ShouldShowTextFieldPlaceholder { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowTextFieldPlaceholder __attribute__((deprecated("This is renamed to `shouldShowToolbarPlaceholder` for more clear naming.")));
        [Export("shouldShowToolbarPlaceholder")]
        bool ShouldShowToolbarPlaceholder { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable placeholderFont;
        [NullAllowed, Export("placeholderFont", ArgumentSemantic.Strong)]
        UIFont PlaceholderFont { get; set; }

        // -(void)reloadInputViews;
        [Export("reloadInputViews")]
        void ReloadInputViews();

        // @property (assign, nonatomic) BOOL overrideKeyboardAppearance;
        [Export("overrideKeyboardAppearance")]
        bool OverrideKeyboardAppearance { get; set; }

        // @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
        [Export("keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (assign, nonatomic) BOOL shouldResignOnTouchOutside;
        [Export("shouldResignOnTouchOutside")]
        bool ShouldResignOnTouchOutside { get; set; }

        // @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nonnull resignFirstResponderGesture;
        [Export("resignFirstResponderGesture", ArgumentSemantic.Strong)]
        UITapGestureRecognizer ResignFirstResponderGesture { get; }

        // -(BOOL)resignFirstResponder;
        [Export("resignFirstResponder")]
        bool ResignFirstResponder();

        // @property (readonly, nonatomic) BOOL canGoPrevious;
        [Export("canGoPrevious")]
        bool CanGoPrevious { get; }

        // @property (readonly, nonatomic) BOOL canGoNext;
        [Export("canGoNext")]
        bool CanGoNext { get; }

        // -(BOOL)goPrevious;
        [Export("goPrevious")]
        bool GoPrevious();

        // -(BOOL)goNext;
        [Export("goNext")]
        bool GoNext();

        // @property (assign, nonatomic) BOOL shouldPlayInputClicks;
        [Export("shouldPlayInputClicks")]
        bool ShouldPlayInputClicks { get; set; }

        // @property (assign, nonatomic) BOOL layoutIfNeededOnUpdate;
        [Export("layoutIfNeededOnUpdate")]
        bool LayoutIfNeededOnUpdate { get; set; }

        // @property (assign, nonatomic) BOOL shouldFixInteractivePopGestureRecognizer;
        [Export("shouldFixInteractivePopGestureRecognizer")]
        bool ShouldFixInteractivePopGestureRecognizer { get; set; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledDistanceHandlingClasses;
        [Export("disabledDistanceHandlingClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> DisabledDistanceHandlingClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledDistanceHandlingClasses;
        [Export("enabledDistanceHandlingClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> EnabledDistanceHandlingClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledToolbarClasses;
        [Export("disabledToolbarClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> DisabledToolbarClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledToolbarClasses;
        [Export("enabledToolbarClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> EnabledToolbarClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull toolbarPreviousNextAllowedClasses;
        [Export("toolbarPreviousNextAllowedClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> ToolbarPreviousNextAllowedClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull disabledTouchResignedClasses;
        [Export("disabledTouchResignedClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> DisabledTouchResignedClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull enabledTouchResignedClasses;
        [Export("enabledTouchResignedClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> EnabledTouchResignedClasses { get; }

        // @property (readonly, nonatomic, strong) NSMutableSet<Class> * _Nonnull touchResignedGestureIgnoreClasses;
        [Export("touchResignedGestureIgnoreClasses", ArgumentSemantic.Strong)]
        NSMutableSet<Class> TouchResignedGestureIgnoreClasses { get; }

        // -(void)registerTextFieldViewClass:(Class _Nonnull)aClass didBeginEditingNotificationName:(NSString * _Nonnull)didBeginEditingNotificationName didEndEditingNotificationName:(NSString * _Nonnull)didEndEditingNotificationName;
        [Export("registerTextFieldViewClass:didBeginEditingNotificationName:didEndEditingNotificationName:")]
        void RegisterTextFieldViewClass(Class aClass, string didBeginEditingNotificationName, string didEndEditingNotificationName);

        // -(void)unregisterTextFieldViewClass:(Class _Nonnull)aClass didBeginEditingNotificationName:(NSString * _Nonnull)didBeginEditingNotificationName didEndEditingNotificationName:(NSString * _Nonnull)didEndEditingNotificationName;
        [Export("unregisterTextFieldViewClass:didBeginEditingNotificationName:didEndEditingNotificationName:")]
        void UnregisterTextFieldViewClass(Class aClass, string didBeginEditingNotificationName, string didEndEditingNotificationName);

        // @property (assign, nonatomic) BOOL enableDebugging;
        [Export("enableDebugging")]
        bool EnableDebugging { get; set; }

        // -(void)registerAllNotifications;
        [Export("registerAllNotifications")]
        void RegisterAllNotifications();

        // -(void)unregisterAllNotifications;
        [Export("unregisterAllNotifications")]
        void UnregisterAllNotifications();
    }

    // @interface IQKeyboardReturnKeyHandler : NSObject
    [BaseType(typeof(NSObject))]
    interface IQKeyboardReturnKeyHandler
    {
        // -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nullable)controller __attribute__((objc_designated_initializer));
        [Export("initWithViewController:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] UIViewController controller);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @property (nonatomic, weak) id<UITextFieldDelegate,UITextViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) UIReturnKeyType lastTextFieldReturnKeyType;
        [Export("lastTextFieldReturnKeyType", ArgumentSemantic.Assign)]
        UIReturnKeyType LastTextFieldReturnKeyType { get; set; }

        // -(void)addTextFieldView:(UIView * _Nonnull)textFieldView;
        [Export("addTextFieldView:")]
        void AddTextFieldView(UIView textFieldView);

        // -(void)removeTextFieldView:(UIView * _Nonnull)textFieldView;
        [Export("removeTextFieldView:")]
        void RemoveTextFieldView(UIView textFieldView);

        // -(void)addResponderFromView:(UIView * _Nonnull)view;
        [Export("addResponderFromView:")]
        void AddResponderFromView(UIView view);

        // -(void)removeResponderFromView:(UIView * _Nonnull)view;
        [Export("removeResponderFromView:")]
        void RemoveResponderFromView(UIView view);
    }

    // @interface Additions (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_Additions
    {
        // @property (assign, nonatomic) BOOL shouldRestoreScrollViewContentOffset;
        [Export("shouldRestoreScrollViewContentOffset")]
        bool ShouldRestoreScrollViewContentOffset();

        [Export("setShouldRestoreScrollViewContentOffset:")]
        void SetShouldRestoreScrollViewContentOffset(bool shouldRestoreScrollViewContentOffset);
    }

    // @interface Additions (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_Additions
    {
        // @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
        [Export("keyboardDistanceFromTextField")]
        nfloat KeyboardDistanceFromTextField();

        [Export("setKeyboardDistanceFromTextField:")]
        nfloat SetKeyboardDistanceFromTextField(nfloat keyboardDistanceFromTextField);

        // @property (assign, nonatomic) BOOL ignoreSwitchingByNextPrevious;
        [Export("ignoreSwitchingByNextPrevious")]
        bool IgnoreSwitchingByNextPrevious();

        [Export("setKeyboardDistanceFromTextField:")]
        bool SetIgnoreSwitchingByNextPrevious(bool ignoreSwitchingByNextPrevious);
    }

    // @interface IQ_UIView_Hierarchy (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_IQ_UIView_Hierarchy
    {
        // @property (readonly, nonatomic, strong) UIViewController * _Nullable viewController;
        [NullAllowed, Export("viewController", ArgumentSemantic.Strong)]
        UIViewController ViewController();

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
        [NullAllowed, Export("topMostController", ArgumentSemantic.Strong)]
        UIViewController TopMostController();

        // -(UIView * _Nullable)superviewOfClassType:(Class _Nonnull)classType;
        [Export("superviewOfClassType:")]
        [return: NullAllowed]
        UIView SuperviewOfClassType(Class classType);

        // @property (readonly, copy, nonatomic) NSArray * _Nonnull responderSiblings;
        [Export("responderSiblings", ArgumentSemantic.Copy)]
        NSObject[] ResponderSiblings();

        // @property (readonly, copy, nonatomic) NSArray * _Nonnull deepResponderViews;
        [Export("deepResponderViews", ArgumentSemantic.Copy)]
        NSObject[] DeepResponderViews();

        // @property (readonly, getter = isSearchBarTextField, nonatomic) BOOL searchBarTextField;
        [Export("isSearchBarTextField")]
        bool IsSearchBarTextField();

        // @property (readonly, getter = isAlertViewTextField, nonatomic) BOOL alertViewTextField;
        [Export("isAlertViewTextField")]
        bool IsAlertViewTextField();

        // -(CGAffineTransform)convertTransformToView:(UIView * _Nullable)toView;
        [Export("convertTransformToView:")]
        CGAffineTransform ConvertTransformToView([NullAllowed] UIView toView);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subHierarchy;
        [Export("subHierarchy")]
        string SubHierarchy();

        // @property (readonly, copy, nonatomic) NSString * _Nonnull superHierarchy;
        [Export("superHierarchy")]
        string SuperHierarchy();

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugHierarchy;
        [Export("debugHierarchy")]
        string DebugHierarchy();
    }

    // @interface IQ_Logging (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    [Preserve]
    interface IQ_Logging
    {

        // @property (readonly, copy, nonatomic) NSString * _IQDescription;
        [Export("_IQDescription")]
        [Preserve]
        string GetIQDescription();
    }

    // @interface Additions (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_Additions
    {
        // @property (nonatomic, strong) NSLayoutConstraint * _Nullable IQLayoutGuideConstraint __attribute__((iboutlet));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Deprecated(PlatformName.iOS, 11, 0)]
        [NullAllowed, Export("IQLayoutGuideConstraint")]
        NSLayoutConstraint IQLayoutGuideConstraint();

        [Introduced(PlatformName.iOS, 8, 0)]
        [Deprecated(PlatformName.iOS, 11, 0)]
        [NullAllowed, Export("setIQLayoutGuideConstraint:")]
        void IQLayoutGuideConstraint(NSLayoutConstraint IQLayoutGuideConstraint);
    }

    // @interface IQ_UIWindow_Hierarchy (UIWindow)
    [Category]
    [BaseType(typeof(UIWindow))]
    interface UIWindow_IQ_UIWindow_Hierarchy
    {
        // @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
        [NullAllowed, Export("topMostController", ArgumentSemantic.Strong)]
        UIViewController TopMostController();

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable currentViewController;
        [NullAllowed, Export("currentViewController", ArgumentSemantic.Strong)]
        UIViewController CurrentViewController();
    }

    // @interface IQTextView : UITextView
    [BaseType(typeof(UITextView))]
    interface IQTextView
    {
        // @property (copy, nonatomic) NSString * _Nullable placeholder;
        [NullAllowed, Export("placeholder")]
        string Placeholder { get; set; }
    }

    // @interface IQBarButtonItem : UIBarButtonItem
    [BaseType(typeof(UIBarButtonItem))]
    interface IQBarButtonItem
    {
        // @property (readonly, nonatomic) BOOL isSystemItem;
        [Export("isSystemItem")]
        bool IsSystemItem { get; }

        // -(void)setTarget:(id _Nullable)target action:(SEL _Nullable)action;
        [Export("setTarget:action:")]
        void SetTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

        // @property (nonatomic, strong) NSInvocation * _Nullable invocation;
        [NullAllowed, Export("invocation", ArgumentSemantic.Strong)]
        NSInvocation Invocation { get; set; }
    }

    // @interface IQPreviousNextView : UIView
    [BaseType(typeof(UIView))]
    interface IQPreviousNextView
    {
    }

    // @interface IQTitleBarButtonItem : IQBarButtonItem
    [BaseType(typeof(IQBarButtonItem))]
    [DisableDefaultCtor]
    interface IQTitleBarButtonItem
    {
        // @property (nonatomic, strong) UIFont * _Nullable titleFont;
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable selectableTextColor;
        [NullAllowed, Export("selectableTextColor", ArgumentSemantic.Strong)]
        UIColor SelectableTextColor { get; set; }

        // -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title __attribute__((objc_designated_initializer));
        [Export("initWithTitle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string title);
    }

    // @interface IQToolbar : UIToolbar <UIInputViewAudioFeedback>
    [BaseType(typeof(UIToolbar))]
    interface IQToolbar : IUIInputViewAudioFeedback
    {
        // @property (nonatomic, strong) IQBarButtonItem * _Nonnull previousBarButton;
        [Export("previousBarButton", ArgumentSemantic.Strong)]
        IQBarButtonItem PreviousBarButton { get; set; }

        // @property (nonatomic, strong) IQBarButtonItem * _Nonnull nextBarButton;
        [Export("nextBarButton", ArgumentSemantic.Strong)]
        IQBarButtonItem NextBarButton { get; set; }

        // @property (readonly, nonatomic, strong) IQTitleBarButtonItem * _Nonnull titleBarButton;
        [Export("titleBarButton", ArgumentSemantic.Strong)]
        IQTitleBarButtonItem TitleBarButton { get; }

        // @property (nonatomic, strong) IQBarButtonItem * _Nonnull doneBarButton;
        [Export("doneBarButton", ArgumentSemantic.Strong)]
        IQBarButtonItem DoneBarButton { get; set; }
    }

    // @interface IQToolbarAddition (UIView)
    [Protocol]
    [BaseType(typeof(UIView))]
    interface UIView_IQToolbarAddition
    {
        // @property (readonly, nonatomic) IQToolbar * _Nonnull keyboardToolbar;
        [Export("keyboardToolbar")]
        IQToolbar KeyboardToolbar { get; }

        // @property (assign, nonatomic) BOOL shouldHideToolbarPlaceholder;
        [Export("shouldHideToolbarPlaceholder")]
        bool ShouldHideToolbarPlaceholder { get; set; }

        // @property (assign, nonatomic) BOOL shouldHidePlaceholderText;
        [Export("shouldHidePlaceholderText")]
        bool ShouldHidePlaceholderText { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable toolbarPlaceholder;
        [NullAllowed, Export("toolbarPlaceholder", ArgumentSemantic.Strong)]
        string ToolbarPlaceholder { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable placeholderText;
        [NullAllowed, Export("placeholderText", ArgumentSemantic.Strong)]
        string PlaceholderText { get; set; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable drawingToolbarPlaceholder;
        [NullAllowed, Export("drawingToolbarPlaceholder", ArgumentSemantic.Strong)]
        string DrawingToolbarPlaceholder { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable drawingPlaceholderText;
        [NullAllowed, Export("drawingPlaceholderText", ArgumentSemantic.Strong)]
        string DrawingPlaceholderText { get; }

        // -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action;
        [Export("addDoneOnKeyboardWithTarget:action:")]
        void AddDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

        // -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
        [Export("addDoneOnKeyboardWithTarget:action:titleText:")]
        void AddDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

        // -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addDoneOnKeyboardWithTarget:action:shouldShowPlaceholder:")]
        void AddDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

        // -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action;
        [Export("addRightButtonOnKeyboardWithText:target:action:")]
        void AddRightButtonOnKeyboardWithText([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
        [Export("addRightButtonOnKeyboardWithText:target:action:titleText:")]
        void AddRightButtonOnKeyboardWithText([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

        // -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addRightButtonOnKeyboardWithText:target:action:shouldShowPlaceholder:")]
        void AddRightButtonOnKeyboardWithText([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

        // -(void)addRightButtonOnKeyboardWithImage:(UIImage * _Nullable)image target:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addRightButtonOnKeyboardWithImage:target:action:shouldShowPlaceholder:")]
        void AddRightButtonOnKeyboardWithImage([NullAllowed] UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

        // -(void)addRightButtonOnKeyboardWithImage:(UIImage * _Nullable)image target:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
        [Export("addRightButtonOnKeyboardWithImage:target:action:titleText:")]
        void AddRightButtonOnKeyboardWithImage([NullAllowed] UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

        // -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction;
        [Export("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:")]
        void AddCancelDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction);

        // -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction titleText:(NSString * _Nullable)titleText;
        [Export("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:titleText:")]
        void AddCancelDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction, [NullAllowed] string titleText);

        // -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:shouldShowPlaceholder:")]
        void AddCancelDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction, bool shouldShowPlaceholder);

        // -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction;
        [Export("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:")]
        void AddLeftRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction);

        // -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
        [Export("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:titleText:")]
        void AddLeftRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

        // -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:shouldShowPlaceholder:")]
        void AddLeftRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

        // -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction;
        [Export("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:")]
        void AddPreviousNextDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction);

        // -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction titleText:(NSString * _Nullable)titleText;
        [Export("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:titleText:")]
        void AddPreviousNextDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction, [NullAllowed] string titleText);

        // -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:shouldShowPlaceholder:")]
        void AddPreviousNextDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction, bool shouldShowPlaceholder);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:titleText:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:shouldShowPlaceholder:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonImage:(UIImage * _Nullable)rightButtonImage previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonImage:previousAction:nextAction:rightButtonAction:titleText:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] UIImage rightButtonImage, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonImage:(UIImage * _Nullable)rightButtonImage previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonImage:previousAction:nextAction:rightButtonAction:shouldShowPlaceholder:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] UIImage rightButtonImage, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);
    }
}
