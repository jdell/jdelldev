//
//  BackgroundGameOptionLayer.m
//  plusSign
//
//  Created by Genki-Oki on 11/8/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "BackgroundGameOptionLayer.h"


@implementation BackgroundGameOptionLayer
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
