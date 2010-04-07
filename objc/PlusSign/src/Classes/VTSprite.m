//
//  VTSprite.m
//  plusSign
//
//  Created by Genki-Oki on 9/7/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "VTSprite.h"


@implementation VTSprite

@synthesize states;

+(void)Reset {
	NSUInteger i, count = [ [VTSprite allMySprites] count];
	for (i = 0; i < count; i++)
	{
		VTSprite * obj = (VTSprite *)[ [VTSprite allMySprites] objectAtIndex:i];
		[obj SetType:NORMAL];
	}
}

+(VTSprite *)GetMainSelected {
	NSUInteger i, count = [ [VTSprite allMySprites] count];
	VTSprite * obj = nil;
	for (i = 0; i < count; i++)
	{
		obj = (VTSprite *)[ [VTSprite allMySprites] objectAtIndex:i];
		if ([obj GetType]==SELECTED)
			return obj;
	}
	return nil;
}

+ (id) vtsspriteWithFiles:(int)numericValue: (NSString *)imageFileNormal: (NSString *)imageFileSelected: (NSString *)imageFileOperated
{	
	VTSprite *res = [VTSprite spriteWithFile:imageFileNormal];
	
	//create an Animation object to hold the frame for the walk cycle
	res.states = [[Animation alloc] initWithName:@"states" delay:0];
	
	//Add each frame to the animation
	[res.states addFrameWithFilename:imageFileNormal];
	[res.states addFrameWithFilename:imageFileSelected];
	[res.states addFrameWithFilename:imageFileOperated];
	
	//Add the animation to the sprite so it can access it's frames
	[res addAnimation:res.states];	
	
	[res SetType:NORMAL];
	
	[res SetValue: numericValue];
	
	return res;
}

- (void) SetType:(VTSpriteTypes)typeParam{
	
	type = typeParam;
	
	//Set the display frame to the frame in the walk animation at the frameCount index
	[self setDisplayFrame:@"states" index:(int)typeParam];
}
- (VTSpriteTypes) GetType{
	return type;
}

- (void) SetValue:(int)valueParam{
	value = valueParam;
}

- (int) GetValue{
	return value;
}
@end

