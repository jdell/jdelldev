//
//  ControlGameLayer.m
//  plusSign
//
//  Created by Genki-Oki on 11/7/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "ControlGameLayer.h"


@implementation ControlGameLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		Sprite * scoreBlackBox = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_BLACKBOX_1];
		[scoreBlackBox setPosition:ccp(160, 30)];
		[self addChild:scoreBlackBox z:5];
		
		scoreBoard = [[LabelAtlas labelAtlasWithString:@"00000" 
												  charMapFile:CONSTANT_GAMEELEMENTS_PSCHARSET itemWidth:23 itemHeight:41 
										  startCharMap:'.'] retain];
		scoreBoard.position = ccp(160-70-30-30-10, 6);
		[self addChild:scoreBoard z:6];
		
		giveUpBtn = [Sprite spriteWithFile:CONSTANT_BUTTONS_GIVEUP];
		[giveUpBtn setPosition:ccp(160 + 70, 30)];
		[self addChild:giveUpBtn z:5];
				
		Sprite * timeBlackBox = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_BLACKBOX_1];
		[timeBlackBox setPosition:ccp(160, 450)];
		[self addChild:timeBlackBox z:5];
		
		timeBoard = [[LabelAtlas labelAtlasWithString:@"00:00" 
												  charMapFile:CONSTANT_GAMEELEMENTS_PSCHARSET itemWidth:23 itemHeight:41 
										 startCharMap:'.'] retain];
		
		timeBoard.position = ccp(160-70-30-30-10, 450-24);
		[self addChild:timeBoard z:6];
		
		
		
		// Botones +, -, *, /
		int signWidth = 30;
		int separation = 7;
		
		Sprite * plusSign = [Sprite spriteWithFile:CONSTANT_SIGNS_PLUS];
		[plusSign setPosition:ccp(160 + 10, 450)];
		if (!currentState.signPlus) [plusSign setOpacity:120];
		[self addChild:plusSign z:5];
		
		Sprite * minusSign = [Sprite spriteWithFile:CONSTANT_SIGNS_MINUS];
		[minusSign setPosition:ccp(160 + 10 + (separation + signWidth)*1, 450)];
		if (!currentState.signMinus) [minusSign setOpacity:120];
		[self addChild:minusSign z:5];
		
		Sprite * timesSign = [Sprite spriteWithFile:CONSTANT_SIGNS_TIMES];
		[timesSign setPosition:ccp(160 + 10 + (separation + signWidth)*2, 450)];
		if (!currentState.signTimes) [timesSign setOpacity:120];
		[self addChild:timesSign z:5];
		
		Sprite * divisionSign = [Sprite spriteWithFile:CONSTANT_SIGNS_DIVISION];
		[divisionSign setPosition:ccp(160 + 10 + (separation + signWidth)*3, 450)];
		if (!currentState.signDivision) [divisionSign setOpacity:120];
		[self addChild:divisionSign z:5];
		
		[self setIsTouchEnabled:YES];
		[self setEnableLayer:YES];
	}
	return self;
}

- (void)giveUp:(id)sender{
	[[Director sharedDirector] pause];
	
	UIAlertView *alert = [[UIAlertView alloc] 
						  initWithTitle:@"Resuming Game" 
						  message:@"click OK to resume the game" 
						  delegate:self 
						  cancelButtonTitle:@"OK" 
						  otherButtonTitles:nil];
	[alert show];
	
	//[[Director sharedDirector] replaceScene:[FadeTransition transitionWithDuration:1 scene: [MainMenuScene node]]];
}

- (void)setTimeBoard:(int)seconds{
	[timeBoard setString:[[NSString alloc] initWithFormat:@"%02d:%02d", seconds / 60, seconds % 60]];
}

- (void)setScoreBoard:(int)score{
	[scoreBoard setString:[[NSString alloc] initWithFormat:@"%05d", score]];
}


@synthesize enableLayer;

- (BOOL)ccTouchesEnded:(NSSet *)touches withEvent:(UIEvent *)event 
{
	
	if ([self enableLayer])
	{
	
	UITouch *touch = [touches anyObject];
	CGPoint pos = [touch locationInView: [touch view]];
	pos.y = 480 - pos.y;
	
	float w = [giveUpBtn contentSize].width;
	float h = [giveUpBtn contentSize].height;
	//Utilizo 480 como tama;o de la pantalla y porque el sistema de coordenadas esta al reves!
	CGPoint point = CGPointMake([giveUpBtn position].x - (w/2), [giveUpBtn position].y - (h/2));	
	CGRect rect = CGRectMake(point.x, point.y, w, h); 
	
	if (CGRectContainsPoint(rect, pos)) {
		
		givingupLayer = [GivingupGameLayer node];
			[self addChild:givingupLayer z:3];
			[self setEnableLayer:NO];
		//[self setIsTouchEnabled:NO];
	/*	
		[[Director sharedDirector] pause];
		
		UIAlertView *alert = [[UIAlertView alloc] 
							  initWithTitle:@"Giving up" 
							  message:@"Are you sure?" 
							  delegate:self 
							  cancelButtonTitle:@"NO" 
							  otherButtonTitles:nil ];
		[alert addButtonWithTitle:@"YES"];
		[alert show];
		[alert release];
	 */
			//[self setIsTouchEnabled:NO];
		
		return kEventHandled;
			
	} 
	else
		return kEventIgnored;
	}
	else
		return kEventHandled;
		
		
	
}

- (void) alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{	
	[[Director sharedDirector]resume];
	if (buttonIndex==1)
	{
		[[SimpleAudioEngine sharedEngine] stopBackgroundMusic];
		[[Director sharedDirector] replaceScene:[FadeTransition transitionWithDuration:0.2 scene:[MainMenuScene node]]];
	}
}

@end
