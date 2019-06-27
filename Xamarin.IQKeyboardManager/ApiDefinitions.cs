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

    // @interface IQTitleBarButtonItem : IQBarButtonItem
    [BaseType(typeof(IQBarButtonItem))]
    [DisableDefaultCtor]
    interface IQTitleBarButtonItem
    {
        // @property (nonatomic, strong) UIFont * _Nullable titleFont;
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleColor;
        [NullAllowed, Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable selectableTitleColor;
        [NullAllowed, Export("selectableTitleColor", ArgumentSemantic.Strong)]
        UIColor SelectableTitleColor { get; set; }

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

        // @property (nonatomic, strong) IQBarButtonItem * _Nonnull fixedSpaceBarButton;
        [Export("fixedSpaceBarButton", ArgumentSemantic.Strong)]
        IQBarButtonItem FixedSpaceBarButton { get; set; }
    }

    // @interface IQBarButtonItemConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface IQBarButtonItemConfiguration
    {
        // -(instancetype _Nonnull)initWithBarButtonSystemItem:(UIBarButtonSystemItem)barButtonSystemItem action:(SEL _Nullable)action;
        [Export("initWithBarButtonSystemItem:action:")]
        IntPtr Constructor(UIBarButtonSystemItem barButtonSystemItem, [NullAllowed] Selector action);

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image action:(SEL _Nullable)action;
        [Export("initWithImage:action:")]
        IntPtr Constructor(UIImage image, [NullAllowed] Selector action);

        // -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title action:(SEL _Nullable)action;
        [Export("initWithTitle:action:")]
        IntPtr Constructor(string title, [NullAllowed] Selector action);

        // @property (readonly, nonatomic) UIBarButtonSystemItem barButtonSystemItem;
        [Export("barButtonSystemItem")]
        UIBarButtonSystemItem BarButtonSystemItem { get; }

        // @property (readonly, nonatomic) UIImage * _Nullable image;
        [NullAllowed, Export("image")]
        UIImage Image { get; }

        // @property (readonly, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) SEL _Nullable action;
        [NullAllowed, Export("action")]
        Selector Action { get; }
    }

    // @interface IQKeyboardToolbarNextPreviousImage (UIImage)
    //[Category]
    //[BaseType(typeof(UIImage))]
    partial interface UIImage
    {
        // +(UIImage * _Nullable)keyboardPreviousiOS9Image;
        [Static]
        [NullAllowed, Export("keyboardPreviousiOS9Image")]
        UIImage KeyboardPreviousiOS9Image { get; }

        // +(UIImage * _Nullable)keyboardNextiOS9Image;
        [Static]
        [NullAllowed, Export("keyboardNextiOS9Image")]
        UIImage KeyboardNextiOS9Image { get; }

        // +(UIImage * _Nullable)keyboardPreviousiOS10Image;
        [Static]
        [NullAllowed, Export("keyboardPreviousiOS10Image")]
        UIImage KeyboardPreviousiOS10Image { get; }

        // +(UIImage * _Nullable)keyboardNextiOS10Image;
        [Static]
        [NullAllowed, Export("keyboardNextiOS10Image")]
        UIImage KeyboardNextiOS10Image { get; }

        // +(UIImage * _Nullable)keyboardPreviousImage;
        [Static]
        [NullAllowed, Export("keyboardPreviousImage")]
        UIImage KeyboardPreviousImage { get; }

        // +(UIImage * _Nullable)keyboardNextImage;
        [Static]
        [NullAllowed, Export("keyboardNextImage")]
        UIImage KeyboardNextImage { get; }
    }

    // @interface IQToolbarAddition (UIView)
    //[Category]
    //[BaseType(typeof(UIView))]
    partial interface UIView
    {
        // @property (readonly, nonatomic) IQToolbar * _Nonnull keyboardToolbar;
        [Export("keyboardToolbar")]
        IQToolbar KeyboardToolbar { get; }

        // @property (assign, nonatomic) BOOL shouldHideToolbarPlaceholder;
        [Export("shouldHideToolbarPlaceholder")]
        bool ShouldHideToolbarPlaceholder { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable toolbarPlaceholder;
        [NullAllowed, Export("toolbarPlaceholder", ArgumentSemantic.Strong)]
        string ToolbarPlaceholder { get; set; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable drawingToolbarPlaceholder;
        [NullAllowed, Export("drawingToolbarPlaceholder", ArgumentSemantic.Strong)]
        string DrawingToolbarPlaceholder { get; }

        // -(void)addKeyboardToolbarWithTarget:(id _Nullable)target titleText:(NSString * _Nullable)titleText rightBarButtonConfiguration:(IQBarButtonItemConfiguration * _Nullable)rightBarButtonConfiguration previousBarButtonConfiguration:(IQBarButtonItemConfiguration * _Nullable)previousBarButtonConfiguration nextBarButtonConfiguration:(IQBarButtonItemConfiguration * _Nullable)nextBarButtonConfiguration;
        [Export("addKeyboardToolbarWithTarget:titleText:rightBarButtonConfiguration:previousBarButtonConfiguration:nextBarButtonConfiguration:")]
        void AddKeyboardToolbarWithTarget([NullAllowed] NSObject target, [NullAllowed] string titleText, [NullAllowed] IQBarButtonItemConfiguration rightBarButtonConfiguration, [NullAllowed] IQBarButtonItemConfiguration previousBarButtonConfiguration, [NullAllowed] IQBarButtonItemConfiguration nextBarButtonConfiguration);

        // -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action;
        [Export("addDoneOnKeyboardWithTarget:action:")]
        void AddDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

        // -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addDoneOnKeyboardWithTarget:action:shouldShowPlaceholder:")]
        void AddDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

        // -(void)addDoneOnKeyboardWithTarget:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
        [Export("addDoneOnKeyboardWithTarget:action:titleText:")]
        void AddDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

        // -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action;
        [Export("addRightButtonOnKeyboardWithText:target:action:")]
        void AddRightButtonOnKeyboardWithText([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addRightButtonOnKeyboardWithText:target:action:shouldShowPlaceholder:")]
        void AddRightButtonOnKeyboardWithText([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

        // -(void)addRightButtonOnKeyboardWithText:(NSString * _Nullable)text target:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
        [Export("addRightButtonOnKeyboardWithText:target:action:titleText:")]
        void AddRightButtonOnKeyboardWithText([NullAllowed] string text, [NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

        // -(void)addRightButtonOnKeyboardWithImage:(UIImage * _Nullable)image target:(id _Nullable)target action:(SEL _Nullable)action;
        [Export("addRightButtonOnKeyboardWithImage:target:action:")]
        void AddRightButtonOnKeyboardWithImage([NullAllowed] UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // -(void)addRightButtonOnKeyboardWithImage:(UIImage * _Nullable)image target:(id _Nullable)target action:(SEL _Nullable)action shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addRightButtonOnKeyboardWithImage:target:action:shouldShowPlaceholder:")]
        void AddRightButtonOnKeyboardWithImage([NullAllowed] UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action, bool shouldShowPlaceholder);

        // -(void)addRightButtonOnKeyboardWithImage:(UIImage * _Nullable)image target:(id _Nullable)target action:(SEL _Nullable)action titleText:(NSString * _Nullable)titleText;
        [Export("addRightButtonOnKeyboardWithImage:target:action:titleText:")]
        void AddRightButtonOnKeyboardWithImage([NullAllowed] UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action, [NullAllowed] string titleText);

        // -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction;
        [Export("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:")]
        void AddCancelDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction);

        // -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:shouldShowPlaceholder:")]
        void AddCancelDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction, bool shouldShowPlaceholder);

        // -(void)addCancelDoneOnKeyboardWithTarget:(id _Nullable)target cancelAction:(SEL _Nullable)cancelAction doneAction:(SEL _Nullable)doneAction titleText:(NSString * _Nullable)titleText;
        [Export("addCancelDoneOnKeyboardWithTarget:cancelAction:doneAction:titleText:")]
        void AddCancelDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector cancelAction, [NullAllowed] Selector doneAction, [NullAllowed] string titleText);

        // -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction;
        [Export("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:")]
        void AddLeftRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction);

        // -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:shouldShowPlaceholder:")]
        void AddLeftRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

        // -(void)addLeftRightOnKeyboardWithTarget:(id _Nullable)target leftButtonTitle:(NSString * _Nullable)leftButtonTitle rightButtonTitle:(NSString * _Nullable)rightButtonTitle leftButtonAction:(SEL _Nullable)leftButtonAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
        [Export("addLeftRightOnKeyboardWithTarget:leftButtonTitle:rightButtonTitle:leftButtonAction:rightButtonAction:titleText:")]
        void AddLeftRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string leftButtonTitle, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector leftButtonAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

        // -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction;
        [Export("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:")]
        void AddPreviousNextDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction);

        // -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:shouldShowPlaceholder:")]
        void AddPreviousNextDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction, bool shouldShowPlaceholder);

        // -(void)addPreviousNextDoneOnKeyboardWithTarget:(id _Nullable)target previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction doneAction:(SEL _Nullable)doneAction titleText:(NSString * _Nullable)titleText;
        [Export("addPreviousNextDoneOnKeyboardWithTarget:previousAction:nextAction:doneAction:titleText:")]
        void AddPreviousNextDoneOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector doneAction, [NullAllowed] string titleText);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:shouldShowPlaceholder:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonTitle:(NSString * _Nullable)rightButtonTitle previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonTitle:previousAction:nextAction:rightButtonAction:titleText:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] string rightButtonTitle, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonImage:(UIImage * _Nullable)rightButtonImage previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonImage:previousAction:nextAction:rightButtonAction:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] UIImage rightButtonImage, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonImage:(UIImage * _Nullable)rightButtonImage previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction shouldShowPlaceholder:(BOOL)shouldShowPlaceholder;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonImage:previousAction:nextAction:rightButtonAction:shouldShowPlaceholder:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] UIImage rightButtonImage, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, bool shouldShowPlaceholder);

        // -(void)addPreviousNextRightOnKeyboardWithTarget:(id _Nullable)target rightButtonImage:(UIImage * _Nullable)rightButtonImage previousAction:(SEL _Nullable)previousAction nextAction:(SEL _Nullable)nextAction rightButtonAction:(SEL _Nullable)rightButtonAction titleText:(NSString * _Nullable)titleText;
        [Export("addPreviousNextRightOnKeyboardWithTarget:rightButtonImage:previousAction:nextAction:rightButtonAction:titleText:")]
        void AddPreviousNextRightOnKeyboardWithTarget([NullAllowed] NSObject target, [NullAllowed] UIImage rightButtonImage, [NullAllowed] Selector previousAction, [NullAllowed] Selector nextAction, [NullAllowed] Selector rightButtonAction, [NullAllowed] string titleText);
    }

    // @interface IQPreviousNextView : UIView
    [BaseType(typeof(UIView))]
    interface IQPreviousNextView
    {
    }

    // @interface Additions (UIViewController)
    //[Category]
    //[BaseType(typeof(UIViewController))]
    partial interface UIViewController
    {
        // @property (nonatomic, strong) NSLayoutConstraint * _Nullable IQLayoutGuideConstraint __attribute__((iboutlet)) __attribute__((deprecated("Due to change in core-logic of handling distance between textField and keyboard distance, this layout contraint tweak is no longer needed and things will just work out of the box regardless of constraint pinned with safeArea/layoutGuide/superview.")));
        [NullAllowed, Export("IQLayoutGuideConstraint", ArgumentSemantic.Strong)]
        NSLayoutConstraint IQLayoutGuideConstraint { get; set; }
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

    // @interface IQTextView : UITextView
    [BaseType(typeof(UITextView))]
    interface IQTextView
    {
        // @property (copy, nonatomic) NSString * _Nullable placeholder;
        [NullAllowed, Export("placeholder")]
        string Placeholder { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable attributedPlaceholder;
        [NullAllowed, Export("attributedPlaceholder", ArgumentSemantic.Copy)]
        NSAttributedString AttributedPlaceholder { get; set; }

        // @property (copy, nonatomic) UIColor * _Nullable placeholderTextColor;
        [NullAllowed, Export("placeholderTextColor", ArgumentSemantic.Copy)]
        UIColor PlaceholderTextColor { get; set; }
    }

    // @interface Additions (UIScrollView)
    //[Category]
    //[BaseType(typeof(UIScrollView))]
    partial interface UIScrollView
    {
        // @property (assign, nonatomic) BOOL shouldIgnoreScrollingAdjustment;
        [Export("shouldIgnoreScrollingAdjustment")]
        bool ShouldIgnoreScrollingAdjustment { get; set; }

        // @property (assign, nonatomic) BOOL shouldRestoreScrollViewContentOffset;
        [Export("shouldRestoreScrollViewContentOffset")]
        bool ShouldRestoreScrollViewContentOffset { get; set; }
    }

    // @interface PreviousNextIndexPath (UITableView)
    //[Category]
    //[BaseType(typeof(UITableView))]
    partial interface UITableView
    {
        // -(NSIndexPath * _Nullable)previousIndexPathOfIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("previousIndexPathOfIndexPath:")]
        [return: NullAllowed]
        NSIndexPath PreviousIndexPathOfIndexPath(NSIndexPath indexPath);
    }

    // @interface PreviousNextIndexPath (UICollectionView)
    //[Category]
    //[BaseType(typeof(UICollectionView))]
    partial interface UICollectionView
    {
        // -(NSIndexPath * _Nullable)previousIndexPathOfIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("previousIndexPathOfIndexPath:")]
        [return: NullAllowed]
        NSIndexPath PreviousIndexPathOfIndexPath(NSIndexPath indexPath);
    }

    // @interface Additions (UIView)
    //[Category]
    //[BaseType(typeof(UIView))]
    partial interface UIView
    {
        // @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
        [Export("keyboardDistanceFromTextField")]
        nfloat KeyboardDistanceFromTextField { get; set; }

        // @property (assign, nonatomic) BOOL ignoreSwitchingByNextPrevious;
        [Export("ignoreSwitchingByNextPrevious")]
        bool IgnoreSwitchingByNextPrevious { get; set; }

        // @property (assign, nonatomic) IQEnableMode shouldResignOnTouchOutsideMode;
        [Export("shouldResignOnTouchOutsideMode", ArgumentSemantic.Assign)]
        IQEnableMode ShouldResignOnTouchOutsideMode { get; set; }
    }

    [Static]
    partial interface Constants
    {
        // extern const CGFloat kIQUseDefaultKeyboardDistance;
        [Field("kIQUseDefaultKeyboardDistance", "__Internal")]
        nfloat kIQUseDefaultKeyboardDistance { get; }

        // extern const NSInteger kIQDoneButtonToolbarTag;
        [Field("kIQDoneButtonToolbarTag", "__Internal")]
        nint kIQDoneButtonToolbarTag { get; }

        // extern const NSInteger kIQPreviousNextButtonToolbarTag;
        [Field("kIQPreviousNextButtonToolbarTag", "__Internal")]
        nint kIQPreviousNextButtonToolbarTag { get; }
    }

    // @interface IQ_UIView_Hierarchy (UIView)
    //[Category]
    //[BaseType(typeof(UIView))]
    partial interface UIView
    {
        // @property (readonly, nonatomic, strong) UIViewController * _Nullable viewContainingController;
        [NullAllowed, Export("viewContainingController", ArgumentSemantic.Strong)]
        UIViewController ViewContainingController { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable topMostController;
        [NullAllowed, Export("topMostController", ArgumentSemantic.Strong)]
        UIViewController TopMostController { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable parentContainerViewController;
        [NullAllowed, Export("parentContainerViewController", ArgumentSemantic.Strong)]
        UIViewController ParentContainerViewController { get; }

        // -(__kindof UIView * _Nullable)superviewOfClassType:(Class _Nonnull)classType belowView:(UIView * _Nullable)belowView;
        [Export("superviewOfClassType:belowView:")]
        UIView SuperviewOfClassType(Class classType, [NullAllowed] UIView belowView);

        // -(__kindof UIView * _Nullable)superviewOfClassType:(Class _Nonnull)classType;
        [Export("superviewOfClassType:")]
        UIView SuperviewOfClassType(Class classType);

        // @property (readonly, copy, nonatomic) NSArray<__kindof UIView *> * _Nonnull responderSiblings;
        [Export("responderSiblings", ArgumentSemantic.Copy)]
        UIView[] ResponderSiblings { get; }

        // @property (readonly, copy, nonatomic) NSArray<__kindof UIView *> * _Nonnull deepResponderViews;
        [Export("deepResponderViews", ArgumentSemantic.Copy)]
        UIView[] DeepResponderViews { get; }

        // @property (readonly, nonatomic) UISearchBar * _Nullable textFieldSearchBar;
        [NullAllowed, Export("textFieldSearchBar")]
        UISearchBar TextFieldSearchBar { get; }

        // @property (readonly, getter = isAlertViewTextField, nonatomic) BOOL alertViewTextField;
        [Export("alertViewTextField")]
        bool AlertViewTextField { [Bind("isAlertViewTextField")] get; }

        // -(CGAffineTransform)convertTransformToView:(UIView * _Nullable)toView;
        [Export("convertTransformToView:")]
        CGAffineTransform ConvertTransformToView([NullAllowed] UIView toView);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subHierarchy;
        [Export("subHierarchy")]
        string SubHierarchy { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull superHierarchy;
        [Export("superHierarchy")]
        string SuperHierarchy { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugHierarchy;
        [Export("debugHierarchy")]
        string DebugHierarchy { get; }
    }

    // @interface IQ_UIView_Hierarchy (UIViewController)
    //[Category]
    //[BaseType(typeof(UIViewController))]
    partial interface UIViewController
    {
        // -(UIViewController * _Nullable)parentIQContainerViewController;
        [NullAllowed, Export("parentIQContainerViewController")]
        UIViewController ParentIQContainerViewController { get; }
    }

    // @interface IQ_Logging (NSObject)
    //[Category]
    //[BaseType(typeof(NSObject))]
    partial interface NSObject
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull _IQDescription;
        [Export("_IQDescription")]
        string _IQDescription { get; }
    }

    // @interface IQKeyboardManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface IQKeyboardManager
    {
        // +(instancetype _Nonnull)sharedManager;
        [Static]
        [Export("sharedManager")]
        IQKeyboardManager SharedManager();

        // @property (getter = isEnabled, assign, nonatomic) BOOL enable;
        [Export("enable")]
        bool Enable { [Bind("isEnabled")] get; set; }

        // @property (assign, nonatomic) CGFloat keyboardDistanceFromTextField;
        [Export("keyboardDistanceFromTextField")]
        nfloat KeyboardDistanceFromTextField { get; set; }

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

        // @property (nonatomic, strong) UIImage * _Nullable toolbarPreviousBarButtonItemImage;
        [NullAllowed, Export("toolbarPreviousBarButtonItemImage", ArgumentSemantic.Strong)]
        UIImage ToolbarPreviousBarButtonItemImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable toolbarNextBarButtonItemImage;
        [NullAllowed, Export("toolbarNextBarButtonItemImage", ArgumentSemantic.Strong)]
        UIImage ToolbarNextBarButtonItemImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable toolbarDoneBarButtonItemImage;
        [NullAllowed, Export("toolbarDoneBarButtonItemImage", ArgumentSemantic.Strong)]
        UIImage ToolbarDoneBarButtonItemImage { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable toolbarPreviousBarButtonItemText;
        [NullAllowed, Export("toolbarPreviousBarButtonItemText", ArgumentSemantic.Strong)]
        string ToolbarPreviousBarButtonItemText { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable toolbarNextBarButtonItemText;
        [NullAllowed, Export("toolbarNextBarButtonItemText", ArgumentSemantic.Strong)]
        string ToolbarNextBarButtonItemText { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable toolbarDoneBarButtonItemText;
        [NullAllowed, Export("toolbarDoneBarButtonItemText", ArgumentSemantic.Strong)]
        string ToolbarDoneBarButtonItemText { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowToolbarPlaceholder;
        [Export("shouldShowToolbarPlaceholder")]
        bool ShouldShowToolbarPlaceholder { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable placeholderFont;
        [NullAllowed, Export("placeholderFont", ArgumentSemantic.Strong)]
        UIFont PlaceholderFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
        [NullAllowed, Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable placeholderButtonColor;
        [NullAllowed, Export("placeholderButtonColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderButtonColor { get; set; }

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
        bool ResignFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL canGoPrevious;
        [Export("canGoPrevious")]
        bool CanGoPrevious { get; }

        // @property (readonly, nonatomic) BOOL canGoNext;
        [Export("canGoNext")]
        bool CanGoNext { get; }

        // -(BOOL)goPrevious;
        [Export("goPrevious")]
        bool GoPrevious { get; }

        // -(BOOL)goNext;
        [Export("goNext")]
        bool GoNext { get; }

        // @property (assign, nonatomic) BOOL shouldPlayInputClicks;
        [Export("shouldPlayInputClicks")]
        bool ShouldPlayInputClicks { get; set; }

        // @property (assign, nonatomic) BOOL layoutIfNeededOnUpdate;
        [Export("layoutIfNeededOnUpdate")]
        bool LayoutIfNeededOnUpdate { get; set; }

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
}
