//
//  Button.m
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "Button.h"

#define TAG_IMAGE 1

@implementation Button
+ (id)buttonWithText:(NSString*)text atPosition:(CGPoint)position target:(id)target selector:(SEL)selector {
	Menu *menu = [Menu menuWithItems:[ButtonItem buttonWithText:text target:target selector:selector], nil];
	menu.position = position;
	return menu;
}

+ (id)buttonWithImage:(NSString*)file atPosition:(CGPoint)position target:(id)target selector:(SEL)selector {
	Menu *menu = [Menu menuWithItems:[ButtonItem buttonWithImage:file target:target selector:selector], nil];
	menu.position = position;
	return menu;
}

+ (id)buttonWithText:(NSString*)text atPosition:(CGPoint)position target:(id)target selector:(SEL)selector enablePush:(bool)enablePush{
	
	ButtonItem *button = [ButtonItem buttonWithText:text target:target selector:selector];
	button.enablePush = enablePush;
	Menu *menu = [Menu menuWithItems:button, nil];
	menu.position = position;
	return menu;
}

+ (id)buttonWithImage:(NSString*)file atPosition:(CGPoint)position target:(id)target selector:(SEL)selector enablePush:(bool)enablePush {
	ButtonItem *button = [ButtonItem buttonWithImage:file target:target selector:selector enablePush:enablePush];
	button.enablePush = enablePush;
	Menu *menu = [Menu menuWithItems:button, nil];
	menu.position = position;
	
	return menu;
}

- (void) activate
{
	[Button checkAll:self];
}
- (void) deactivate
{
	[Button unCheckAll:self];
}

+ (void) unCheckAll:(Menu *)menu
{
	NSArray *kids = [menu children];
	for (int i=0; i<[kids count]; i++) {
		ButtonItem *item = [kids objectAtIndex:i];
		[item unCheck];
	}
}

+ (void) checkAll:(Menu *)menu
{
	NSArray *kids = [menu children];
	for (int i=0; i<[kids count]; i++) {
		ButtonItem *item = [kids objectAtIndex:i];
		[item Check];
	}
}
+ (BOOL) isSomethingChecked:(Menu *)menu
{
	NSArray *kids = [menu children];
	for (int i=0; i<[kids count]; i++) {
		ButtonItem *item = [kids objectAtIndex:i];
		if (item.checked) return YES;
	}
	return NO;
}

@end

@implementation ButtonItem
@synthesize enablePush, checked;
@dynamic soundEffect;

+ (id)buttonWithText:(NSString*)text target:(id)target selector:(SEL)selector {
	return [[[self alloc] initWithText:text target:target selector:selector] autorelease];
}

+ (id)buttonWithImage:(NSString*)file target:(id)target selector:(SEL)selector {
	return [[[self alloc] initWithImage:file target:target selector:selector] autorelease];
}
+ (id)buttonWithImage:(NSString*)file target:(id)target selector:(SEL)selector enablePush:(BOOL)push {
	return [[[self alloc] initWithImage:file target:target selector:selector enablePush:push] autorelease];
}

- (id)initWithText:(NSString*)text target:(id)target selector:(SEL)selector {
	if(self = [super initWithTarget:target selector:selector]) {
		backPressed = [[Sprite spriteWithFile:WHITEBARPATH] retain];
		backPressed.anchorPoint = ccp(0,0);

		self.contentSize = backPressed.contentSize;
		
		Label* textLabel = [Label labelWithString:text fontName:@"verdana" fontSize:22];
		textLabel.position = ccp(self.contentSize.width / 2, self.contentSize.height / 2);
		textLabel.anchorPoint = ccp(0.5, 0.3);
		[self addChild:textLabel z:1];
	}
	return self;
}

- (id)initWithImage:(NSString*)file target:(id)target selector:(SEL)selector {
	if(self = [super initWithTarget:target selector:selector]) {
		backPressed = [[Sprite spriteWithFile:file] retain];
		backPressed.anchorPoint = ccp(0,0);
		
		self.contentSize = backPressed.contentSize;
		soundEffect = CONSTANT_SOUNDS_NEWBUTTONSOUND_SOUND1;
		
		Sprite* image = [Sprite spriteWithFile:file];
		[self addChild:image z:1];
		image.position = ccp(self.contentSize.width / 2, self.contentSize.height / 2);
	}
	return self;
}

- (id)initWithImage:(NSString*)file target:(id)target selector:(SEL)selector enablePush:(BOOL)push {
	if(self = [super initWithTarget:target selector:selector]) {
		backPressed = [[Sprite spriteWithFile:file] retain];
		//backPressed = [[Sprite spriteWithFile:WHITEBARPATH] retain];
		backPressed.anchorPoint = ccp(0,0);
		
		
		Sprite* image = [Sprite spriteWithFile:file];
		checked = YES;
		if ((file == CONSTANT_BUTTONS_BACKTOMENU) || (file == CONSTANT_BUTTONS_MENU))
			soundEffect = CONSTANT_SOUNDS_NEWBUTTONSOUND_SOUND2;//CONSTANT_SOUNDS_NEWBUTTONSOUND_SOUND1;
		else
			soundEffect = CONSTANT_SOUNDS_NEWBUTTONSOUND_SOUND1;//CONSTANT_SOUNDS_LOGO_DROP_SOUND;

		if (push)
			self.contentSize = backPressed.contentSize;
		else
			self.contentSize = image.contentSize;
		
		[self addChild:image z:1 tag:TAG_IMAGE];
		image.position = ccp(self.contentSize.width / 2, self.contentSize.height / 2);
		
	}
	return self;
}

- (Sprite *)getImage
{
	return (Sprite *)[self getChildByTag:TAG_IMAGE];
}

- (void) unCheck
{
	checked = YES;
	[self doCheck];
}

- (void) Check
{
	checked = NO;
	[self doCheck];
}

- (void) doCheck
{
	if (([[self parent] visible]) && (self.visible))
	{
		checked = !checked;
		Sprite *image = (Sprite *)[self getChildByTag:TAG_IMAGE];
		if (image)
		{
			[image setOpacity:checked?255:128];
		}
	}
}

-(void) selected {
	if (checked) 
	{
		[[SimpleAudioEngine sharedEngine] playEffect:soundEffect];

	//if (enablePush)	
	//{
		Sprite *image = (Sprite *)[self getChildByTag:TAG_IMAGE];
		if (image) [image setOpacity:128];
		//[self addChild:backPressed];
	//}
	}
	[super selected];
}

-(void) unselected {
	if (checked) 
	{
	//if (enablePush) 
	//{
		Sprite *image = (Sprite *)[self getChildByTag:TAG_IMAGE];
		if (image) [image setOpacity:255];
		//[self removeChild:backPressed cleanup:NO];
	//}
	}
	[super unselected];
}

// this prevents double taps
- (void)activate {
	[super activate];
	[self setIsEnabled:NO];
	[self schedule:@selector(resetButton:) interval:0.5];
}

- (void)resetButton:(ccTime)dt {
	[self unschedule:@selector(resetButton:)];
	[self setIsEnabled:YES];
}

- (void)dealloc {
	//[back release];
	[backPressed release];
	[super dealloc];
}
@end
