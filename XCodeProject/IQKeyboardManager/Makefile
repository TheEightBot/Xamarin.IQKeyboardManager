XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/IQKeyboardManager.xcodeproj
TARGET=IQKeyboardManager

all: libIQKeyboardManager.a

libIQKeyboardManager-i386.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
		-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libIQKeyboardManager-armv7.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build
		-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libIQKeyboardManager.a: libIQKeyboardManager-i386.a libIQKeyboardManager-armv7.a
		lipo -create -output $@ $^

clean:
		-rm -f *.a *.dll
