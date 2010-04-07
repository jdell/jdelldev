//
//  ButtonTeachMeMenuLayer.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "ButtonTeachMeMenuLayer.h"


@implementation ButtonTeachMeMenuLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		CGPoint positionGabriel = ccp(250,430);
		CGPoint positionWordBubble = ccp(160,390);
		CGPoint positionWords = ccp(130,370);
		
		// ****** Gabriel ****** 
		Sprite *gabrielSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_1_SMALL]];
		
		//create an Animation object to hold the frame for the walk cycle
		Animation *gabrielTalking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.10];
		
		//Add each frame to the animation
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_1_SMALL]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_2_SMALL]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_3_SMALL]];
		
		//Add the animation to the sprite so it can access it's frames
		[gabrielSprite addAnimation:gabrielTalking];	
		
		[gabrielSprite setPosition:positionGabriel];
		[self addChild:gabrielSprite z:5];
		
		// ****** Word bubble ******
		Sprite *wordBubble = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_WORDBUBBLES_WORDBUBBLE_2]];
		[wordBubble setPosition:positionWordBubble];
		[self addChild:wordBubble z:4];
		
		
		// ****** Words ******
		//Ready to play\nMath with me?\nLet's Go!!!
		Label *words = [Label labelWithString:NSLocalizedString(@"", @"") dimensions:CGSizeMake(200, 100) alignment:UITextAlignmentLeft fontName:@"Verdana" fontSize:20];
		[words setPosition:positionWords];
		[words setColor:ccc3(0,0,0)];
		[self addChild:words z:5];
		
		// ****** Gabriel Talking ****** 
		NSString *text = @"Came here to\nlearn? Go for it!";
		int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
		int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
		id actionTalking = [Spawn actions:
							[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
							[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
							nil];
		[gabrielSprite runAction:actionTalking];
		
		int positionX = 100;
		int positionY = 280;
		int offsetY = 56;
		int index = 0;
		 
		Button * basicsButton = [Button  buttonWithImage:CONSTANT_BUTTONS_BASICTUTORIAL atPosition:ccp(positionX, positionY - (offsetY * index++)) target:self selector:@selector(goToBasicsTutorial:) enablePush:YES];	
		Button * mathButton = [Button buttonWithImage:CONSTANT_BUTTONS_MATHTUTORIAL atPosition:ccp(positionX, positionY - (offsetY * index++)) target:self selector:@selector(goToMathTutorial:) enablePush:YES];	
		Button * blocksButton = [Button buttonWithImage:CONSTANT_BUTTONS_BLOCKSTUTORIAL atPosition:ccp(positionX, positionY - (offsetY * index++)) target:self selector:@selector(goToBlocksTutorial:) enablePush:YES];	
		
		//Button * menuButton = [Button buttonWithImage:CONSTANT_BUTTONS_BACKTOMENU atPosition:ccp(positionX, positionY - (offsetY * index++)) target:self selector:@selector(goToMenu:) enablePush:YES];	
		Button * menuButton = [Button buttonWithImage:CONSTANT_BUTTONS_BACKTOMENU atPosition:ccp(96, 32) target:self selector:@selector(goToMenu:) enablePush:YES];	
				
		[self addChild:basicsButton];
		[self addChild:mathButton];
		[self addChild:blocksButton];
		[self addChild:menuButton];
		
	}
	return self;
}

- (void)goToBasicsTutorial:(id)sender
{
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[TeachMeBasicsScene node]]];
}
- (void)goToMathTutorial:(id)sender
{
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[TeachMeMathScene node]]];
}
- (void)goToBlocksTutorial:(id)sender
{
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[TeachMeBlocksScene node]]];
}
- (void)goToMenu:(id)sender
{
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[MainMenuScene node]]];
}
@end
