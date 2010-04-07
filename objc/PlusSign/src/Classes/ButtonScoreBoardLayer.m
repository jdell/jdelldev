//
//  ButtonScoreBoardLayer.m
//  plusSign
//
//  Created by Genki-Oki on 1/4/10.
//  Copyright 2010 Genki-Oki. All rights reserved.
//

#import "ButtonScoreBoardLayer.h"


@implementation ButtonScoreBoardLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		[self setIsTouchEnabled:YES];
		[self setEnableLayer:YES];
		
		CGPoint positionGabriel = ccp(250,430);//390);
		CGPoint positionWordBubble = ccp(160,390);
		CGPoint positionWords = ccp(140,380);//140,370
		//positionGabriel = ccp(240,90);
		
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
		words = [Label labelWithString:NSLocalizedString(@"", @"") dimensions:CGSizeMake(220, 100) alignment:UITextAlignmentLeft fontName:@"Verdana" fontSize:20];
		[words setPosition:positionWords];
		[words setColor:ccc3(0,0,0)];
		[self addChild:words z:5];
		
		// ****** Gabriel Talking ****** 
		NSString *text = @"Check out your\nScore and\nsubmit it!";
		int durationTalking = PSCONFIG_TALKING_DURATION([text length]);
		int timesTalking = PSCONFIG_TALKING_TIMES(durationTalking, [gabrielTalking delay], [[gabrielTalking frames] count]);
		id actionTalking = [Spawn actions:
							[Repeat actionWithAction:[Animate actionWithAnimation:gabrielTalking ] times:timesTalking ],
							[TalkAction actionWithDuration:durationTalking textToSay:NSLocalizedString(text, @"") label:words],
							nil];
		[gabrielSprite runAction:actionTalking];

		
		Sprite *cakeScore = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_WHITE_BAR];
		Sprite *happyScore = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_WHITE_BAR];
		Sprite *toughScore = [Sprite spriteWithFile:CONSTANT_GAMEELEMENTS_WHITE_BAR];
		
	
		[self setMode:CAKE sprite:cakeScore];
		[self setMode:HAPPY sprite:happyScore];
		[self setMode:TOUGH sprite:toughScore];
		
		[self addChild:cakeScore];
		[self addChild:happyScore];
		[self addChild:toughScore];
		
		
		Button *menuButton = [Button  buttonWithImage:CONSTANT_BUTTONS_MENU atPosition:ccp(70, 30) target:self selector:@selector(goToMainMenu:) enablePush:NO];	
		[self addChild:menuButton];
		
		Button *scoreboardButton = [Button  buttonWithImage:CONSTANT_BUTTONS_SCOREBOARD atPosition:ccp(220, 30) target:self selector:@selector(goToScoreBoardPage:) enablePush:NO];	
		[self addChild:scoreboardButton];
		
		Button *submitCAKE = [Button  buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250+5, 290 - (90*0)) target:self selector:@selector(goToSubmitScoreCake:) enablePush:NO];	
		[self addChild:submitCAKE];
		
		Button *submitHAPPY = [Button  buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250+5, 290 - (90*1)) target:self selector:@selector(goToSubmitScoreHappy:) enablePush:NO];	
		[self addChild:submitHAPPY];
		
		Button *submitTOUGH = [Button  buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250+5, 290 - (90*2)) target:self selector:@selector(goToSubmitScoreTough:) enablePush:NO];	
		[self addChild:submitTOUGH];		
	}
	return self;
}

- (void) setMode:(tMODE) mode sprite:(Sprite *) sprite
{
	Sprite * plusSign = [Sprite spriteWithFile:CONSTANT_SIGNS_PLUS];
	Sprite * minusSign = [Sprite spriteWithFile:CONSTANT_SIGNS_MINUS];
	Sprite * timesSign = [Sprite spriteWithFile:CONSTANT_SIGNS_TIMES];
	Sprite * divisionSign = [Sprite spriteWithFile:CONSTANT_SIGNS_DIVISION];
	
	[plusSign setPosition:ccp(27, 60)];//62
	[minusSign setPosition:ccp(64, 60)];//62
	[timesSign setPosition:ccp(27, 24)];//26
	[divisionSign setPosition:ccp(64, 24)];//26
	
	NSString *text;
	Button * submitScore;
	int index = 0;
	PSData *saveState = [PSData initPSData:mode];
	[saveState loadData];
	switch (mode) {
		case CAKE:
			text = [[NSString alloc] initWithFormat:@"CAKE MODE\n%05d pts\n%02d:%02d Min", saveState.score, saveState.time / 60, saveState.time % 60];
			submitScore	= [Button buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250, 42) target:self selector:@selector(goToSubmitScore:)];
			break;
		case HAPPY:
			text = [[NSString alloc] initWithFormat:@"HAPPY MODE\n%05d pts\n%02d:%02d Min", saveState.score, saveState.time / 60, saveState.time % 60];
			submitScore	= [Button buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250,42) target:self selector:@selector(goToSubmitScoreHappy:)];
			index = 1;
			break;
		case TOUGH:
			text = [[NSString alloc] initWithFormat:@"TOUGH MODE\n%05d pts\n%02d:%02d Min", saveState.score, saveState.time / 60, saveState.time % 60];
			submitScore	= [Button buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250,42) target:self selector:@selector(goToSubmitScoreTough:)];
			index = 2;
			break;
		default:
			text = [[NSString alloc] initWithFormat:@"CAKE MODE\n%05d pts\n%02d:%02d Min", saveState.score, saveState.time / 60, saveState.time % 60];
			submitScore	= [Button buttonWithImage:CONSTANT_BUTTONS_SUBMITSCORE atPosition:ccp(250,42) target:self selector:@selector(goToSubmitScoreCake:)];
			break;
	}
	text =  NSLocalizedString(text, @"");
	
	Label * wordsCake = [Label labelWithString:text dimensions:CGSizeMake(180, 80) alignment:UITextAlignmentCenter fontName:@"Verdana" fontSize:14];
	[wordsCake setPosition:ccp(146,32)];
	[wordsCake setColor:ccc3(0,0,0)];
		
	if (!saveState.signPlus) [plusSign setOpacity:120];
	if (!saveState.signMinus) [minusSign setOpacity:120];
	if (!saveState.signTimes) [timesSign setOpacity:120];
	if (!saveState.signDivision) [divisionSign setOpacity:120];
	
	[sprite addChild:plusSign];
	[sprite addChild:minusSign];
	[sprite addChild:timesSign];
	[sprite addChild:divisionSign];
	[sprite addChild:wordsCake z:5];
	
	[sprite setPosition:ccp(160, 290 - (90*index))];
	//[submitScore setPosition:ccp(submitScore.position.x, submitScore.position.y +  sprite.position.y)];
	
	//[self addChild:submitScore];
}

@synthesize enableLayer;

- (void)goToMainMenu:(id)sender
{
	if (![self enableLayer])
		return;
	
	[[Director sharedDirector] replaceScene:[ZoomFlipXTransition transitionWithDuration:0.2 scene:[MainMenuScene node]]];
}

- (void)goToSubmitScoreCake:(id)sender
{
	[self goToSubmitScore: CAKE];
}
- (void)goToSubmitScoreHappy:(id)sender
{
	[self goToSubmitScore: HAPPY];
}
- (void)goToSubmitScoreTough:(id)sender
{
	[self goToSubmitScore: TOUGH];
}

- (void)goToSubmitScore:(tMODE)mode
{
	if (![self enableLayer])
		return;
	
	PSData *dataToSubmit = [PSData initPSData:mode];
	[dataToSubmit loadData];
	
	if ([dataToSubmit score]>0)
	{
	
		NSURL *plusSignURL = [NSURL URLWithString:PSCONFIG_URL_SCOREBOARD_SUBMIT];
		ASIFormDataRequest *request = [[[ASIFormDataRequest alloc] initWithURL:plusSignURL] autorelease];
		[request setPostValue:[[UIDevice currentDevice] uniqueIdentifier] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_UDID];
		[request setPostValue:[[UIDevice currentDevice] name] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_NAME];
	
		[request setPostValue:[NSString stringWithFormat:@"%d", [dataToSubmit mode] +1] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_MODE];
		[request setPostValue:[NSString stringWithFormat:@"%d", [dataToSubmit score]] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_SCORE];
		[request setPostValue:[NSString stringWithFormat:@"%d", [dataToSubmit signPlus]] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_PLUSSIGN];
		[request setPostValue:[NSString stringWithFormat:@"%d", [dataToSubmit signMinus]] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_MINUSSIGN];
		[request setPostValue:[NSString stringWithFormat:@"%d", [dataToSubmit signTimes]] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_TIMESSIGN];
		[request setPostValue:[NSString stringWithFormat:@"%d", [dataToSubmit signDivision]] forKey:PSCONFIG_URL_SCOREBOARD_SUBMIT_POSTVALUE_DIVISIONSIGN];
		
		
		[request startSynchronous];
		NSError *error = [request error];
		NSString *message;
		if (!error)
		{
			message = @"Score submitted! You can check your score online.";
			//NSString *response = [request responseString];
			
			scoreSubmitted = [ScoreSubmittedScoreBoardLayer node];
			[self addChild:scoreSubmitted z:3];
			[self setEnableLayer:NO];
			
		}
		else
		{
			message = @"Score not submitted! Check your internet conection and try it again.";
			scoreFailed = [ScoreFailedScoreBoardLayer node];
			[self addChild:scoreFailed z:3];
			[self setEnableLayer:NO];
		}		
		/*
		[[Director sharedDirector] pause];
		
		UIAlertView *alert = [[UIAlertView alloc] 
							  initWithTitle:@"Scoreboard - Submit" 
							  message: message
							  delegate:self 
							  cancelButtonTitle:@"OK" 
							  otherButtonTitles:nil ];
		[alert show];
		[alert release];
		*/
	}
}

- (void) alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{	
	[[Director sharedDirector]resume];	
}

- (void)goToScoreBoardPage:(id)sender
{	
	if (![self enableLayer])
		return;
	
	NSURL *plusSignURL = [NSURL URLWithString:PSCONFIG_URL_SCOREBOARD_SITE];
	[[UIApplication sharedApplication] openURL:plusSignURL];
}

@end
