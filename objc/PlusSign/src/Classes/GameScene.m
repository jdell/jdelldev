//
//  GameScene.m
//  plusSign
//
//  Created by Genki-Oki on 8/13/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "GameScene.h"


@implementation GameScene
- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundGameLayer node] z:0];
		[self addChild:[GameLayer node] z:2];
		
	}
	
	return self;
}

- (void) dealloc
{
	[self removeAllChildrenWithCleanup:YES];
	[super dealloc];
}

@end
