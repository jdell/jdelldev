//
//  BackgroundLayer.m
//  plusSign
//
//  Created by Genki-Oki on 8/10/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "BackgroundMainMenuLayer.h"


@implementation BackgroundMainMenuLayer

- (id) init{
	self = [super init];
	if (self != nil)
	{
		/**/
		
		Sprite * bgGreen = [Sprite spriteWithFile:CONSTANT_BACKGROUND_MENU];
		[bgGreen setPosition:ccp(160, 240)];
		[self addChild:bgGreen z:0];	
		
		Sprite * copyRight = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_RIGHTS2009];
		[copyRight setPosition:ccp(160,16)];
		[self addChild:copyRight z:1];	

		Sprite * bgLogo = [Sprite spriteWithFile:[[NSString alloc] initWithFormat:@"plussignlogo%04d.png", 1]];
		/*
		 //TODO: Animation. Set the correct frame rate
		Animation *shineLogo = [[Animation alloc] initWithName:@"shineLogo" delay:0.066];
		for (int i=1; i<=5; i++) {
			[shineLogo addFrameWithFilename:[[NSString alloc] initWithFormat:@"plussignlogo%04d.png", i]];
		}
		*/
		//[bgLogo setPosition:ccp(160+10, 240+10+106)];
		[bgLogo setPosition:ccp(160, 600)];
		[bgLogo addAnimation:shineLogo];
		[bgLogo setScale:0.92];
		[self addChild:bgLogo z:2];		
		

		[bgLogo runAction:
		 [Sequence actions:
		  [EaseElasticInOut actionWithAction:[MoveTo actionWithDuration:2 position:ccp(160, 240+20+106)] period:0.4],
		  [CallFunc actionWithTarget:self selector:@selector(doSound)], 
		 nil]
		];
		//[bgLogo runAction:[MoveTo actionWithDuration:2 position:ccp(160, 240+20+106)]];
		[bgLogo runAction:[RepeatForever actionWithAction:[Animate actionWithAnimation:shineLogo]]];
		
	}
	return self;
}
- (void) doSound
{
	[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_SOUNDS_LOGO_DROP_SOUND];
}
@end
