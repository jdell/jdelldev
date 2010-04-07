//
//  ScoreFailedScoreBoardLayer.m
//  plusSign
//
//  Created by Genki-Oki on 2/11/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "ScoreFailedScoreBoardLayer.h"


@implementation ScoreFailedScoreBoardLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		Sprite * bgBlue = [Sprite spriteWithFile:CONSTANT_POPUP_SCORE_FAILED_BOX];
		[bgBlue setPosition:ccp(160, 240)];
		[self addChild:bgBlue z:0];
		
		[self setIsTouchEnabled:YES];
		
		button = [Button buttonWithImage:CONSTANT_POPUP_SCORE_FAILED_AWWWW atPosition:ccp(160, 10+240 - bgBlue.contentSize.height/4) target:self selector:@selector(returnToTheScore:) enablePush:YES];
		[self addChild:button z:0];
	}
	return self;
}


- (void) returnToTheScore:(id)sender
{
	ButtonScoreBoardLayer *lay = [self parent];
	[lay setEnableLayer:YES];
	[lay removeChild:self cleanup:YES];
}
@end