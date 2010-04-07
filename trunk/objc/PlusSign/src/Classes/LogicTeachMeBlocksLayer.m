//
//  LogicTeachMeBlocksLayer.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "LogicTeachMeBlocksLayer.h"


@implementation LogicTeachMeBlocksLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{
		 positionNextButton = ccp(80,32);
		 positionGabriel = ccp(240,90);
		 positionWordBubble = ccp(160,300);
		 positionWords = ccp(170,300);
		
		nextButton = [Button  buttonWithImage:CONSTANT_BUTTONS_NEXT atPosition:positionNextButton target:self selector:@selector(nextStep:) enablePush:NO];	
		[self addChild:nextButton];
		
		// ****** Gabriel ****** 
		gabrielSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_1]];
		
		//create an Animation object to hold the frame for the walk cycle
		gabrielTalking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.10];
		
		//Add each frame to the animation
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_1]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_2]];
		[gabrielTalking addFrameWithFilename:[[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_3]];
		
		//Add the animation to the sprite so it can access it's frames
		[gabrielSprite addAnimation:gabrielTalking];	
		
		[gabrielSprite setPosition:positionGabriel];
		[self addChild:gabrielSprite z:5];
		
		// ****** Word bubble ******
		wordBubble = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_WORDBUBBLES_WORDBUBBLE_1]];
		[wordBubble setPosition:positionWordBubble];
		[self addChild:wordBubble z:4];
		
		
		// ****** Words ******
		//Ready to play\nMath with me?\nLet's Go!!!
		words = [Label labelWithString:NSLocalizedString(@"", @"") dimensions:CGSizeMake(280, 260) alignment:UITextAlignmentLeft fontName:@"Verdana" fontSize:20];
		[words setPosition:positionWords];
		[words setColor:ccc3(0,0,0)];
		[self addChild:words z:5];
		
		currentStep = 0;
		[self goToStep:currentStep];
		
		[self setIsTouchEnabled:YES];
	}
	return self;
}

- (void)nextStep:(id)sender{
	
	if ([Button isSomethingChecked:nextButton])
	{
		currentStep++;
		[self goToStep:currentStep];
	}
}
- (void)goToMainMenu:(id)sender{
	
	if ([Button isSomethingChecked:menuButton])
	{
		[[Director sharedDirector] replaceScene:[MoveInRTransition transitionWithDuration:0.2 scene:[TeachMeMenuScene node]]];
	}
}
- (void) goToStep:(int)step{
	[Button unCheckAll:nextButton];
	NSString *text;
	int durationTalking, timesTalking;
	switch (step) {
		case 0:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"Welcome to the Blocks\nTutorial!\n\nI am here to give you all\nthe help you can get to\npractice math in a fun\nway. Let's go!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			break;
		}
		case 1:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"Here are some of the\nblocks that you will see\nin the game. The Leaf,\nthe Star and the Grey\nblocks.";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			
			int y = 90;
			int x = 45;
			int i = 0;
			int offsetX = 80;
			
			PSBlock *leafBlock = [PSBlock newPSBlock:LEAF];
			[leafBlock setPosition:ccp(x + (offsetX * (i++)), y)];
			[wordBubble addChild:leafBlock];
			
			PSBlock *starBlock = [PSBlock newPSBlock:STAR];
			[starBlock setPosition:ccp(x + (offsetX * (i++)), y)];
			[wordBubble addChild:starBlock];
			
			PSBlock *greyBlock = [PSBlock newPSBlock:GREY];
			[greyBlock setPosition:ccp(x + (offsetX * (i++)), y)];
			[wordBubble addChild:greyBlock];
			
			break;
		}
		case 2:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			
			[words setPosition:ccp(words.position.x, words.position.y -180)];
			// ****** Gabriel Talking ****** 
			text = @"First, lets start with the\nLeaf block...";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_6];
			[cubes1 setPosition:ccp(160, 300)];
			[cubes1 setScale:0.7];
			[wordBubble addChild:cubes1];
			*/
			
			// Seed random number generator.
			struct timeval tv;
			gettimeofday( &tv, 0 );
			srandom( tv.tv_usec + tv.tv_sec );
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block;
					if ((y==1) && (x==1))
						block = [[PSBlock newPSBlock:LEAF] retain];
					else
						block = [[PSBlock newPSBlockWithOutSpecial] retain];
					
					board[x][y] = block;
					block.boardX = x;
					block.boardY = y;
					block.position = COMPUTE_X_Y(x+1, y+1);
					[block setPosition:ccp(block.position.x+16, block.position.y+16)];
					[wordBubble addChild:block];	
				}
			}						
			
			
			break;
		}
		case 3:
		{
			//[wordBubble removeAllChildrenWithCleanup:NO];
			
			// ****** Gabriel Talking ****** 
			text = @"Once you click on a Leaf\nblock, you can...";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_5];
			[cubes1 setPosition:ccp(160, 300)];
			[cubes1 setScale:0.7];
			[wordBubble addChild:cubes1];
			*/
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block = board[x][y];
					if ((y==1) && (x==1))
						[block SetMarkedAs:SELECTED];
					else
						 [block SetMarkedAs:OPERATED];
						 
						// [wordBubble addChild:block];	
				}
			}	
				/*		 
						 for (int x=0; x<3; x++) 
						 {
							for (int y=0; y<3; y++) 
							{
								PSBlock *block;
								if ((y==1) && (x==1))
								{
									block = [[PSBlock newPSBlock:LEAF] retain];
								}
								else
								{
									block = [[PSBlock newPSBlockWithOutSpecial] retain];
								}
								
								board[x][y] = block;
								block.boardX = x;
								block.boardY = y;
								block.position = COMPUTE_X_Y(x+1, y+1);
								[block setPosition:ccp(block.position.x+16, block.position.y+16)];
								[wordBubble addChild:block];	
							}
						}		
			*/
			break;
		}
		case 4:
		{
			// ****** Gabriel Talking ****** 
			text =@"...delete any block around\nit, just click on it and...";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			
			fingerSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_FINGER];
			[fingerSprite setPosition:[self positionFinger:+1]];
			[wordBubble addChild:fingerSprite];
			
			break;
		}
		case 5:
		{
			//[wordBubble removeAllChildrenWithCleanup:NO];
			
			// ****** Gabriel Talking ****** 
			text =@"The Leaf and the block\nyou chosed will be gone!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_4];
			[cubes1 setPosition:ccp(160, 300)];
			[wordBubble addChild:cubes1];
			 */
			[wordBubble removeChild:fingerSprite cleanup:YES];
							[board[1][1] SetMarkedAs:BLAST1];
							[board[1][2] SetMarkedAs:BLAST1];							
			
			break;
		}
		case 6:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			
			// ****** Gabriel Talking ****** 
			text = @"This is an example of the\nStar block";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_7];
			[cubes1 setPosition:ccp(160, 300)];
			[wordBubble addChild:cubes1];
			*/
			struct timeval tv;
			gettimeofday( &tv, 0 );
			srandom( tv.tv_usec + tv.tv_sec );
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block;
					if ((y==1) && (x==1))
						block = [[PSBlock newPSBlock:STAR] retain];
					else
						block = [[PSBlock newPSBlockWithOutSpecial] retain];
					
					board[x][y] = block;
					block.boardX = x;
					block.boardY = y;
					block.position = COMPUTE_X_Y(x+1, y+1);
					[block setPosition:ccp(block.position.x+16, block.position.y+16)];
					[wordBubble addChild:block];	
				}
			}
			
			break;
		}
		case 7:
		{
			//[wordBubble removeAllChildrenWithCleanup:YES];
			
			// ****** Gabriel Talking ****** 
			text = @"Just click on the Star\nblock, and...";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_8];
			[cubes1 setPosition:ccp(160, 300)];
			[wordBubble addChild:cubes1];
			*/
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block = board[x][y];
					if ((y==1) && (x==1))
						[block SetMarkedAs:SELECTED];
					else
						[block SetMarkedAs:OPERATED];
				}
			}
			fingerSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_FINGER];
			[fingerSprite setPosition:[self positionFinger:0]];
			[wordBubble addChild:fingerSprite];
			
			break;
		}
		case 8:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			[words setPosition:ccp(words.position.x, words.position.y+24)];
			// ****** Gabriel Talking ****** 
			text = @"The Star block will\ndisappear, but it will reset\nall of the yellow blocks.";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_9];
			[cubes1 setPosition:ccp(160, 300)];
			[wordBubble addChild:cubes1];
			*/
			struct timeval tv;
			gettimeofday( &tv, 0 );
			srandom( tv.tv_usec + tv.tv_sec );
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block;
					if ((y==1) && (x==1))
					{
						block = [[PSBlock newPSBlock:STAR] retain];
						[block SetMarkedAs:BLAST1];
					}
					else
						block = [[PSBlock newPSBlockWithOutSpecial] retain];
					
					board[x][y] = block;
					block.boardX = x;
					block.boardY = y;
					block.position = COMPUTE_X_Y(x+1, y+1);
					[block setPosition:ccp(block.position.x+16, block.position.y+16)];
					[wordBubble addChild:block];	
				}
			}
			
			break;
		}
		case 9:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			[words setPosition:ccp(words.position.x, words.position.y - 24)];
			
			// ****** Gabriel Talking ****** 
			text = @"And finally, the Grey\nblock.";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			/*
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_10];
			[cubes1 setPosition:ccp(160, 300)];
			[wordBubble addChild:cubes1];
			*/
			struct timeval tv;
			gettimeofday( &tv, 0 );
			srandom( tv.tv_usec + tv.tv_sec );
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block;
					if ((y==1) && (x==1))
					{
						block = [[PSBlock newPSBlock:GREY] retain];
					}
					else
						block = [[PSBlock newPSBlockWithOutSpecial] retain];
					
					board[x][y] = block;
					block.boardX = x;
					block.boardY = y;
					block.position = COMPUTE_X_Y(x+1, y+1);
					[block setPosition:ccp(block.position.x+16, block.position.y+16)];
					[wordBubble addChild:block];	
				}
			}
			break;
		}
		case 10:
		{			
			[words setPosition:ccp(words.position.x, words.position.y + 24)];//60
			// ****** Gabriel Talking ****** 
			text = @"It only serves as a\nnuisance, get rid off it\nwith the Leaf!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			
			break;
		}
		case 11:
		{		
			[wordBubble removeAllChildrenWithCleanup:YES];
			[words setPosition:ccp(words.position.x, words.position.y + 160)];	//180
						
			[self removeChild:nextButton cleanup:YES];
			nextButton = nil;
			
			menuButton = [Button  buttonWithImage:CONSTANT_BUTTONS_MENU atPosition:positionNextButton target:self selector:@selector(goToMainMenu:) enablePush:NO];	
			[self addChild:menuButton];
			[Button unCheckAll:menuButton];
			
			// ****** Gabriel Talking ****** 
			text = @"GRRRRREATTT!!!!\n\nYou're done with all the\ntutorials!!! Now go out\nthere and play!\n\nSee you soon!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];			
			
			
			[self schedule:@selector(goToMainMenu:) interval: PSCONFIG_TUTORIAL_TIMETOREAD];
			break;
		}
		default:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 
			text =@"Trabaja! este juego no se hara solo!!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:[Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil],
								[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
								nil
								];
			[gabrielSprite runAction:actionTalking];
			
			break;
		}
	}
}
- (CGPoint)positionFinger:(int)step
{
	PSBlock *block = board[1][step +1];
	return ccp((block.position.x + block.contentSize.width/2-3)-60, (block.position.y + block.contentSize.height/2-3)-40);
}
- (void) activeNextButton
{
	if (nextButton!=nil) 
		[Button checkAll:nextButton];
	else if (menuButton!=nil)
		[Button checkAll:menuButton];
}
- (void)wrongSolution:(id)sender
{
	//currentStep = 13; //13 Bad Luck! :D
	[self goToStep:13];
}
- (void)rightSolution:(id)sender
{
	currentStep++;
	[self goToStep:currentStep];
}
- (void)noWayAction:(id)sender
{
	[self goToStep:14];
}
- (void)alrightAction:(id)sender
{
	//currentStep--;
	[self goToStep:currentStep];
}
@end
