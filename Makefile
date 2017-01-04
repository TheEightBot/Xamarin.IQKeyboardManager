XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BUILD_DIR=build
BINDING_DIR=Binding
PROJECT=Pods/Pods.xcodeproj
TARGET=IQKeyboardManager
BINDING_PROJECT=Xamarin.IQKeyboardManager

all: copyoutput

sharpiebuild:
	sharpie pod init ios $(TARGET)
	sharpie pod bind

xbuildbuild: sharpiebuild
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build

makeafatty: xbuildbuild
	lipo -create -output $(BINDING_DIR)/$(TARGET).framework/$(TARGET) $(BUILD_DIR)/Release-iphoneos/$(TARGET)/$(TARGET).framework/$(TARGET) $(BUILD_DIR)/Release-iphonesimulator/$(TARGET)/$(TARGET).framework/$(TARGET)

copyoutput:
	yes | cp $(BINDING_DIR)/$(TARGET).framework $(BINDING_PROJECT)/$(TARGET).framework