//
//  BackgroundEndGameLayer.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "BackgroundEndGameLayer.h"


@implementation BackgroundEndGameLayer

- (id) init{
	self = [super init];
	if (self != nil)
	{
		Sprite * bgBlue = [Sprite spriteWithFile:(currentBackground==nil?CONSTANT_BACKGROUND_GAMEPLAY_SKY:currentBackground)];
		[bgBlue setPosition:ccp(160, 240)];
		[self addChild:bgBlue z:0];
	}
	return self;
}

@end
