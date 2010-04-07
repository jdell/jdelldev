//
//  TeachMeMenu.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "TeachMeMenuScene.h"


@implementation TeachMeMenuScene
- (id) init{
	self = [super init];
	if (self != nil){
		BackgroundTeachMeMenuLayer *bgLayer = [[BackgroundTeachMeMenuLayer alloc] init];
		[self addChild:bgLayer z:0];
		[self addChild:[ButtonTeachMeMenuLayer node] z:1];
		
		//Load the background sound
		//[[SimpleAudioEngine sharedEngine] playBackgroundMusic:@"Calculus.caf"];
	}
	
	return self;
}
@end
