//
//  ButtonGameOptionMenuLayer.m
//  plusSign
//
//  Created by Genki-Oki on 12/22/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "ButtonGameOptionMenuLayer.h"


@implementation ButtonGameOptionMenuLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		[self setIsTouchEnabled:YES];
		
		CGPoint positionGabriel = ccp(250,430);
		CGPoint positionWordBubble = ccp(160,390);
		CGPoint positionWords = ccp(130,380);
		
		// ****** Gabriel ****** 
		gabrielSprite = [Sprite spriteWithFile: [[NSString alloc] initWithFormat:CONSTANT_ANIMATION_GABIHEAD_1_SMALL]];
		
		//create an Animation object to hold the frame for the walk cycle
		gabrielTalking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.10];
		
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
		words = [Label labelWithString:NSLocalizedString(@"", @"") dimensions:CGSizeMake(200, 100) alignment:UITextAlignmentLeft fontName:@"Verdana" fontSize:20];
		[words setPosition:positionWords];
		[words setColor:ccc3(0,0,0)];
		[self addChild:words z:5];
		
		// ****** Gabriel Talking ****** 
		NSString *text = @"Please select the\nMath Sign to play with";
		int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
		int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
		id actionTalking = [Spawn actions:
							[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
							[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
							nil];
		[gabrielSprite runAction:actionTalking];
		
		
		Button * menuButton = [Button buttonWithImage:CONSTANT_BUTTONS_BACKTOMENU atPosition:ccp(96, 32) target:self selector:@selector(goToMenu:) enablePush:NO];	
		
		[self addChild:menuButton];
		
		
		int positionX = 80;
		int positionY = 280;
		int offsetY = 80;
		int offsetX = 160;
		int indexX = 0;
		int indexY = 0;
		
		plusButton = [Button  buttonWithImage:CONSTANT_BUTTONS_PLUS atPosition:ccp(positionX + (offsetX * indexX++), positionY - (offsetY * indexY)) target:self selector:@selector(clickSign:) enablePush:NO];	
		minusButton = [Button buttonWithImage:CONSTANT_BUTTONS_MINUS atPosition:ccp(positionX + (offsetX * indexX--), positionY - (offsetY * indexY++)) target:self selector:@selector(clickSign:) enablePush:NO];	
		
		timesButton = [Button buttonWithImage:CONSTANT_BUTTONS_TIMES atPosition:ccp(positionX + (offsetX * indexX++), positionY - (offsetY * indexY)) target:self selector:@selector(clickSign:) enablePush:NO];	
		divisionButton = [Button buttonWithImage:CONSTANT_BUTTONS_DIVISION atPosition:ccp(positionX + (offsetX * indexX), positionY - (offsetY * indexY++)) target:self selector:@selector(clickSign:) enablePush:NO];	
		
		[Button unCheckAll:plusButton];
		[Button unCheckAll:minusButton];
		[Button unCheckAll:timesButton];
		[Button unCheckAll:divisionButton];
		signsCounter = 0;
		
		[self addChild:plusButton];
		[self addChild:minusButton];
		[self addChild:timesButton];
		[self addChild:divisionButton];
		
		doneButton = [Button  buttonWithImage:CONSTANT_BUTTONS_DONE atPosition:ccp(160, positionY - (offsetY * indexY)) target:self selector:@selector(goToSelectMode:) enablePush:NO];	
		[self addChild:doneButton];
		[doneButton setVisible:NO];
		
		currentState = [PSData newPSData];
	}
	return self;
}

- (BOOL) isSomethingSelected
{
	return [Button isSomethingChecked: plusButton] || [Button isSomethingChecked: minusButton] || [Button isSomethingChecked: timesButton] || [Button isSomethingChecked: divisionButton];
}

- (void)clickSign:(id)sender
{
		[gabrielSprite stopAllActions];
	
	ButtonItem *tmp = (ButtonItem *)sender;
	[tmp doCheck];
	
	if ([tmp checked])
		signsCounter++;
	else
		signsCounter--;
	
	[doneButton setVisible:[self isSomethingSelected]];
	
	//Change the text
	NSString *text;
	switch (signsCounter) {
		case 1:
			text = NSLocalizedString(@"You can select a\nsecond Math Sign", @"");
			break;
		case 2:
			text = NSLocalizedString(@"You can select a\nthird Math Sign", @"");
			break;
		case 3:
			text = NSLocalizedString(@"You can select a\nfourth Math Sign", @"");
			break;
		case 4:
			text = NSLocalizedString(@"Click DONE!\nwhen you're ready", @"");
			break;
		default:
			text = NSLocalizedString(@"Please select the\nMath Sign to play with", @"");
			break;
	}
	// ****** Gabriel Talking ****** 
	
	int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
	int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
	actionTalking = [Spawn actions:
						[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking],
						[TalkAction actionWithDuration:durationTalking textToSay:text label:words],
						nil];
	[gabrielSprite runAction:actionTalking];
}
- (void)goToMenu:(id)sender
{
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[MainMenuScene node]]];
}
- (void)goToPlay:(id)sender
{
	ButtonItem *tmp = (ButtonItem *)sender;
	if (tmp == cakeButton)
	{
		currentState.mode = CAKE;
		currentState.time = PSCONFIG_GAMEPLAY_TIME_CAKE/60;
	}
	else if (tmp == happyButton)
	{
		currentState.mode = HAPPY;
		currentState.time = PSCONFIG_GAMEPLAY_TIME_HAPPY/60;
	}
	else
	{
		currentState.mode = TOUGH;
		currentState.time = PSCONFIG_GAMEPLAY_TIME_TOUGH/60;
	}
	
	GameScene *node = [[GameScene alloc] init];
	
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:node]];
}
- (void)goToSelectMode:(id)sender
{
	if (!doneButton.visible) return;
	
	currentState.signPlus = [Button isSomethingChecked: plusButton];
	currentState.signMinus = [Button isSomethingChecked: minusButton];
	currentState.signTimes = [Button isSomethingChecked: timesButton];
	currentState.signDivision = [Button isSomethingChecked: divisionButton];
	
	[self removeChild:plusButton cleanup:YES];
	[self removeChild:minusButton cleanup:YES];
	[self removeChild:timesButton cleanup:YES];
	[self removeChild:divisionButton cleanup:YES];
	[self removeChild:doneButton cleanup:YES];
	
	// ****** Gabriel Talking ****** 
	NSString *text = @"Please select a\ndifficulty to play";
	int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
	int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
	id actionTalking = [Spawn actions:
						[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
						[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
						nil];
	[gabrielSprite runAction:actionTalking];
	
	//AddModes
	
	cakeButton = [ButtonItem buttonWithImage:CONSTANT_GAMEELEMENTS_WHITE_BAR target:self selector:@selector(goToPlay:) enablePush:NO];	
	happyButton = [ButtonItem buttonWithImage:CONSTANT_GAMEELEMENTS_WHITE_BAR target:self selector:@selector(goToPlay:) enablePush:NO];	
	toughButton = [ButtonItem buttonWithImage:CONSTANT_GAMEELEMENTS_WHITE_BAR target:self selector:@selector(goToPlay:) enablePush:NO];	
	
	Menu *modes = [Menu menuWithItems:cakeButton, happyButton, toughButton, nil];
	modes.position = ccp(160, 200);
	[modes alignItemsVertically];
	
	
	[self setMode:CAKE sprite:[cakeButton getImage]];
	[self setMode:HAPPY sprite:[happyButton getImage]];
	[self setMode:TOUGH sprite:[toughButton getImage]];
	
	[self addChild:modes];
}

- (void) setMode:(tMODE) mode sprite:(Sprite *) sprite
{
	Sprite * plusSign = [Sprite spriteWithFile:CONSTANT_SIGNS_PLUS];
	Sprite * minusSign = [Sprite spriteWithFile:CONSTANT_SIGNS_MINUS];
	Sprite * timesSign = [Sprite spriteWithFile:CONSTANT_SIGNS_TIMES];
	Sprite * divisionSign = [Sprite spriteWithFile:CONSTANT_SIGNS_DIVISION];
	[plusSign setPosition:ccp(27, 60)];//25
	[minusSign setPosition:ccp(64, 60)];//68
	[timesSign setPosition:ccp(27, 24)];
	[divisionSign setPosition:ccp(64, 24)];
	
	if (!currentState.signPlus) [plusSign setOpacity:128];
	if (!currentState.signMinus) [minusSign setOpacity:128];
	if (!currentState.signTimes) [timesSign setOpacity:128];
	if (!currentState.signDivision) [divisionSign setOpacity:128];
		
	NSString *text;
	switch (mode) {
		case CAKE:
			text = [[NSString alloc] initWithFormat:@"CAKE MODE\nGoal: %d points\nTime: %d:%02d", PSCONFIG_GAMEPLAY_GOAL_CAKE, PSCONFIG_GAMEPLAY_TIME_CAKE / 60, PSCONFIG_GAMEPLAY_TIME_CAKE % 60];//NSLocalizedString(@"CAKE MODE\nGoal: 4000 points\nTime: 3:00", @"");
			break;
		case HAPPY:
			text = [[NSString alloc] initWithFormat:@"HAPPY MODE\nGoal: %d points\nTime: %d:%02d", PSCONFIG_GAMEPLAY_GOAL_HAPPY, PSCONFIG_GAMEPLAY_TIME_HAPPY / 60, PSCONFIG_GAMEPLAY_TIME_HAPPY % 60];//NSLocalizedString(@"HAPPY MODE\nGoal: 9000 points\nTime: 4:00", @"");
			break;
		case TOUGH:
			text = [[NSString alloc] initWithFormat:@"TOUGH MODE\nGoal: %d points\nTime: %d:%02d", PSCONFIG_GAMEPLAY_GOAL_TOUGH, PSCONFIG_GAMEPLAY_TIME_TOUGH / 60, PSCONFIG_GAMEPLAY_TIME_TOUGH % 60];//NSLocalizedString(@"TOUGH MODE\nGoal: 20000 points\nTime: 5:00", @"");
			break;
		default:
			text = [[NSString alloc] initWithFormat:@"CAKE MODE\nGoal: %d points\nTime: %d:%02d", PSCONFIG_GAMEPLAY_GOAL_CAKE, PSCONFIG_GAMEPLAY_TIME_CAKE / 60, PSCONFIG_GAMEPLAY_TIME_CAKE % 60];//NSLocalizedString(@"CAKE MODE\nGoal: 4000 points\nTime: 3:00", @"");
			break;
	}
	
	Label * wordsCake = [Label labelWithString:text dimensions:CGSizeMake(180, 100) alignment:UITextAlignmentRight fontName:@"Verdana" fontSize:16];
	[wordsCake setPosition:ccp(206,24)]; //16
	[wordsCake setColor:ccc3(0,0,0)];
	
	[sprite addChild:plusSign];
	[sprite addChild:minusSign];
	[sprite addChild:timesSign];
	[sprite addChild:divisionSign];
	[sprite addChild:wordsCake z:5];
}

@end
