//
//  LogicTeachMeLayer.m
//  plusSign
//
//  Created by Genki-Oki on 12/5/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "LogicTeachMeMathLayer.h"
@interface LogicTeachMeMathLayer(private)

- (void) processTabs:(PSBlock*)block;
- (void) processTabs;
- (void) disappearBlocks;

- (void) setOperable:(int) x:(int) y;

- (void) resetBoard;

- (void) moveBlockDown:(PSBlock *)psblock;
@end

@implementation LogicTeachMeMathLayer
- (void) moveBlockDown:(PSBlock *)psblock {
	
	board[psblock.boardX][psblock.boardY] = nil;
	board[psblock.boardX][psblock.boardY - 1] = psblock;
	
	psblock.boardY -= 1;
	id rotateAction = [RotateBy actionWithDuration:0.01 angle:10];
	CGPoint position = COMPUTE_X_Y(psblock.boardX+1, psblock.boardY+1);
	id action = [Spawn actions:
				 rotateAction,
				 [ReverseTime actionWithAction:rotateAction],
				 [MoveTo actionWithDuration:0.001 position:ccp(position.x +16, position.y+16)],
				 nil];
	
	[psblock runAction:action];
}

- (void) randomizeBoard:(PSBlock*)block
{
	if (block==nil) return;
	
	selectedPSBlock = nil;
	operand1PSBlock = nil;
	for (int x=0; x<=kLastColumn; x++) 
	{
		for (int y=0; y<kLastRow; y++) 
		{			
			PSBlock *tmpBlock = board[x][y];
			if (tmpBlock!=nil)
			{
				if ((block.boardX == x) && (block.boardY == y)) continue;
				
				
				[self removeChild:tmpBlock cleanup:YES];
				tmpBlock = nil;
				board[x][y] = nil;
				
				
				tmpBlock = [[PSBlock newPSBlock] retain];				
				board[x][y] = tmpBlock;
				tmpBlock.boardX = x;
				tmpBlock.boardY = y;
				tmpBlock.position = COMPUTE_X_Y(x, y);
				[self addChild:tmpBlock];	
				
			}
		}
	}
}

- (void) disappearBlocks
{
	PSBlock *psblock = nil;
	for (int x=0; x<=2; x++) {
		for (int y=0; y<=2; y++) {
			psblock = board[x][y];
			if (psblock!=nil && psblock.disappearing)
			{
				//I have to use the blast1 frame
				if (5 < psblock.opacity)
				{
					psblock.opacity -= 5;
					if (192 < psblock.opacity)
					{
						[psblock SetMarkedAs:BLAST1];						
						[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_SOUNDS_EXPLOSION_SOUND];
					}
					else
						if (128 < psblock.opacity)
							[psblock SetMarkedAs:BLAST2];
						else
							if (64 < psblock.opacity)
								[psblock SetMarkedAs:BLAST3];
							else
								[psblock SetMarkedAs:BLAST4];
				}
				else
				{
					[self removeChild:psblock cleanup:YES];
					psblock = nil;
					board[x][y] = nil;
					disappeared = YES;
					
				}
			}
		}
	}
}

- (void) updateBoard:(ccTime)dt{
	frameCount++;
	[self processTabs];
	[self disappearBlocks];
	
	if (frameCount % PSCONFIG_GAMEPLAY_MOVECYCLERATIO == 0)
	{
		[self moveBlocksDown];
	}
	
}

- (void) moveBlocksDown {	
	PSBlock *psblock = nil;
	/*
	 for (int x = kLastColumn; x >= 0; x--) {
	 for (int y = kLastRow; y >= 0; y--) {
	 */
	for (int x = 0; x <= 2; x++) {
		for (int y = 0; y <= 2; y++) {
			
			psblock = board[x][y];
			
			// Is psblock "solid?" i.e. not disappearing?
			if (nil != psblock && !psblock.disappearing) {
				
				// Can this psblock drop down to the next cell?
				if ( 0 < y && (nil == board[x][y - 1]) ) {
					
					// Channel Bob Parker: Come on down!
					[self moveBlockDown:psblock];
					psblock.stuck = NO;		
					
				} else {
					// This psblock can't drop anymore, it's stuck.
					psblock.stuck = YES;
				}
				
			} // End of if (nil != psblock && !psblock.disappearing)
			
		} // End of for y loop.
	} // End of for x loop.
	
	
	if (disappeared)
	{
		[self resetBoard];
		disappeared = NO;
		/*if (currentStep>13)
		{
			[self nextStep:self];
		 }*/
		[self unschedule:@selector(updateBoard:)];
		[Button checkAll:nextButton];
	}	 
	else
	{
		[Button unCheckAll:nextButton];
	}

}
- (void) startGame {

	// clear the board
	//memset(board, 0, sizeof(board));
	
	disappeared = NO;
	frameCount = 0;
	//moveCycleRatio = 15; // Drop puyos every 3/4 second 
	
	// Execute updateBoard 60 times per second.
	[Button unCheckAll:nextButton];
	[self resetBoard];
	[self schedule:@selector(updateBoard:) interval: 1.0 / 60.0];
	//[self schedule:@selector(updateBoard:) interval: 1.0];
	
}
- (void) resetBoard{
	selectedPSBlock = nil;
	operand1PSBlock = nil;
	for (int x=0; x<=2; x++) 
	{
		for (int y=0; y<=2; y++) 
		{			
			PSBlock *block = board[x][y];
			if (block!=nil)	[block SetMarkedAs:NORMAL];
		}
	}
}


- (id) init{
	self = [super init];
	if (self != nil)
	{
		positionNextButton = ccp(80,32);
		CGPoint positionGabriel = ccp(240,90);
		CGPoint positionWordBubble = ccp(160,300);
		CGPoint positionWords = ccp(170,300);
		
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

//Game Logic
- (void) setOperable:(int) x:(int) y
{
	if ((x<=2) && (x>=0) && (y<=2) && (y>=0))
	{
		PSBlock *block = board[x][y];
		[block SetMarkedAs:OPERATED];
	}
}

- (BOOL) isTicTacToe:(PSBlock *)mainSprite: (PSBlock *)operand1: (PSBlock *)operand2
{
	BOOL res = NO;
	
	res = ((operand1.boardX + operand2.boardX)/2 == mainSprite.boardX) && ((operand1.boardY + operand2.boardY)/2 == mainSprite.boardY);
	
	return res;
}

- (void) operate:(PSBlock *)mainSprite: (PSBlock *)operand1: (PSBlock *)operand2
{
	if (operand2!=nil)
	{
		int mainValue = mainSprite.value;
		int operand1Value = operand1.value;
		int operand2Value = operand2.value;
		
		bool ticTacToe = [self isTicTacToe:mainSprite:operand1 :operand2];
		
		
		if (
			(ticTacToe) &&
			(
			 (mainValue == (int)LEAF) ||
			 (mainValue == operand1Value + operand2Value) || 
			 (mainValue == abs(operand1Value - operand2Value)) ||
			 (mainValue == operand1Value * operand2Value) ||
			 (mainValue == operand1Value / operand2Value) ||
			 (mainValue == operand2Value / operand1Value)
			 )
			)
		{
			[operand1 setDisappearing:YES] ;
			[operand2 setDisappearing:YES] ;
			[mainSprite setDisappearing:YES] ;
		}
		else
		{
			[operand2 SetMarkedAs:OPERATED];
		}
	}
}
- (void) processTabs
{
	if (!touched) return;
	
	if (pointTouchedD.x>0 && pointTouchedD.y>0)
	{
		PSBlock *block = board[(int)pointTouchedD.x-1][ (int)pointTouchedD.y-1];
	
		[self processTabs:block];
	}
}
- (void) processTabs:(PSBlock*)block
{
	//PSBlock *block = board[(int)pointTouchedD.x][ (int)pointTouchedD.y];
	if (block!=nil)
	{
		switch([block markedAs])
		{
			case NORMAL:
			{
				[block SetMarkedAs:SELECTED];
				selectedPSBlock = block;
				
				if ((block.value == (int)STAR) || (block.value == (int)GREY)) break;
				
				[self setOperable:block.boardX-1 :block.boardY-1];
				[self setOperable:block.boardX-1 :block.boardY+0];
				[self setOperable:block.boardX-1 :block.boardY+1];
				
				[self setOperable:block.boardX+0 :block.boardY-1];
				//[self setOperable:block.boardX+0 :block.boardY+0];
				[self setOperable:block.boardX+0 :block.boardY+1];
				
				[self setOperable:block.boardX+1 :block.boardY-1];
				[self setOperable:block.boardX+1 :block.boardY+0];
				[self setOperable:block.boardX+1 :block.boardY+1];		
				
				break;
			}
			case SELECTED:
			{
				PSBlockValue value = block.value;
				switch (value) {
					case LEAF:
						
						break;
					case STAR:
						[self randomizeBoard:block];
						[block setDisappearing:YES] ;
						break;
					case GREY:
						
						break;
					default:
						[block SetMarkedAs:NORMAL];
						[self resetBoard];
						break;
				}
				
				break;
			}
			case OPERATED:
				if (operand1PSBlock == nil)
				{
					operand1PSBlock = block;
					[block SetMarkedAs:CLICKED];
					
					PSBlockValue value = selectedPSBlock.value;
					if (value == LEAF)
					{
						[operand1PSBlock setDisappearing:YES] ;
						[selectedPSBlock setDisappearing:YES] ;
					}
				}
				else
				{
					[self operate:selectedPSBlock: operand1PSBlock :block];
				}
				break;
			case CLICKED:
				if (selectedPSBlock !=nil)
				{
					[block SetMarkedAs:OPERATED];
					operand1PSBlock = nil;
				}
				break;
			case BLAST1:
				break;
			case BLAST2:
				break;
			default:
				break;
		}
	}
	touched = NO;
}
// ******************

- (void) goToStep:(int)step{
	[Button unCheckAll:nextButton];
	//float tempScale = 1;//0.52;
	int durationTalking, timesTalking;
	NSString *text;
	switch (step) {
		case 0:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 			
			text = @"Welcome to the Math\nTutorial!\n\nI am here to give you all\nthe help you can get to\npractice math in a fun\nway. Let's go!";
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
			text = @"Here we got the four\nessential mathematical\nmethods used in the\nentire world! Plus, Minus,\nTimes and Division.";
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
			
			
			int buttonY = 100;			
			Sprite *signsSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_SIGNS];
			[signsSprite setPosition:ccp(160-10, buttonY)];
			//[signsSprite setScale:tempScale];
			[wordBubble addChild:signsSprite];

			break;
		}
		case 2:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"Sometimes you will only\nwork with two or one\nmath methods in a game,\nso be ready to take the\nchallenge!";
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
			
			
			int buttonY = 100;
			
			Sprite *signsSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_SIGNS];
			[signsSprite setPosition:ccp(160-10, buttonY)];
			//[signsSprite setScale:tempScale];
			[wordBubble addChild:signsSprite];

			break;
		}
		case 3:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			
			[words setPosition:ccp(words.position.x, words.position.y -180)];
			// ****** Gabriel Talking ****** 
			text = @"For example, lets use the minus sign...";
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
			
			
			// Seed random number generator.
			struct timeval tv;
			gettimeofday( &tv, 0 );
			srandom( tv.tv_usec + tv.tv_sec );
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block;
					if (y==1)
					{
						int value = 1;
						switch(x)
						{
							case 0:
								value = 1;
								break;
							case 1:
								value = 7;
								break;
							case 2:
								value = 8;
								break;
						}
						block = [[PSBlock newPSBlock:value] retain];
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
		case 4:
		{
			// ****** Gabriel Talking ****** 
			text = @"First, select any number\nin the group of blocks";
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
			
			
			// Seed random number generator.
			fingerSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_TUTORIALELEMENTS_FINGER]];
			[fingerSprite setPosition:[self positionFinger:0]];
			[wordBubble addChild:fingerSprite z:5];
			
			break;
		}
		case 5:
		{
			// ****** Gabriel Talking ****** 
			text =@"All the blocks around it\nwill turn blue";
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
			
			[self processTabs:board[1][1]];
			
			break;
		}
		case 6:
		{
			[wordBubble removeChild:fingerSprite cleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"The puzzle can be solve\nlike a tic-tac-toe";
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
			
			crossSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_CROSS];
			[crossSprite setPosition:ccp(selectedPSBlock.position.x + selectedPSBlock.contentSize.width/2 -3, selectedPSBlock.position.y + selectedPSBlock.contentSize.height/2 -3)];
			[wordBubble addChild:crossSprite];
			
			break;
		}
		case 7:
		{
			[wordBubble removeChild:crossSprite cleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"As a cross or as a X";
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
						
			xSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_X];
			[xSprite setPosition:ccp(selectedPSBlock.position.x + selectedPSBlock.contentSize.width/2 -3, selectedPSBlock.position.y + selectedPSBlock.contentSize.height/2 -3)];
			[wordBubble addChild:xSprite];
			
			break;
		}
		case 8:
		{
			[wordBubble removeChild:xSprite cleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"Now, click on the two\nnumbers that...";
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
		case 9:
		{
			// ****** Gabriel Talking ****** 
			text = @"Will solve the middle\nnumber and...";
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
			
			fingerSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_TUTORIALELEMENTS_FINGER]];
			[fingerSprite setPosition:[self positionFinger:-1]];
			[wordBubble addChild:fingerSprite z:5];
			
			[self processTabs:board[0][1]];
			
			break;
		}
		case 10:
		{
			// ****** Gabriel Talking ****** 
			text = @"8 - 1 is...";
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
			
			[fingerSprite setPosition:[self positionFinger:+1]];
			[self processTabs:board[2][1]];
			
			break;
		}
		case 11:
		{
			[wordBubble removeChild:fingerSprite cleanup:YES];
			// ****** Gabriel Talking ****** 
			text =@"Wala! problem solved!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil];
			[gabrielSprite runAction:actionTalking];
			//Include blocks down animation
			
			frameCount = 0;
			//moveCycleRatio = 15;
			[Button unCheckAll:nextButton];
			[self schedule:@selector(updateBoard:) interval: 1.0 / 60.0];
			
			break;
		}			
		case 12:
		{
			[self unschedule:@selector(updateBoard:)];
			[wordBubble removeAllChildrenWithCleanup:YES];
			[words setPosition:ccp(words.position.x, words.position.y+180)];
			// ****** Gabriel Talking ****** 
			text = @"It doesn't matter in\nwhich order you click\nthe numbered blocks,\njust as long as the Math\nmethods works.";
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
		case 13:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"Alright, it's your turn, you\ntry it out. Ready?";
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
		case 14:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			[words setPosition:ccp(words.position.x, words.position.y -180)];
			// ****** Gabriel Talking ****** 
			text = @"Try to solve this puzzle!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Spawn actions:
								[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
								[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
												  nil];
			[gabrielSprite runAction:actionTalking];
			
			// Seed random number generator.
			struct timeval tv;
			gettimeofday( &tv, 0 );
			srandom( tv.tv_usec + tv.tv_sec );
			for (int x=0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					PSBlock *block;
					if (y==1)
					{
						int value = 1;
						switch(x)
						{
							case 0:
								value = 1;
								break;
							case 1:
								value = 7;
								break;
							case 2:
								value = 8;
								break;
						}
						block = [[PSBlock newPSBlock:value] retain];
					}
					else
						block = [[PSBlock newPSBlockWithOutSpecial] retain];
					
					board[x][y] = block;
					block.boardX = x;
					block.boardY = y;
					block.position = COMPUTE_X_Y(x+1, y+1);
					[block setPosition:ccp(block.position.x +16, block.position.y+16)];
					[wordBubble addChild:block];	
				}
			}
			[self startGame];
			break;
		}
		case 15:
			{
				[wordBubble removeAllChildrenWithCleanup:YES];
				[words setPosition:ccp(words.position.x, words.position.y + 180)];
				
				[self removeChild:nextButton cleanup:YES];
				nextButton = nil;
				
				menuButton = [Button  buttonWithImage:CONSTANT_BUTTONS_MENU atPosition:positionNextButton target:self selector:@selector(goToMainMenu:) enablePush:NO];	
				[self addChild:menuButton];
				[Button unCheckAll:menuButton];
				
				// ****** Gabriel Talking ****** 
				text =@"GRRRRREATTT!!!!\n\nYou are incredible! Well,\nyou're done, go ahead\nand try the game, good\nluck!";
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
		case 16:
			{
				[self goToMainMenu:self];			
				
				break;
			}
		default:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"Trabaja! este juego no se hara solo!!";
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
- (void) activeNextButton
{
	if (nextButton!=nil) 
		[Button checkAll:nextButton];
	else if (menuButton!=nil)
		[Button checkAll:menuButton];
}
- (BOOL)ccTouchesEnded:(NSSet *)touches withEvent:(UIEvent *)event 
{
	UITouch *touch = [touches anyObject];
	CGPoint point = [touch locationInView: [touch view]];
	point.y = 480 - point.y;
		
	int w = wordBubble.contentSize.width;
	int h = wordBubble.contentSize.height;
	int pX = wordBubble.position.x;
	int pY = wordBubble.position.y;
	
	//int x = point.x - (pX-w/2);
	//int y =  point.y - (pY-h/2);
	
	//*****
	//float w = [giveUpBtn contentSize].width;
	//float h = [giveUpBtn contentSize].height;
	CGPoint loc = CGPointMake(pX - (w/2), pY - (h/2));	
	CGRect rect = CGRectMake(loc.x, loc.y, w, h); 
	
	if (CGRectContainsPoint(rect, point)) 
	{
		for (int x=0; x<3; x++) 
		{
			for (int y=0; y<3; y++) 
			{
				PSBlock *block = board[x][y];
				float blockW = [block contentSize].width;
				float blockH = [block contentSize].height;
				
				
				CGPoint blockLoc = CGPointMake([block position].x - (blockW/2), [block position].y - (blockH/2));	
				CGRect rect = CGRectMake(loc.x + blockLoc.x+26, loc.y + blockLoc.y+26, blockW, blockH); 
				
				if (CGRectContainsPoint(rect, point)) 
				{
					touched = YES;
					pointTouchedD = ccp(x+1, y+1);//DECOMPUTE_X_Y(x, y);
					return kEventHandled;
				}	
			}
		}
	}	
	

	//*****
/*	
	x -= 16;
	y -= 16;
	if (y>0 && x>0)
	{
		//Buscar el sprite tocado
		touched = YES;
		//pointTouchedD =  DECOMPUTE_X_Y(x-16, y-16);
		pointTouchedD =  DECOMPUTE_X_Y(x, y);
	}
	*/
  	return kEventHandled;
}
- (CGPoint)positionFinger:(int)step
{
	PSBlock *block = board[step +1][1];
	return ccp((block.position.x + block.contentSize.width/2-3)-60, (block.position.y + block.contentSize.height/2-3)-40);

}
@end
