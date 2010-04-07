//
//  GivingupGameLayer.m
//  plusSign
//
//  Created by Genki-Oki on 2/10/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "GivingupGameLayer.h"


@implementation GivingupGameLayer

- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		Sprite * bgBlue = [Sprite spriteWithFile:CONSTANT_POPUP_GIVINGPUP_BOX];
		[bgBlue setPosition:ccp(160, 240)];
		[self addChild:bgBlue z:0];
		
		[self setIsTouchEnabled:YES];
		
		noButton = [Button buttonWithImage:CONSTANT_POPUP_GIVINGPUP_BUTTON_NO atPosition:ccp(160 - bgBlue.contentSize.width/4, 240 - bgBlue.contentSize.height/4) target:self selector:@selector(returnToTheGame:) enablePush:YES];
		[self addChild:noButton z:0];
		
		yeahButton = [Button buttonWithImage:CONSTANT_POPUP_GIVINGPUP_BUTTON_YES atPosition:ccp(160 + bgBlue.contentSize.width/4, 240 - bgBlue.contentSize.height/4) target:self selector:@selector(returnToTheMenu:) enablePush:YES];
		[self addChild:yeahButton z:0];
	}
	return self;
}


- (void) returnToTheGame:(id)sender
{
	ControlGameLayer *lay = [self parent];
	[lay setEnableLayer:YES];
	[lay removeChild:self cleanup:YES];
	
}

- (void) returnToTheMenu:(id)sender
{
	[[SimpleAudioEngine sharedEngine] stopBackgroundMusic];
	[[Director sharedDirector] replaceScene:[FadeTransition transitionWithDuration:0.2 scene:[MainMenuScene node]]];
}


@end
