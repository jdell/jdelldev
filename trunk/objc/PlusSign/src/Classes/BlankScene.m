//
//  BlankScene.m
//  plusSign
//
//  Created by Genki-Oki on 10/17/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "BlankScene.h"


@implementation BlankScene

- (id) init{
	self = [super init];
	if (self != nil){
		// ****** White Background ****** 
		[self addChild:[ColorLayer layerWithColor:ccc4(255,255,255,255)] z:0];
	}
	
	return self;
}
@end
