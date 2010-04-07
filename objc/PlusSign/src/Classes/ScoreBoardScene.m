//
//  ScoreBoardScene.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "ScoreBoardScene.h"


@implementation ScoreBoardScene

- (id) init{
	self = [super init];
	if (self != nil){
		[self addChild:[BackgroundScoreBoardLayer node] z:0];
		[self addChild:[ButtonScoreBoardLayer node] z:1];
		
	}
	
	return self;
}
@end
