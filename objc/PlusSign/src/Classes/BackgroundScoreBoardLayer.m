//
//  BackgroundScoreBoardLayer.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "BackgroundScoreBoardLayer.h"


@implementation BackgroundScoreBoardLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{
		Sprite * bgBlue = [Sprite spriteWithFile:CONSTANT_BACKGROUND_TUTORIAL];
		[bgBlue setPosition:ccp(160, 240)];
		[self addChild:bgBlue z:0];
	}
	return self;
}
@end
