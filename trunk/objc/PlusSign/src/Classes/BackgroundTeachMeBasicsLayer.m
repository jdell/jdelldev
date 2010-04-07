//
//  BackgroundTeachMeBasicsLayer.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "BackgroundTeachMeBasicsLayer.h"


@implementation BackgroundTeachMeBasicsLayer
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
