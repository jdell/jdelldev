//
//  Button.h
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "SimpleAudioEngine.h"
#import "PSConstants.h"


@interface Button : Menu {
}
+ (id)buttonWithText:(NSString*)text atPosition:(CGPoint)position target:(id)target selector:(SEL)selector;
+ (id)buttonWithImage:(NSString*)file atPosition:(CGPoint)position target:(id)target selector:(SEL)selector;
+ (id)buttonWithText:(NSString*)text atPosition:(CGPoint)position target:(id)target selector:(SEL)selector enablePush:(bool)enablePush;
+ (id)buttonWithImage:(NSString*)file atPosition:(CGPoint)position target:(id)target selector:(SEL)selector enablePush:(bool)enablePush;
+ (void) unCheckAll:(Menu *)menu;
+ (void) checkAll:(Menu *)menu;
+ (BOOL) isSomethingChecked:(Menu *)menu;
- (void) activate;
- (void) deactivate;
@end

@interface ButtonItem : MenuItem {
	Sprite *backPressed;
	bool enablePush;
	bool checked;
	NSString *soundEffect;
}
+ (id)buttonWithText:(NSString*)text target:(id)target selector:(SEL)selector;
+ (id)buttonWithImage:(NSString*)file target:(id)target selector:(SEL)selector;
+ (id)buttonWithImage:(NSString*)file target:(id)target selector:(SEL)selector enablePush:(BOOL)push;
- (id)initWithText:(NSString*)text target:(id)target selector:(SEL)selector;
- (id)initWithImage:(NSString*)file target:(id)target selector:(SEL)selector;
- (id)initWithImage:(NSString*)file target:(id)target selector:(SEL)selector enablePush:(BOOL)push;
- (void)doCheck;
- (void) unCheck;
- (void) Check;
- (Sprite *) getImage;

@property(nonatomic) bool enablePush;
@property(nonatomic) bool checked;
@property(nonatomic) bool soundEffect;
#define WHITEBARPATH CONSTANT_GAMEELEMENTS_WHITEBAR
@end
