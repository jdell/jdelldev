//
//  MenuScene.m
//  plusSign
//
//  Created by Genki-Oki on 8/10/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "MainMenuScene.h"


@implementation MainMenuScene


- (id) init{
	self = [super init];
	if (self != nil){
		BackgroundMainMenuLayer *bgLayer = [[BackgroundMainMenuLayer alloc] init];
		[self addChild:bgLayer z:0];
		[self addChild:[ButtonMainMenuLayer node] z:1];
		
		//Load the background sound		
		SimpleAudioEngine *sae = [SimpleAudioEngine sharedEngine];
		if (sae != nil)
		{
			if (![sae isBackgroundMusicPlaying]) [sae playBackgroundMusic:CONSTANT_MUSIC_MAINMENU];
		}
	}
	
	return self;
}


@end
