XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BUILD_DIR=build
BINDING_DIR=binding
PROJECT=Pods/Pods.xcodeproj
TARGET=IQKeyboardManager
BINDING_PROJECT=Xamarin.IQKeyboardManager

all: copyoutput

sharpiebuild:
	sharpie pod init -force ios $(TARGET)
	sharpie pod bind

xbuildbuild: sharpiebuild
	$(XBUILD) ONLY_ACTIVE_ARCH=NO OTHER_CFLAGS="-fembed-bitcode" -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	$(XBUILD) ONLY_ACTIVE_ARCH=NO OTHER_CFLAGS="-fembed-bitcode" -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build

makeafatty: xbuildbuild
	lipo -create -output $(BINDING_DIR)/$(TARGET).framework/$(TARGET) $(BUILD_DIR)/Release-iphoneos/$(TARGET)/$(TARGET).framework/$(TARGET) $(BUILD_DIR)/Release-iphonesimulator/$(TARGET)/$(TARGET).framework/$(TARGET)

copyoutput: makeafatty
	yes | cp -r $(BINDING_DIR)/$(TARGET).framework $(BINDING_PROJECT)

xbuildbuildonly:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO OTHER_CFLAGS="-fembed-bitcode" -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	$(XBUILD) ONLY_ACTIVE_ARCH=NO OTHER_CFLAGS="-fembed-bitcode" -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build

makeafattyonly: xbuildbuildonly
	lipo -create -output $(BINDING_DIR)/$(TARGET).framework/$(TARGET) $(BUILD_DIR)/Release-iphoneos/$(TARGET)/$(TARGET).framework/$(TARGET) $(BUILD_DIR)/Release-iphonesimulator/$(TARGET)/$(TARGET).framework/$(TARGET)

copyoutputonly: makeafattyonly
	yes | cp -r $(BINDING_DIR)/$(TARGET).framework $(BINDING_PROJECT)