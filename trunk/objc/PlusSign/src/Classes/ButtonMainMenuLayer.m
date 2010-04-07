//
//  ButtonLayer.m
//  plusSign
//
//  Created by Genki-Oki on 8/10/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "ButtonMainMenuLayer.h"


@implementation ButtonMainMenuLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 		
		Button * letsPlayButton = [Button  buttonWithImage:CONSTANT_BUTTONS_LETSPLAY_MENU atPosition:ccp(400,220) target:self selector:@selector(letsPlay:) enablePush:YES];	
		Button * teachMeButton = [Button buttonWithImage:CONSTANT_BUTTONS_TEACHME_MENU atPosition:ccp(-80,155) target:self selector:@selector(teachMe:) enablePush:YES];	
		Button * topScoresButton = [Button buttonWithImage:CONSTANT_BUTTONS_SCOREBOARD_MENU atPosition:ccp(400,90) target:self selector:@selector(topScores:) enablePush:YES];	
		
		[self addChild:letsPlayButton];
		[self addChild:teachMeButton];
		[self addChild:topScoresButton];
		
		[letsPlayButton runAction:[MoveTo actionWithDuration:1 position:ccp(160,[letsPlayButton position].y)]];
		[teachMeButton runAction:[MoveTo actionWithDuration:1 position:ccp(160,[teachMeButton position].y)]];
		[topScoresButton runAction:[MoveTo actionWithDuration:1 position:ccp(160,[topScoresButton position].y)]];
	}
	return self;
}

- (void)letsPlay:(id)sender{
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[GameOptionScene node]]];
}

- (void)teachMe:(id)sender{
	[[Director sharedDirector] replaceScene:[MoveInRTransition transitionWithDuration:0.2 scene:[TeachMeMenuScene node]]];
}

- (void)topScores:(id)sender{
	[[Director sharedDirector] replaceScene:[MoveInRTransition transitionWithDuration:0.2 scene:[ScoreBoardScene node]]];
}
@end
