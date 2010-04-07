//
//  ButtonEndGameLayer.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "ButtonEndGameLayer.h"


@implementation ButtonEndGameLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		[self setIsTouchEnabled:YES];
		
		CGPoint positionGabriel = ccp(160,400);
		
		// ****** Gabriel ****** 
		gabrielSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:[currentState isGoalReached]?CONSTANT_WORDBUBBLES_FINISHED:CONSTANT_WORDBUBBLES_YOU_LOST]];
		[gabrielSprite setPosition:positionGabriel];
		[self addChild:gabrielSprite z:5];
				
		gabrielTalking = [Sprite spriteWithFile:CONSTANT_ANIMATION_GABIHEAD_1_SMALL];
		[gabrielTalking setPosition:ccp(160, 240+80)];
		[self addChild:gabrielTalking z:9];	
		
		talking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.33];
		[talking addFrameWithFilename:CONSTANT_ANIMATION_GABIHEAD_1_SMALL];
		[talking addFrameWithFilename:CONSTANT_ANIMATION_GABIHEAD_2_SMALL];
		[talking addFrameWithFilename:CONSTANT_ANIMATION_GABIHEAD_3_SMALL];
		[gabrielTalking addAnimation:talking];

		
		int fontSize = 16;
		CGSize dimensions = CGSizeMake(150, 30);
		CGPoint labelPosition = ccp(220, 24);
		
		int positionY = 240;
		int offsetY = 64;
		int indexY = 0;
		
		
		Sprite * timeBlackBox = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_BLACKBOX_1];
		[timeBlackBox setPosition:ccp(160, positionY - (offsetY * indexY++))];
		[self addChild:timeBlackBox z:5];
		
		LabelAtlas *timeBoard = [[LabelAtlas labelAtlasWithString:@"00:00" 
													  charMapFile:CONSTANT_GAMEELEMENTS_PSCHARSET itemWidth:23 itemHeight:41 
													 startCharMap:'.'] retain];
		
		timeBoard.position = ccp(20, 8);
		[timeBoard setString:[[NSString alloc] initWithFormat:@"%02d:%02d", currentState.time / 60, currentState.time % 60]];
		[timeBlackBox addChild:timeBoard z:6];
		
		Label *timeBoardLabel = [Label labelWithString:@"TOTAL TIME" dimensions:dimensions alignment:UITextAlignmentRight fontName:@"VERDANA" fontSize:fontSize];
		[timeBoardLabel setColor:ccc3(255, 255, 255)];
		[timeBoardLabel setPosition:labelPosition];
		[timeBlackBox addChild:timeBoardLabel];
		
		//*** SCORE
		Sprite * scoreBlackBox = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_BLACKBOX_1];
		[scoreBlackBox setPosition:ccp(160, positionY - (offsetY * indexY++))];
		[self addChild:scoreBlackBox z:5];
		
		LabelAtlas *scoreBoard = [[LabelAtlas labelAtlasWithString:@"00000" 
													  charMapFile:CONSTANT_GAMEELEMENTS_PSCHARSET itemWidth:23 itemHeight:41 
													 startCharMap:'.'] retain];
		
		scoreBoard.position = ccp(20, 8);
		[scoreBoard setString:[[NSString alloc] initWithFormat:@"%05d", currentState.score]];
		[scoreBlackBox addChild:scoreBoard z:6];
		
		Label *scoreBoardLabel = [Label labelWithString:@"TOTAL SCORE" dimensions:dimensions alignment:UITextAlignmentRight  fontName:@"VERDANA" fontSize:fontSize];
		[scoreBoardLabel setColor:ccc3(255, 255, 255)];
		[scoreBoardLabel setPosition:labelPosition];
		[scoreBlackBox addChild:scoreBoardLabel];
	
		
		//*** SIGNS
		Sprite * signsBlackBox = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_BLACKBOX_2];
		[signsBlackBox setPosition:ccp(160, positionY - (offsetY * indexY))];
		[self addChild:signsBlackBox z:5];
		
		Label *signsBoardLabel = [Label labelWithString:@"SIGNS USED" dimensions:dimensions alignment:UITextAlignmentRight  fontName:@"VERDANA" fontSize:fontSize];
		[signsBoardLabel setColor:ccc3(255, 255, 255)];
		[signsBoardLabel setPosition:labelPosition];
		[signsBlackBox addChild:signsBoardLabel];
		
		
		int indexSignsX = 0;
		int offsetSignsX = 40;
		int positionSignsX = 30;
		int positionSignsY = 30;
		
		if (currentState.signPlus)
		{
			Sprite *tmp = [Sprite spriteWithFile:CONSTANT_SIGNS_PLUS];
			[tmp setPosition:ccp(positionSignsX + (offsetSignsX * indexSignsX++), positionSignsY )];
			[signsBlackBox addChild:tmp];
		}
		
		if (currentState.signMinus)
		{
			Sprite *tmp = [Sprite spriteWithFile:CONSTANT_SIGNS_MINUS];
			[tmp setPosition:ccp(positionSignsX + (offsetSignsX * indexSignsX++), positionSignsY )];
			[signsBlackBox addChild:tmp];
		}
		
		if (currentState.signTimes)
		{
			Sprite *tmp = [Sprite spriteWithFile:CONSTANT_SIGNS_TIMES];
			[tmp setPosition:ccp(positionSignsX + (offsetSignsX * indexSignsX++), positionSignsY )];
			[signsBlackBox addChild:tmp];
		}
		
		if (currentState.signDivision)
		{
			Sprite *tmp = [Sprite spriteWithFile:CONSTANT_SIGNS_DIVISION];
			[tmp setPosition:ccp(positionSignsX + (offsetSignsX * indexSignsX++), positionSignsY )];
			[signsBlackBox addChild:tmp];
		}
		
		
		doneButton = [Button  buttonWithImage:CONSTANT_BUTTONS_DONE atPosition:ccp(160, 50) target:self selector:@selector(goToMainMenu:) enablePush:NO];	
		[self addChild:doneButton];
		
		
		
		[gabrielTalking runAction: [Spawn actions:
									[Animate actionWithAnimation:talking],
									[CallFunc actionWithTarget:self selector:@selector(doSound)],
									nil
									]
		 ];
	}
	return self;
}

- (void) doSound
{
	[[SimpleAudioEngine sharedEngine] playEffect:[currentState isGoalReached]?CONSTANT_VOICE_FINISHED:CONSTANT_VOICE_YOU_LOST];
}
- (void)goToMainMenu:(id)sender
{
	if ([currentState isGoalReached])
	{
		PSData *savedData = [PSData initPSData:currentState.mode];
		[savedData loadData];
		
		if (currentState.score>=savedData.score)
			[currentState saveData];
	}
	[[SimpleAudioEngine sharedEngine] stopBackgroundMusic];	
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[MainMenuScene node]]];
}

@end
