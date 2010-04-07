//
//  TeachMeScene.m
//  plusSign
//
//  Created by Genki-Oki on 10/17/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "TeachMeMathScene.h"


@implementation TeachMeMathScene
- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundTeachMeMathLayer node] z:0];
		[self addChild:[LogicTeachMeMathLayer node] z:1];
	}
	
	return self;
}

- (void) dealloc
{
	[self removeAllChildrenWithCleanup:YES];
	[super dealloc];
}
@end
