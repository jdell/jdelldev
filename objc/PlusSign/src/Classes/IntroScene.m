//
//  IntroScene.m
//  plusSign
//
//  Created by Genki-Oki on 10/17/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "IntroScene.h"
#import "ParallaxNode.h"

@implementation IntroScene
- (id) init{
	self = [super init];
	if (self != nil){
		
		// ***** Green Grass *****
		Sprite *greenGrassSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_INTROBACKGROUND_1]];
		
		//create an Animation object to hold the frame for the walk cycle
		Animation *greenGrassMoving = [[Animation alloc] initWithName:@"greenGrassMoving" delay:0.3];
		
		//Add each frame to the animation
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_INTROBACKGROUND_1]];
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_INTROBACKGROUND_2]];
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_INTROBACKGROUND_3]];
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_INTROBACKGROUND_2]];
		
		//Add the animation to the sprite so it can access it's frames
		[greenGrassSprite addAnimation:greenGrassMoving];	
		
		//[greenGrassSprite setScale:0.56];
		[greenGrassSprite setPosition:ccp(160,240)];
		[self addChild:greenGrassSprite z:0];
		
		
		// ****** White Background ****** 
		ColorLayer *whiteBGLayer = [ColorLayer layerWithColor:ccc4(255,255,255,255)];
		[self addChild:whiteBGLayer z:1];
		
		
		// ****** Gabriel ****** 
		Sprite *gabrielSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABRIEL_1]];

		//create an Animation object to hold the frame for the walk cycle
		Animation *gabrielTalking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.10];
		
		//Add each frame to the animation
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABRIEL_1]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABRIEL_2]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABRIEL_3]];
				
		//Add the animation to the sprite so it can access it's frames
		[gabrielSprite addAnimation:gabrielTalking];	

		[gabrielSprite setPosition:ccp(160,140)];
		[self addChild:gabrielSprite z:2];
		
		// ****** Gabriel Shadow ****** 
		Sprite *gabrielShadowSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABRIEL_1]];
		[gabrielShadowSprite setColor:ccc3(0,0,0)];
		[gabrielShadowSprite setPosition:ccp(160,140)];
		
		[self addChild:gabrielShadowSprite z:3];
		
		id actionShading = [FadeTo actionWithDuration:0.5 opacity:0];
		[gabrielShadowSprite runAction:actionShading];
		
		
		// ****** Word bubble ******
		Sprite *wordBubble = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_WORDBUBBLES_WORDBUBBLE_4]];
		[wordBubble setPosition:ccp(160,340)];
		[self addChild:wordBubble z:4];
		
		
		// ****** Words ******
		//Ready to play\nMath with me?\nLet's Go!!!
		Label *words = [Label labelWithString:NSLocalizedString(@"", @"") dimensions:CGSizeMake(150, 90) alignment:UITextAlignmentLeft fontName:@"Verdana" fontSize:20];
		[words setColor:ccc3(0,0,0)];
		[words setPosition:ccp(wordBubble.contentSize.width/2, wordBubble.contentSize.height/2+16)];
		[wordBubble addChild:words z:0];
		
		
		// ****** Gabriel Talking ****** 
		NSString *text =@"Ready to play\nMath with me?\nLet's Go!!!";
		int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
		int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
		id actionTalking = [Spawn actions:
							[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
							[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
							nil];
		[gabrielSprite runAction:actionTalking];
		

		// ***** FadeOut Background *****
		[whiteBGLayer runAction:  [FadeTo actionWithDuration:0.5 opacity:0]];
		
		// ****** Grass Moving ******
		[greenGrassSprite runAction: [RepeatForever actionWithAction:[Animate actionWithAnimation:greenGrassMoving ]]];
		//[greenGrassSprite runAction:[FadeTo 
		
		
		// ****** Orbit Camera test ******
		//[self runAction:[ actionWithDuration:12 radius:2 deltaRadius:12 angleZ:12 deltaAngleZ:2 angleX:2 deltaAngleX:2]];


		[self schedule:@selector(onEnd:) interval:2];
	}
	
	return self;
}

- (void) dealloc
{
	[self removeAllChildrenWithCleanup:YES];
	[super dealloc];
	
}

- (void)onEnd:(ccTime)dt
{
	[[Director sharedDirector] replaceScene:[FadeTransition transitionWithDuration:1 scene: [MainMenuScene node]]];
}

@end
