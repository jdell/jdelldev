//
//  GameOptionScene.m
//  plusSign
//
//  Created by Genki-Oki on 11/8/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "GameOptionScene.h"


@implementation GameOptionScene
- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundGameOptionLayer node] z:0];
		[self addChild:[ButtonGameOptionMenuLayer node] z:1];
	}
	
	return self;
}	
@end
