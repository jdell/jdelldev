//
//  TeachMeBasicsScene.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "TeachMeBasicsScene.h"


@implementation TeachMeBasicsScene
- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundTeachMeBasicsLayer node] z:0];
		[self addChild:[LogicTeachMeBasicsLayer node] z:1];
	}
	
	return self;
}

- (void) dealloc
{
	[self removeAllChildrenWithCleanup:YES];
	[super dealloc];
}
@end
