//
//  TeachMeBlocksScene.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "TeachMeBlocksScene.h"


@implementation TeachMeBlocksScene
- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundTeachMeBlocksLayer node] z:0];
		[self addChild:[LogicTeachMeBlocksLayer node] z:1];
	}
	
	return self;
}

- (void) dealloc
{
	[self removeAllChildrenWithCleanup:YES];
	[super dealloc];
}
@end
