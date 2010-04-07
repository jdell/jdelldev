//
//  LogicTeachMeBasicsLayer.m
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "LogicTeachMeBasicsLayer.h"


@implementation LogicTeachMeBasicsLayer

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
		
		[Button unCheckAll:nextButton];
		
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
	[gabrielSprite stopAllActions];
	int timesTalking, durationTalking;
	NSString *text;
	
	switch (step) {
		case 0:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			// ****** Gabriel Talking ******
			text = @"Welcome to the Basic\nTutorial!\n\nI am here to give you all\nthe help you can get to\npractice math in a fun\nway. Let's go!";
			durationTalking = PSCONFIG_TALKING_DURATION([text length]);
			timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
			id actionTalking = [Sequence actions:
		 [Spawn actions:
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
			
			[words setPosition:ccp(positionWords.x, positionWords.y -150)];
			// ****** Gabriel Talking ****** 
			text = @"First, take a look at\nthese yellow blocks with\nnumbers inside...";
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
			Sprite *cubes1 = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TUTORIAL_CUBES_1];
			[cubes1 setPosition:ccp(wordBubble.contentSize.width/2, 60 + wordBubble.contentSize.height/2)];
			[wordBubble addChild:cubes1];
			*/	
			
			for (int x=0; x<=2; x++) 
			{
				for (int y=0; y<3; y++) 
				{			
					PSBlock *tmpBlock = [[PSBlock newPSBlockWithOutSpecial] retain];
					tmpBlock.position =  ccp(74 + abs(x)*52, 140  + abs(y)*52);// COMPUTE_X_Y(x, y);
					//[tmpBlock setScale:0.5];
					[wordBubble addChild:tmpBlock];
				}
			}	
			
			break;
		}
		case 2:
		{
			[wordBubble removeAllChildrenWithCleanup:YES];
			[words setPosition:ccp(positionWords.x, positionWords.y -180)];
			// ****** Gabriel Talking ****** 
			text = @"We got a whoooole lot\nof blocks to get rid off!";
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
			
			
			for (int x=0; x<=4; x++) 
			{
				for (int y=0; y<7; y++) 
				{			
					PSBlock *tmpBlock = [[PSBlock newPSBlockWithOutSpecial] retain];
					tmpBlock.position = ccp(90 + abs(x)*26, 110 + abs(y)*26);// COMPUTE_X_Y(x, y);
					[tmpBlock setScale:0.5];
					[wordBubble addChild:tmpBlock];
				}
			}			
			break;
		}
		case 3:
		{
			
			[wordBubble removeAllChildrenWithCleanup:YES];
			
			[words setPosition:ccp(positionWords.x, positionWords.y)];
			// ****** Gabriel Talking ****** 
			text = @"But we gotta use MATH\nto solve the puzzles in\nthe game, and that's\nwhy I'm here, to help\nYOU out!";
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
		case 4:
		{
			[wordBubble removeChild:fingerSprite cleanup:YES];
			// ****** Gabriel Talking ****** 
			text = @"To start you off, I will\nask you a question and\nyou will answer it as\nbest as you can. Ready?\nHeeeeeere goes!";
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
		case 5:
		{
			[self doTest:TESTPLUS];
						
			break;
		}
		case 6:
		{
			[self doTest:TESTMINUS];
			break;
		}
		case 7:
		{
			[self doTest:TESTTIMES];
			break;
		}
		case 8:
		{
			[self doTest:TESTDIVISION];
			break;
		}
		case 9:
		{
			
			break;
		}
		case 10:
		{
			break;
		}
		case 11:
		{
			
			break;
		}
		case 12:
		{
			[words setPosition:ccp(positionWords.x, positionWords.y)];
			// ****** Gabriel Talking ****** 
			text = @"GRRRRREATTT!!!!\n\nYou're incredible! Ok,\nthat's all I have for this\ntutorial, See you soon!";
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
			
			[wordBubble removeAllChildrenWithCleanup:YES];
			[self removeChild:nextButton cleanup:YES];
			nextButton = nil;
			
			menuButton = [Button  buttonWithImage:CONSTANT_BUTTONS_MENU atPosition:positionNextButton target:self selector:@selector(goToMainMenu:) enablePush:NO];	
			[self addChild:menuButton];
			[Button unCheckAll:menuButton];
			
			
			[self schedule:@selector(goToMainMenu:) interval: PSCONFIG_TUTORIAL_TIMETOREAD];
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
- (void)doTest:(BasicTestType)type
{
	[words setPosition:ccp(positionWords.x, positionWords.y - 90)];
	[wordBubble removeAllChildrenWithCleanup:YES];
	// ****** Gabriel Talking ****** 
	int timesTalking, durationTalking;
	NSString *text = @"Press the right answer\nwith your fingers";
	durationTalking = PSCONFIG_TALKING_DURATION([text length]);
	timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
	id actionTalking = [Spawn actions:
						[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
						[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
						nil];
	[gabrielSprite runAction:actionTalking];
	
	int positionYOperation = 20 + wordBubble.contentSize.height*3/4;
	int positionYOptions =  wordBubble.contentSize.height*1/4;
	int positionX = wordBubble.contentSize.width/2;
	Sprite *problemSprite;
	switch (type) {
		case TESTPLUS:
			problemSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TESTPLUS];
			break;
		case TESTMINUS:
			problemSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TESTMINUS];
			break;
		case TESTTIMES:
			problemSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TESTTIMES];
			break;
		case TESTDIVISION:
			problemSprite = [Sprite spriteWithFile:CONSTANT_TUTORIALELEMENTS_TESTDIVISION];
			break;
		default:
			break;
	}
	
	[problemSprite setPosition:ccp(positionX,positionYOperation)];
	[wordBubble addChild:problemSprite];
	
	PSBlock *wrongBlock1 =[PSBlock newPSBlock:FIVE];
	[wrongBlock1 setPosition:ccp(positionX - 80,positionYOptions)];
	[wordBubble addChild:wrongBlock1];
	board[0] = wrongBlock1;
	
	PSBlock *rightBlock = [PSBlock newPSBlock:FOUR];
	[rightBlock setPosition:ccp(positionX - 20,positionYOptions)];
	[wordBubble addChild:rightBlock];
	board[1] = rightBlock;
	
	PSBlock *wrongBlock2 = [PSBlock newPSBlock:SEVEN];
	[wrongBlock2 setPosition:ccp(positionX + 40,positionYOptions)];
	[wordBubble addChild:wrongBlock2];
	board[2] = wrongBlock2;
	
	currentTest = type;
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
	/*
	int x = point.x - (pX-w/2);
	int y = point.y - (pY-h/2);
	point = ccp(x+26, y-20);
	
	NSUInteger i, count = 3;
	for (i = 0; i < count; i++) {
		PSBlock * obj = board[i];
		if (CGRectContainsPoint([obj rect], point)) 
		{
			if (obj.value == FOUR)
				[self rightSolution];
			else
				[self wrongSolution];
			break;
		} 
	}
	*/
	//******
	CGPoint loc = CGPointMake(pX - (w/2), pY - (h/2));	
	CGRect rect = CGRectMake(loc.x, loc.y, w, h); 
	if (CGRectContainsPoint(rect, point)) 
	{
		for (int x=0; x<3; x++) 
		{
				PSBlock *block = board[x];
				float blockW = [block contentSize].width;
				float blockH = [block contentSize].height;
								
				CGPoint blockLoc = CGPointMake([block position].x - (blockW/2), [block position].y - (blockH/2));	
				CGRect rect = CGRectMake(loc.x + blockLoc.x+26, loc.y + blockLoc.y+26, blockW, blockH); 
				
				if (CGRectContainsPoint(rect, point)) 
				{					
					if (block.value == FOUR)
						[self rightSolution];
					else
						[self wrongSolution];
					break;
				}	
		}
	}
	//******
	
	
  	return kEventHandled;
}

- (void)testDone:(BasicTestType)type
{
	[wordBubble removeAllChildrenWithCleanup:YES];
	[gabrielSprite stopAllActions];
	
	NSString *text ;
	int timesTalking, durationTalking;
	
	if (type != TESTDIVISION)
	{
		text=@"GRRRRREATTT!!!!\n\nHere's the next one, you\nready? Let's go!";
	}
	else
	{
		text=@"GRRRRREATTT!!!!\n\nYou're incredible! Ok,\nthat's all I have for this\ntutorial, See you soon!";
		
		[self removeChild:nextButton cleanup:YES];
		nextButton = nil;
		
		menuButton = [Button  buttonWithImage:CONSTANT_BUTTONS_MENU atPosition:positionNextButton target:self selector:@selector(goToMainMenu:) enablePush:NO];	
		[self addChild:menuButton];
		[Button unCheckAll:menuButton];
		
		[self schedule:@selector(goToMainMenu:) interval: PSCONFIG_TUTORIAL_TIMETOREAD];
	}
	
	[words setPosition:ccp(positionWords.x, positionWords.y)];
	// ****** Gabriel Talking ****** 
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
}

- (void)wrongSolution
{
	[wordBubble removeAllChildrenWithCleanup:YES];
	[gabrielSprite stopAllActions];
	[words setPosition:ccp(positionWords.x, positionWords.y)];
	// ****** Gabriel Talking ****** 
	NSString *text = @"Awww! That wasn't\nright... Let's try again,\nok? I know this time you\ncan do it, you're very\nsmart!";
	int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
	int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
	id actionTalking = [Spawn actions:
						[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
						[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
						nil];
	[gabrielSprite runAction:actionTalking];
	
	int positionYOptions = 100;
	
	Button * noWayButton = [Button  buttonWithImage:CONSTANT_BUTTONS_NOWAY atPosition:ccp((wordBubble.contentSize.width*1/4) + 10,positionYOptions) target:self selector:@selector(noWayAction:) enablePush:NO];	
	[noWayButton setPosition:ccp((wordBubble.contentSize.width*1/4) + 10,positionYOptions)];
	[wordBubble addChild:noWayButton];
	
	Button * alrightButton = [Button  buttonWithImage:CONSTANT_BUTTONS_ALRIGHT atPosition:ccp((wordBubble.contentSize.width*3/4) - 10,positionYOptions) target:self selector:@selector(alrightAction:) enablePush:NO];	
	[alrightButton setPosition:ccp((wordBubble.contentSize.width*3/4) - 10,positionYOptions)];
	[wordBubble addChild:alrightButton];
}
- (void)rightSolution
{
	[self testDone:currentTest];
	//currentStep++;
	//[self goToStep:currentStep];
}

- (void)noWayAction:(id)sender
{
	[gabrielSprite stopAllActions];
	// ****** Gabriel Talking ****** 
	NSString *text = @"Oh, you give up? Ok!\nSee you soon! Come back\nand try again anytime!";
	int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
	int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
	id actionTalking = [Sequence actions:[Spawn actions:
						[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
						[
						 TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
										  nil],
						[CallFunc actionWithTarget:self selector:@selector(activeNextButton)],
						nil
						];
	[gabrielSprite runAction:actionTalking];
	
	[wordBubble removeAllChildrenWithCleanup:YES];
		
	[self removeChild:nextButton cleanup:YES];
	nextButton = nil;
	menuButton = [Button  buttonWithImage:CONSTANT_BUTTONS_MENU atPosition:positionNextButton target:self selector:@selector(goToMainMenu:) enablePush:NO];	
	[self addChild:menuButton];
	[Button unCheckAll:menuButton];
}
- (void)alrightAction:(id)sender
{
	[self goToStep:currentStep];
}
@end
