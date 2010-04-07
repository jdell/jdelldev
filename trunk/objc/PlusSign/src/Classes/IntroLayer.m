//
//  IntroLayer.m
//  plusSign
//
//  Created by Genki-Oki on 10/18/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "IntroLayer.h"


@implementation IntroLayer
- (id) init{
	self = [super init];
	if (self != nil){
		
		// ***** Green Grass *****
		Sprite *greenGrassSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:@"greengrass_1_an.jpg"]];
		
		//create an Animation object to hold the frame for the walk cycle
		Animation *greenGrassMoving = [[Animation alloc] initWithName:@"greenGrassMoving" delay:0.4];
		
		//Add each frame to the animation
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:@"greengrass_1_an.jpg"]];
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:@"greengrass_2_an.jpg"]];
		[greenGrassMoving addFrameWithFilename:[[NSString alloc] initWithFormat:@"greengrass_3_an.jpg"]];
		
		//Add the animation to the sprite so it can access it's frames
		[greenGrassSprite addAnimation:greenGrassMoving];	
		
		[greenGrassSprite setScale:0.56];
		[greenGrassSprite setPosition:ccp(160,240)];
		[self addChild:greenGrassSprite z:0];
		
		
		// ****** White Background ****** 
		ColorLayer *whiteBGLayer = [ColorLayer layerWithColor:ccc4(255,255,255,255)];
		[self addChild:whiteBGLayer z:1];
		
		
		// ****** Gabriel ****** 
		Sprite *gabrielSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:@"gabriel_1.png"]];
		
		//create an Animation object to hold the frame for the walk cycle
		Animation *gabrielTalking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.10];
		
		//Add each frame to the animation
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:@"gabriel_1.png"]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:@"gabriel_2.png"]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:@"gabriel_3.png"]];
		
		//Add the animation to the sprite so it can access it's frames
		[gabrielSprite addAnimation:gabrielTalking];	
		
		[gabrielSprite setScale:0.5];
		[gabrielSprite setPosition:ccp(160,140)];
		[self addChild:gabrielSprite z:2];
		
		// ****** Gabriel Shadow ****** 
		Sprite *gabrielShadowSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:@"gabriel_1.png"]];
		[gabrielShadowSprite setScale:0.5];
		[gabrielShadowSprite setColor:ccc3(0,0,0)];
		[gabrielShadowSprite setPosition:ccp(160,140)];
		
		[self addChild:gabrielShadowSprite z:3];
		
		id actionShading = [FadeTo actionWithDuration:0.5 opacity:0];
		[gabrielShadowSprite runAction:actionShading];
		
		
		// ****** Word bubble ******
		Sprite *wordBubble = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:@"wordbubble_1.png"]];
		[wordBubble setPosition:ccp(160,320)];
		[wordBubble setScale:0.5];
		[self addChild:wordBubble z:4];
		
		
		// ****** Words ******
		//Ready to play\nMath with me?\nLet's Go!!!
		Label *words = [Label labelWithString:NSLocalizedString(@"", @"") dimensions:CGSizeMake(150, 90) alignment:UITextAlignmentLeft fontName:@"Verdana" fontSize:20];
		[words setPosition:ccp(160,330)];
		[words setColor:ccc3(255,0,255)];
		[self addChild:words z:5];
		
		
		// ****** Gabriel Talking ****** 
		id actionTalking = [Spawn actions:
							[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:3 ],
							[TalkAction actionWithDuration:2 textToSay:NSLocalizedString(@"Ready to play\nMath with me?\nLet's Go!!!", @"") label:words],
							nil];
		[gabrielSprite runAction:actionTalking];
		
		
		// ***** FadeOut Background *****
		[whiteBGLayer runAction:  [FadeTo actionWithDuration:0.5 opacity:0]];
		
		// ****** Grass Moving ******
		[greenGrassSprite runAction: [Repeat actionWithAction:[Animate actionWithAnimation:greenGrassMoving ] times:3]];
		
		// ****** Orbit Camera test ******
		//[self runAction:[OrbitCamera actionWithDuration:12 radius:2 deltaRadius:12 angleZ:12 deltaAngleZ:2 angleX:2 deltaAngleX:2]];
		
		
	}
	
	return self;
}

- (void) dealloc
{
	[self removeAllChildrenWithCleanup:YES];
	[super dealloc];
	
}
@end
