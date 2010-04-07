//
//  PSBlock.m
//  plusSign
//
//  Created by Genki-Oki on 9/20/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "PSBlock.h"


@interface PSBlock(private)

- (void) initializeDefaultValues;
- (void) redrawPositionOnBoard;

@end


@implementation PSBlock

@synthesize boardX;
@synthesize boardY;
@synthesize value;
@synthesize states;
@synthesize stuck;
@synthesize disappearing;
@synthesize markedAs;

- (CGRect) rect {
	float w = [self contentSize].width;
	float h = [self contentSize].height;
	//Utilizo 480 como tama;o de la pantalla y porque el sistema de coordenadas esta al reves!
	CGPoint point = CGPointMake([self position].x - (w/2), [self position].y - (h/2));
	
	return CGRectMake(point.x, point.y, w, h); 
}

- (void) SetActive:(BOOL)active
{
	
	if (active)
		[self SetMarkedAs:NORMAL];
	else
		[self SetMarkedAs:BLAST3];
		
}
- (void) SetMarkedAs:(BlockMarkType)markedAsParam{
	
	markedAs = markedAsParam;
	
	//Set the display frame to the frame in the walk animation at the frameCount index
	[self setDisplayFrame:@"states" index:(int)markedAsParam];
	//if (markedAsParam==SELECTED)
	//	[self setScale:PSCONFIG_BLOCK_INFLATION];
	//else
	//	[self setScale:1];		
	//DEPRECATED: [[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_SOUNDS_EXPLOSION_SOUND];
}

- (void) moveLeft
{
	boardX -=1;
	[self redrawPositionOnBoard];
}

- (void) moveRight
{
	boardX +=1;
	[self redrawPositionOnBoard];
}

- (void) moveUp
{
	boardY += 1;
	[self redrawPositionOnBoard];
}

- (void) moveDown
{
	boardY -= 1;
	[self redrawPositionOnBoard];
}

+ (PSBlock *) newPSBlock
{
	int blockValue = (random() % BLOCK_VALUES) + 1;
	
	//Probability ------
	int prob = random() % 10;
	if (prob<9)
	{
		prob = random() % 100;
		if (prob<98)
			blockValue = (random() % 8) + 2;
		else
			blockValue =  1;
	}
	else
		blockValue = (random() % 3) + 10;
	//------------------
	
	return [PSBlock newPSBlock:blockValue];
}	

+ (PSBlock *) newPSBlockWithOutSpecial
{
	int blockValue = (random() % 9) + 1;
	return [PSBlock newPSBlock:blockValue];
}	


+ (PSBlock *) newPSBlock:(PSBlockValue)val
{
	NSString *fileNormal = nil, *fileSelected, *fileOperated, *fileClicked, *fileBlast1, *fileBlast2, *fileBlast3, *fileBlast4;
	PSBlockValue value;
	PSBlock *res = nil;
		
	int blockValue = val;
	
	switch (blockValue) {
		case 10:
			value = LEAF;
			fileNormal = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_LEAF_1];
			fileSelected = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_LEAF_2];
			fileOperated = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_LEAF_1];
			fileClicked = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_LEAF_1];
			break;
		case 11:
			value = STAR;
			fileNormal = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_STAR_1];
			fileSelected = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_STAR_2];
			fileOperated = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_STAR_1];
			fileClicked = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_STAR_1];
			break;
		case 12:
			value = GREY;
			fileNormal = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_GREY_1];
			fileSelected = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_GREY_1];
			fileOperated = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_GREY_1];
			fileClicked = [[NSString alloc] initWithFormat:CONSTANT_BLOCKS_GREY_1];
			break;
		default:
		{
			switch(blockValue)
			{
				case 1:
					value = ONE;					
					break;
				case 2:
					value = TWO;
					break;
				case 3:
					value = THREE;
					break;
				case 4:
					value = FOUR;
					break;
				case 5:
					value = FIVE;
					break;
				case 6:
					value = SIX;
					break;
				case 7:
					value = SEVEN;
					break;
				case 8:
					value = EIGHT;
					break;
				case 9:
					value = NINE;
					break;
			}
			
			fileNormal = [[NSString alloc] initWithFormat:@"%d_1.png", blockValue];
			fileSelected = [[NSString alloc] initWithFormat:@"%d_3.png", blockValue];
			fileOperated = [[NSString alloc] initWithFormat:@"%d_2.png", blockValue]; 
			fileClicked = [[NSString alloc] initWithFormat:@"%d_4.png", blockValue];  	

			break;
		}
	}
	
	fileBlast1 = [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_EXPLOSION_1];
	fileBlast2 = [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_EXPLOSION_2];
	fileBlast3 = [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_EXPLOSION_3];
	fileBlast4 = [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_EXPLOSION_4];
	
	
	/******************/
	
	res = [self spriteWithFile:fileNormal];
	[res setScale:0.93];
	//[res setRGB:0 :255 :0];
	res.value = value;
	
	//create an Animation object to hold the frame for the walk cycle
	res.states = [[Animation alloc] initWithName:@"states" delay:0];
	
	//Add each frame to the animation
	[res.states addFrameWithFilename:fileNormal];
	[res.states addFrameWithFilename:fileSelected];
	[res.states addFrameWithFilename:fileOperated];
	[res.states addFrameWithFilename:fileClicked];
	
	[res.states addFrameWithFilename:fileBlast1];
	[res.states addFrameWithFilename:fileBlast2];
	[res.states addFrameWithFilename:fileBlast3];
	[res.states addFrameWithFilename:fileBlast4];
	
	//Add the animation to the sprite so it can access it's frames
	[res addAnimation:res.states];	
	//*************************
	
	[fileNormal release];
	[fileSelected release];
	[fileOperated release];
	[fileClicked release];
	[fileBlast1 release];
	[fileBlast2 release];
	[fileBlast3 release];
	[fileBlast4 release];
	
	[res initializeDefaultValues];
	
	return res;
}

- (BOOL) isSpecialBlock
{
	return value==LEAF || value == GREY || value==STAR;
}

- (void) initializeDefaultValues
{
	[self setTransformAnchor:ccp(0, 0)];
	[self setPosition:ccp(0, 0)];
	[self setOpacity:255];
	[self setStuck:YES];
	[self setDisappearing:NO];
	[self setBoardY:0];
	[self setBoardX:0];
	[self SetActive:YES];
}

- (void) redrawPositionOnBoard
{
	[self setPosition:COMPUTE_X_Y(boardX, boardY)];
}

@end
