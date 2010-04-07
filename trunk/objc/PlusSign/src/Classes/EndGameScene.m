//
//  EndGameScene.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "EndGameScene.h"


@implementation EndGameScene
- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundEndGameLayer node] z:0];
		[self addChild:[ButtonEndGameLayer node] z:1];

	}
	
	return self;
}
@end
